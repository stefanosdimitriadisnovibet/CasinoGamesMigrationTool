using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.NetEnt
{
	public static class XmlNoviCasinoDesktopNetEntHandler
	{
		public static XmlNoviCasinoDesktopNetEntGame[] HandleGames(this XmlParser.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntResponse response)
		{
			XmlNoviCasinoDesktopNetEntGame[] games = response.Result.Root.Games.Games
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
					bool tableIdSucceeded = int.TryParse(game.TableId, out int tableId);

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

						if (tableIdSucceeded == false)
							errorMessages.Add(nameof(tableIdSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntGame>(game);

						return null;
					}

					return new XmlNoviCasinoDesktopNetEntGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						Sysname = game.Id,
						IsLive = isLive,
						IsMobile = isMobile,
						Id = providerId,
						ProviderSysname = game.Source,
						TableId = tableId,
						Theme = game.Theme,
						TypeFilter = game.GameTypeFilter
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNoviCasinoDesktopNetEntJackpotGame[] HandleJacktopGames(this XmlParser.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntResponse response)
		{
			XmlNoviCasinoDesktopNetEntJackpotGame[] games = response.Result.Root.JackpotGames.JackpotGames
				.Select(game =>
				{
					return new XmlNoviCasinoDesktopNetEntJackpotGame
					{
						Sysname = game.Sysname,
						ProviderSysname = game.JackpotName
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNoviCasinoDesktopNetEntGameLanguages[] HandleGameLanguages(this XmlParser.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntResponse response)
		{
			XmlNoviCasinoDesktopNetEntGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNoviCasinoDesktopNetEntGameLanguages
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