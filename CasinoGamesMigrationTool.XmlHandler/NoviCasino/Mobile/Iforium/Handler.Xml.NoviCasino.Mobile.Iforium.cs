﻿using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.Iforium
{
	public static class XmlNoviCasinoMobileIforiumHandler
	{
		public static XmlNoviCasinoMobileIforiumGame[] HandleGames(this XmlParser.NoviCasino.Mobile.Iforium.XmlNoviCasinoMobileIforiumResponse response)
		{
			XmlNoviCasinoMobileIforiumGame[] games = response.Result.Root.Games.Games
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
					bool sourceSucceeded = int.TryParse(game.Source, out int source);

					if (isLiveSucceeded == false
						|| isMobileSucceeded == false
						|| providerIdSucceeded == false
						|| sourceSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (isLiveSucceeded == false)
							errorMessages.Add(nameof(isLiveSucceeded));

						if (isMobileSucceeded == false)
							errorMessages.Add(nameof(isMobileSucceeded));

						if (providerIdSucceeded == false)
							errorMessages.Add(nameof(providerIdSucceeded));

						if (sourceSucceeded == false)
							errorMessages.Add(nameof(sourceSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Mobile.Iforium.XmlNoviCasinoMobileIforiumGame>(game);

						return null;
					}

					return new XmlNoviCasinoMobileIforiumGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						Sysname = game.Id,
						IsLive = isLive,
						IsMobile = isMobile,
						Id = providerId,
						ProviderId = source,
						Caption = game.Caption,
						TypeFilter = game.GameTypeFilter
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNoviCasinoMobileIforiumGameLanguages[] HandleGameLanguages(this XmlParser.NoviCasino.Mobile.Iforium.XmlNoviCasinoMobileIforiumResponse response)
		{
			XmlNoviCasinoMobileIforiumGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNoviCasinoMobileIforiumGameLanguages
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