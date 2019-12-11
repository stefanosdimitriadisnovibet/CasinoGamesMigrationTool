using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Microgaming
{
	public static class XmlNovibetMobileMicrogamingHandler
	{
		public static XmlNovibetMobileMicrogamingGame[] HandleGames(this XmlParser.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingResponse response)
		{
			XmlNovibetMobileMicrogamingGame[] games = response.Result.Root.Games.Games
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

						XmlHandler.Logger.Log<XmlParser.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingGame>(game);

						return null;
					}

					return new XmlNovibetMobileMicrogamingGame
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

		public static XmlNovibetMobileMicrogamingJackpotGame[] HandleJacktopGames(this XmlParser.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingResponse response)
		{
			XmlNovibetMobileMicrogamingJackpotGame[] games = response.Result.Root.JackpotGames.JackpotGames
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

						XmlHandler.Logger.Log<XmlParser.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingJackpotGame>(game);

						return null;
					}

					return new XmlNovibetMobileMicrogamingJackpotGame
					{
						Sysname = game.Sysname,
						ModuleId = moduleId
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNovibetMobileMicrogamingGameLanguages[] HandleGameLanguages(this XmlParser.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingResponse response)
		{
			XmlNovibetMobileMicrogamingGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNovibetMobileMicrogamingGameLanguages
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