using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.CMS.Desktop
{
	public static class XmlCMSDesktopHandler
	{
		public static XmlCMSDesktopGame[] HandleGames(this XmlParser.CMS.Desktop.XmlCMSDesktopResponse response)
		{
			XmlCMSDesktopGame[] games = response.Result.Root.Games.Game
				.Select(game =>
				{
					bool captionSucceeded = int.TryParse(game.Caption, out int caption);
					bool isVisibleSucceeded = bool.TryParse(game.IsVisible, out bool isVisible);

					if (captionSucceeded == false
						|| isVisibleSucceeded == false)
					{
						List<string> errorMessages = new List<string>();

						if (captionSucceeded == false)
							errorMessages.Add(nameof(captionSucceeded));

						if (isVisibleSucceeded == false)
							errorMessages.Add(nameof(isVisibleSucceeded));

						Error error = new Error
						{
							Messages = errorMessages.ToArray()
						};

						XmlHandler.Logger.LogError<Error>(error);

						XmlHandler.Logger.Log<XmlParser.CMS.Desktop.Game>(game);

						return null;
					}

					return new XmlCMSDesktopGame
					{
						BannerLiveCasinoUrl = game.BannerLiveCasinoUrl,
						BannerUrl = game.BannerUrl,
						Caption = caption,
						CasinoGameProvider = game.CasinoGameProvider,
						CasinoSubProvider = game.CasinoSubProvider,
						IsVisible = isVisible,
						JackpotGame = game.JackpotGame,
						NewGame = game.NewGame,
						PopularGame = game.PopularGame,
						Sysname = game.SysName
					};
				})
				.ToArray();

			return games;
		}
	}
}