using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.KingSolomons.Mobile.PlayTech
{
	public static class XmlKingSolomonsMobilePlayTechHandler
	{
		public static XmlKingSolomonsMobilePlayTechGame[] HandleGames(this XmlParser.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechResponse response)
		{
			XmlKingSolomonsMobilePlayTechGame[] games = response.Result.Root.Games.Games
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

						XmlHandler.Logger.Log<XmlParser.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechGame>(game);

						return null;
					}

					return new XmlKingSolomonsMobilePlayTechGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						Sysname = game.Id,
						IsLive = isLive,
						IsMobile = isMobile,
						Id = providerId,
						Source = game.Source
					};
				})
				.ToArray();

			return games;
		}

		public static XmlKingSolomonsMobilePlayTechJackpotGame[] HandleJackpotGames(this XmlParser.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechResponse response)
		{
			XmlKingSolomonsMobilePlayTechJackpotGame[] games = response.Result.Root.JackpotGames.JackpotGames
				.Select(game =>
				{
					return new XmlKingSolomonsMobilePlayTechJackpotGame
					{
						GameGroup = game.GameGroup,
						Sysname = game.Sysname
					};
				})
				.ToArray();

			return games;
		}

		public static XmlKingSolomonsMobilePlayTechGameLanguage[] HandleGameLanguages(this XmlParser.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechResponse response)
		{
			XmlKingSolomonsMobilePlayTechGameLanguage[] games = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlKingSolomonsMobilePlayTechGameLanguage
					{
						HelpLanguage = gameLanguage.HelpLang,
						Path = gameLanguage.Path,
						Type = gameLanguage.Type
					};
				})
				.ToArray();

			return games;
		}
	}
}