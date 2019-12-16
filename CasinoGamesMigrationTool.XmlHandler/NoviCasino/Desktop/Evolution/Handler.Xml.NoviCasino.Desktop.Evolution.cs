using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.Evolution
{
	public static class XmlNoviCasinoDesktopEvolutionHandler
	{
		public static XmlNoviCasinoDesktopEvolutionGame[] HandleGames(this XmlParser.NoviCasino.Desktop.Evolution.XmlNoviCasinoDesktopEvolutionResponse response)
		{
			XmlNoviCasinoDesktopEvolutionGame[] games = response.Result.Root.Games.Games
				.Select(game =>
				{
					string[] countriesBanned = null;
					string[] cultures = null;

					if (string.IsNullOrWhiteSpace(game.CountriesBanned) == false)
						countriesBanned = game.CountriesBanned.Split(',');

					if (string.IsNullOrWhiteSpace(game.Culture) == false)
						cultures = game.Culture.Split(',');

					bool isLiveSucceeded = bool.TryParse(game.Live, out bool isLive);
					bool noRealityCheckSucceeded = bool.TryParse(game.Norealitycheck, out bool noRealityCheck);
					bool noDemoPlayAllowedSucceeded = bool.TryParse(game.NoDemoPlayAllowed, out bool noDemoPlayAllowed);
					bool systemSucceeded = int.TryParse(game.System, out int system);

					if (isLiveSucceeded == false
						|| noRealityCheckSucceeded == false
						|| systemSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (isLiveSucceeded == false)
							errorMessages.Add(nameof(isLiveSucceeded));

						if (noRealityCheckSucceeded == false)
							errorMessages.Add(nameof(noRealityCheckSucceeded));

						if (systemSucceeded == false)
							errorMessages.Add(nameof(systemSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Desktop.Evolution.XmlNoviCasinoDesktopEvolutionGame>(game);

						return null;
					}

					return new XmlNoviCasinoDesktopEvolutionGame
					{
						CountriesBanned = countriesBanned,
						Cultures = cultures,
						NoDemoPlayAllowed = noDemoPlayAllowed,
						Sysname = game.Id,
						IsLive = isLive,
						Alias = game.Alias,
						NoRealityCheck = noRealityCheck,
						System = system,
						Source = game.Source
					};
				})
				.ToArray();

			return games;
		}

		public static XmlNoviCasinoDesktopEvolutionGameLanguages[] HandleGameLanguages(this XmlParser.NoviCasino.Desktop.Evolution.XmlNoviCasinoDesktopEvolutionResponse response)
		{
			XmlNoviCasinoDesktopEvolutionGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNoviCasinoDesktopEvolutionGameLanguages
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