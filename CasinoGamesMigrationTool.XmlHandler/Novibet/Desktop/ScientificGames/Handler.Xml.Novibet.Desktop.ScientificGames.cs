using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.ScientificGames
{
	public static class XmlNovibetDesktopScientificGamesHandler
	{
		public static XmlNovibetDesktopScientificGamesGame[] HandleGames(this XmlParser.Novibet.Desktop.ScientificGames.XmlNovibetDesktopScientificGamesResponse response)
		{
			XmlNovibetDesktopScientificGamesGame[] games = response.Result.Root.Games.Games
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

						XmlHandler.Logger.Log<XmlParser.Novibet.Desktop.ScientificGames.XmlNovibetDesktopScientificGamesGame>(game);

						return null;
					}

					return new XmlNovibetDesktopScientificGamesGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
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

		public static XmlNovibetDesktopScientificGamesGameLanguages[] HandleGameLanguages(this XmlParser.Novibet.Desktop.ScientificGames.XmlNovibetDesktopScientificGamesResponse response)
		{
			XmlNovibetDesktopScientificGamesGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNovibetDesktopScientificGamesGameLanguages
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