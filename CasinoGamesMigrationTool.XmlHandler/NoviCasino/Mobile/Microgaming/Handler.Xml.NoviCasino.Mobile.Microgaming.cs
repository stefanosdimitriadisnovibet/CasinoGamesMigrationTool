using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.Microgaming
{
	public static class XmlNoviCasinoMobileMicrogamingHandler
	{
		public static XmlNoviCasinoMobileMicrogamingGame[] HandleGames(this XmlParser.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingResponse response)
		{
			XmlNoviCasinoMobileMicrogamingGame[] games = response.Result.Root.Games.Games
				.Select(game =>
				{
					string[] countriesBanned = null;
					string[] cultures = null;

					if (string.IsNullOrWhiteSpace(game.CountriesBanned) == false)
						countriesBanned = game.CountriesBanned.Split(',');

					if (string.IsNullOrWhiteSpace(game.Culture) == false)
						cultures = game.Culture.Split(',');

					bool isMobileSucceeded = bool.TryParse(game.Mobile, out bool isMobile);
					bool providerIdSucceeded = int.TryParse(game.ProviderId, out int providerId);

					if (isMobileSucceeded == false
						|| providerIdSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (isMobileSucceeded == false)
							errorMessages.Add(nameof(isMobileSucceeded));

						if (providerIdSucceeded == false)
							errorMessages.Add(nameof(providerIdSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingGame>(game);

						return null;
					}

					return new XmlNoviCasinoMobileMicrogamingGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						HelpUrlPattern = game.Helpurlpattern,
						Type = game.Type,
						Sysname = game.Id,
						IsMobile = isMobile,
						Id = providerId,
						Source = game.Source
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNoviCasinoMobileMicrogamingJackpotGame[] HandleJacktopGames(this XmlParser.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingResponse response)
		{
			XmlNoviCasinoMobileMicrogamingJackpotGame[] games = response.Result.Root.JackpotGames.JackpotGames
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

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingJackpotGame>(game);

						return null;
					}

					return new XmlNoviCasinoMobileMicrogamingJackpotGame
					{
						Sysname = game.Sysname,
						ModuleId = moduleId
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNoviCasinoMobileMicrogamingGameLanguages[] HandleGameLanguages(this XmlParser.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingResponse response)
		{
			XmlNoviCasinoMobileMicrogamingGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNoviCasinoMobileMicrogamingGameLanguages
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