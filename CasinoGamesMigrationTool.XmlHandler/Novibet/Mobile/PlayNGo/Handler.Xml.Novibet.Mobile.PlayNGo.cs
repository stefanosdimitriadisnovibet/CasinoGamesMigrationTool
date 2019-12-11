using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.PlayNGo
{
	public static class XmlNovibetMobilePlayNGoHandler
	{
		public static XmlNovibetMobilePlayNGoGame[] HandleGames(this XmlParser.Novibet.Mobile.PlayNGo.XmlNovibetMobilePlayNGoResponse response)
		{
			XmlNovibetMobilePlayNGoGame[] games = response.Result.Root.Games.Games
				.Select(game =>
				{
					string[] countriesBanned = null;
					string[] cultures = null;

					if (string.IsNullOrWhiteSpace(game.CountriesBanned) == false)
						countriesBanned = game.CountriesBanned.Split(',');

					if (string.IsNullOrWhiteSpace(game.Culture) == false)
						cultures = game.Culture.Split(',');

					bool isLiveSucceeded = bool.TryParse(game.Live, out bool isLive);
					bool isMobileSucceeded = bool.TryParse(game.Mobile, out bool isMobile);
					bool providerIdSucceeded = int.TryParse(game.ProviderId, out int providerId);

					if (isLiveSucceeded == false
						|| isMobileSucceeded == false
						|| providerIdSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (isLiveSucceeded == false)
							errorMessages.Add(nameof(isLiveSucceeded));

						if (isMobileSucceeded == false)
							errorMessages.Add(nameof(isMobileSucceeded));

						if (providerIdSucceeded == false)
							errorMessages.Add(nameof(providerIdSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.Novibet.Mobile.PlayNGo.XmlNovibetMobilePlayNGoGame>(game);

						return null;
					}

					return new XmlNovibetMobilePlayNGoGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						Sysname = game.Id,
						IsLive = isLive,
						IsMobile = isMobile,
						Id = providerId,
						ProviderSysname = game.Source
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNovibetMobilePlayNGoGameLanguages[] HandleGameLanguages(this XmlParser.Novibet.Mobile.PlayNGo.XmlNovibetMobilePlayNGoResponse response)
		{
			XmlNovibetMobilePlayNGoGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNovibetMobilePlayNGoGameLanguages
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