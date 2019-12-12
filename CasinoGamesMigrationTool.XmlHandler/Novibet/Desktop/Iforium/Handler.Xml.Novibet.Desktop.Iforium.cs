using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Iforium
{
	public static class XmlNovibetDesktopIforiumHandler
	{
		public static XmlNovibetDesktopIforiumGame[] HandleGames(this XmlParser.Novibet.Desktop.Iforium.XmlNovibetDesktopIforiumResponse response)
		{
			XmlNovibetDesktopIforiumGame[] games = response.Result.Root.Games.Games
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
					bool sourceSucceeded = int.TryParse(game.Source, out int source);

					if (isLiveSucceeded == false
						|| isDesktopSucceeded == false
						|| providerIdSucceeded == false
						|| sourceSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (isLiveSucceeded == false)
							errorMessages.Add(nameof(isLiveSucceeded));

						if (isDesktopSucceeded == false)
							errorMessages.Add(nameof(isDesktopSucceeded));

						if (providerIdSucceeded == false)
							errorMessages.Add(nameof(providerIdSucceeded));

						if (sourceSucceeded == false)
							errorMessages.Add(nameof(sourceSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.Novibet.Desktop.Iforium.XmlNovibetDesktopIforiumGame>(game);

						return null;
					}

					return new XmlNovibetDesktopIforiumGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						Sysname = game.Id,
						IsLive = isLive,
						IsDesktop = isDesktop,
						Id = providerId,
						ProviderId = source,
						Caption = game.Caption,
						TypeFilter = game.GameTypeFilter
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNovibetDesktopIforiumGameLanguages[] HandleGameLanguages(this XmlParser.Novibet.Desktop.Iforium.XmlNovibetDesktopIforiumResponse response)
		{
			XmlNovibetDesktopIforiumGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNovibetDesktopIforiumGameLanguages
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