using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.PlayNGo
{
	public static class XmlNoviCasinoMobilePlayNGoHandler
	{
		public static XmlNoviCasinoMobilePlayNGoGame[] HandleGames(this XmlParser.NoviCasino.Mobile.PlayNGo.XmlNoviCasinoMobilePlayNGoResponse response)
		{
			XmlNoviCasinoMobilePlayNGoGame[] games = response.Result.Root.Games.Games
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

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Mobile.PlayNGo.XmlNoviCasinoMobilePlayNGoGame>(game);

						return null;
					}

					return new XmlNoviCasinoMobilePlayNGoGame
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

		public static XmlNoviCasinoMobilePlayNGoGameLanguages[] HandleGameLanguages(this XmlParser.NoviCasino.Mobile.PlayNGo.XmlNoviCasinoMobilePlayNGoResponse response)
		{
			XmlNoviCasinoMobilePlayNGoGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNoviCasinoMobilePlayNGoGameLanguages
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