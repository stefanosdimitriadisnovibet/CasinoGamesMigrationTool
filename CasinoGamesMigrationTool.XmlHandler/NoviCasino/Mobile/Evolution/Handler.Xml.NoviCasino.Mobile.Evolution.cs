using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.Evolution
{
	public static class XmlNoviCasinoMobileEvolutionHandler
	{
		public static XmlNoviCasinoMobileEvolutionGame[] HandleGames(this XmlParser.NoviCasino.Mobile.Evolution.XmlNoviCasinoMobileEvolutionResponse response)
		{
			XmlNoviCasinoMobileEvolutionGame[] games = response.Result.Root.Games.Games
				.Select(game =>
				{
					string[] countriesBanned = null;
					string[] cultures = null;

					if (string.IsNullOrWhiteSpace(game.CountriesBanned) == false)
						countriesBanned = game.CountriesBanned.Split(',');

					if (string.IsNullOrWhiteSpace(game.Culture) == false)
						cultures = game.Culture.Split(',');

					bool isLiveSucceeded = bool.TryParse(game.Live, out bool isLive);
					bool noRealityCheckSucceeded = bool.TryParse(game.Live, out bool noRealityCheck);
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

						XmlHandler.Logger.Log<XmlParser.NoviCasino.Mobile.Evolution.XmlNoviCasinoMobileEvolutionGame>(game);

						return null;
					}

					return new XmlNoviCasinoMobileEvolutionGame
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

		public static XmlNoviCasinoMobileEvolutionGameLanguages[] HandleGameLanguages(this XmlParser.NoviCasino.Mobile.Evolution.XmlNoviCasinoMobileEvolutionResponse response)
		{
			XmlNoviCasinoMobileEvolutionGameLanguages[] gameLanguages = response.Result.Root.GameLanguages.GameLanguages
				.Select(gameLanguage =>
				{
					return new XmlNoviCasinoMobileEvolutionGameLanguages
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