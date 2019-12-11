using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.Microgaming
{
	public static class XmlNoviCasinoDesktopMicrogamingHandler
	{
		public static XmlNoviCasinoDesktopMicrogamingGame[] HandleGames(this XmlParser.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingResponse response)
		{
			XmlNoviCasinoDesktopMicrogamingGame[] games = response.Result.Root.Games.Games
				.Select(game =>
				{
					string[] countriesBanned = null;
					string[] cultures = null;

					if (string.IsNullOrWhiteSpace(game.CountriesBanned) == false)
						countriesBanned = game.CountriesBanned.Split(',');

					if (string.IsNullOrWhiteSpace(game.Culture) == false)
						cultures = game.Culture.Split(',');

					bool isLiveSucceeded = bool.TryParse(game.Live, out bool isLive);
					bool isDesktopSucceeded = bool.TryParse(game.Desktop, out bool isDesktop);
					bool providerIdSucceeded = int.TryParse(game.ProviderId, out int providerId);

					if (isLiveSucceeded == false
						|| isDesktopSucceeded == false
						|| providerIdSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (isLiveSucceeded == false)
							errorMessages.Add(nameof(isLiveSucceeded));

						if (isDesktopSucceeded == false)
							errorMessages.Add(nameof(isDesktopSucceeded));

						if (providerIdSucceeded == false)
							errorMessages.Add(nameof(providerIdSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingGame>(game);

						return null;
					}

					return new XmlNoviCasinoDesktopMicrogamingGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						HelpUrlPattern = game.Helpurlpattern,
						Type = game.Type,
						Sysname = game.Id,
						IsLive = isLive,
						IsDesktop = isDesktop,
						Id = providerId,
						Source = game.Source
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNoviCasinoDesktopMicrogamingJackpotGame[] HandleJacktopGames(this XmlParser.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingResponse response)
		{
			XmlNoviCasinoDesktopMicrogamingJackpotGame[] games = response.Result.Root.JackpotGames.JackpotGames
				.Select(game =>
				{
					bool moduleIdSucceeded = int.TryParse(game.ModuleId, out int moduleId);

					if (moduleIdSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (moduleIdSucceeded == false)
							errorMessages.Add(nameof(moduleIdSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingJackpotGame>(game);

						return null;
					}

					return new XmlNoviCasinoDesktopMicrogamingJackpotGame
					{
						Sysname = game.Sysname,
						ModuleId = moduleId
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNoviCasinoDesktopMicrogamingGameLanguages[] HandleGameLanguages(this XmlParser.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingResponse response)
		{
			XmlNoviCasinoDesktopMicrogamingGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNoviCasinoDesktopMicrogamingGameLanguages
					{
						HelpLanguage = gameLanguage.HelpLang,
						Path = gameLanguage.Path,
						Type = gameLanguage.Type
					};
				})
				.ToArray();

			return gameLanguages;
		}
	}
}