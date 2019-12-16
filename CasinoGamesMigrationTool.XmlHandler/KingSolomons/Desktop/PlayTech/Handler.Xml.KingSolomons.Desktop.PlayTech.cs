using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.KingSolomons.Desktop.PlayTech
{
	public static class XmlKingSolomonsDesktopPlayTechHandler
	{
		public static XmlKingSolomonsDesktopPlayTechGame[] HandleGames(this XmlParser.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechResponse response)
		{
			XmlKingSolomonsDesktopPlayTechGame[] games = response.Result.Root.Games.Games
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

						XmlHandler.Logger.Log<XmlParser.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechGame>(game);

						return null;
					}

					return new XmlKingSolomonsDesktopPlayTechGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						TypeFilter = game.GameTypeFilter,
						Sysname = game.Id,
						IsLive = isLive,
						IsMobile = isMobile,
						ProviderId = providerId,
						Source = game.Source
					};
				})
				.ToArray();

			return games;
		}

		public static XmlKingSolomonsDesktopPlayTechJackpotGame[] HandleJacktopGames(this XmlParser.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechResponse response)
		{
			XmlKingSolomonsDesktopPlayTechJackpotGame[] games = response.Result.Root.JackpotGames.JackpotGames
				.Select(game =>
				{
					return new XmlKingSolomonsDesktopPlayTechJackpotGame
					{
						Sysname = game.Sysname,
						GameGroup = game.GameGroup
					};
				})
				.ToArray();

			return games;
		}

		public static XmlKingSolomonsDesktopPlayTechGameLanguages[] HandleGameLanguages(this XmlParser.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechResponse response)
		{
			XmlKingSolomonsDesktopPlayTechGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlKingSolomonsDesktopPlayTechGameLanguages
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