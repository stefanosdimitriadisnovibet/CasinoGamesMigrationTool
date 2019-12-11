using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.NYX
{
	public static class XmlNovibetMobileNYXHandler
	{
		public static XmlNovibetMobileNYXGame[] HandleGames(this XmlParser.Novibet.Mobile.NYX.XmlNovibetMobileNYXResponse response)
		{
			XmlNovibetMobileNYXGame[] games = response.Result.Root.Games.Games
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
					bool noDemoPlayAllowedSucceeded = bool.TryParse(game.NoDemoPlayAllowed, out bool noDemoPlayAllowed);

					if (isLiveSucceeded == false
						|| isMobileSucceeded == false
						|| providerIdSucceeded == false
						|| noDemoPlayAllowedSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (isLiveSucceeded == false)
							errorMessages.Add(nameof(isLiveSucceeded));

						if (isMobileSucceeded == false)
							errorMessages.Add(nameof(isMobileSucceeded));

						if (providerIdSucceeded == false)
							errorMessages.Add(nameof(providerIdSucceeded));

						if (noDemoPlayAllowedSucceeded == false)
							errorMessages.Add(nameof(noDemoPlayAllowedSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.Novibet.Mobile.NYX.XmlNovibetMobileNYXGame>(game);

						return null;
					}

					return new XmlNovibetMobileNYXGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						NoDemoPlayAllowed = noDemoPlayAllowed,
						Sysname = game.Id,
						IsLive = isLive,
						IsMobile = isMobile,
						Id = providerId,
						ProviderId = game.Source
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNovibetMobileNYXGameLanguages[] HandleGameLanguages(this XmlParser.Novibet.Mobile.NYX.XmlNovibetMobileNYXResponse response)
		{
			XmlNovibetMobileNYXGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNovibetMobileNYXGameLanguages
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