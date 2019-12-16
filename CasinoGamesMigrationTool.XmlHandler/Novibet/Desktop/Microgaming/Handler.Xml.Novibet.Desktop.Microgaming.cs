using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Microgaming
{
	public static class XmlNovibetDesktopMicrogamingHandler
	{
		public static XmlNovibetDesktopMicrogamingGame[] HandleGames(this XmlParser.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingResponse response)
		{
			XmlNovibetDesktopMicrogamingGame[] games = response.Result.Root.Games.Games
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

					if (providerIdSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (providerIdSucceeded == false)
							errorMessages.Add(nameof(providerIdSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingGame>(game);

						return null;
					}

					return new XmlNovibetDesktopMicrogamingGame
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

		public static XmlNovibetDesktopMicrogamingJackpotGame[] HandleJacktopGames(this XmlParser.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingResponse response)
		{
			XmlNovibetDesktopMicrogamingJackpotGame[] games = response.Result.Root.JackpotGames.JackpotGames
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

						XmlHandler.Logger.Log<XmlParser.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingJackpotGame>(game);

						return null;
					}

					return new XmlNovibetDesktopMicrogamingJackpotGame
					{
						Sysname = game.Sysname,
						ModuleId = moduleId
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNovibetDesktopMicrogamingGameLanguages[] HandleGameLanguages(this XmlParser.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingResponse response)
		{
			XmlNovibetDesktopMicrogamingGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNovibetDesktopMicrogamingGameLanguages
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