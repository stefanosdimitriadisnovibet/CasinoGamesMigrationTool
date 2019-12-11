using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.PlayNGo
{
	public static class XmlNovibetDesktopPlayNGoHandler
	{
		public static XmlNovibetDesktopPlayNGoGame[] HandleGames(this XmlParser.Novibet.Desktop.PlayNGo.XmlNovibetDesktopPlayNGoResponse response)
		{
			XmlNovibetDesktopPlayNGoGame[] games = response.Result.Root.Games.Games
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

						XmlHandler.Logger.Log<XmlParser.Novibet.Desktop.PlayNGo.XmlNovibetDesktopPlayNGoGame>(game);

						return null;
					}

					return new XmlNovibetDesktopPlayNGoGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						Sysname = game.Id,
						IsLive = isLive,
						IsDesktop = isDesktop,
						Id = providerId,
						ProviderSysname = game.Source
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNovibetDesktopPlayNGoGameLanguages[] HandleGameLanguages(this XmlParser.Novibet.Desktop.PlayNGo.XmlNovibetDesktopPlayNGoResponse response)
		{
			XmlNovibetDesktopPlayNGoGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNovibetDesktopPlayNGoGameLanguages
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