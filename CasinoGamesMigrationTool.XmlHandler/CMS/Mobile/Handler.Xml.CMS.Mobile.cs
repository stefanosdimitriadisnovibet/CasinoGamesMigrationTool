using System.Collections.Generic;
using System.Linq;

namespace CasinoGamesMigrationTool.XmlHandler.CMS.Mobile
{
	public static class XmlCMSMobileHandler
	{
		public static XmlCMSMobileGame[] HandleGames(this XmlParser.CMS.Mobile.XmlCMSMobileResponse response)
		{
			XmlCMSMobileGame[] games = response.Result.Root.Games.Game
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

						XmlHandler.Logger.Log<XmlParser.CMS.Mobile.Game>(game);

						return null;
					}

					return new XmlCMSMobileGame
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