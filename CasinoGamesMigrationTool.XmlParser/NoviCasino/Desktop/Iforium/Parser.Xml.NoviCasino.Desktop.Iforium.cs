using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.Iforium
{
	public class XmlNoviCasinoDesktopIforiumParser : XmlParser
	{
		public static XmlNoviCasinoDesktopIforiumResponse ParseXml()
		{
			Logger.Log<string>($"Started [{nameof(XmlNoviCasinoDesktopIforiumParser)}]");

			XmlNoviCasinoDesktopIforiumResponse response = new XmlNoviCasinoDesktopIforiumResponse();
			List<string> errorMessages = new List<string>();

			try
			{
				string directory = $"{Directory.GetCurrentDirectory()}/NoviCasino/Desktop/Iforium";

				DirectoryInfo directoryInfo = new DirectoryInfo(directory);

				if (directoryInfo == null)
					errorMessages.Add("Directory not found");

				FileInfo fileInfo = directoryInfo
					.GetFiles("*.xml")
					.FirstOrDefault();

				if (fileInfo == null)
					errorMessages.Add("Xml not found");

				using (Stream stream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(XmlNoviCasinoDesktopIforiumRoot), XmlAttributeOverrides);

					XmlNoviCasinoDesktopIforiumRoot root = xmlSerializer.Deserialize(stream) as XmlNoviCasinoDesktopIforiumRoot;

					if (root == null)
						errorMessages.Add("Xml could not be deserialized");

					response.Result = new XmlNoviCasinoDesktopIforiumResult
					{
						Root = root
					};
				}
			}
			catch (Exception exception)
			{
				errorMessages.Add(exception.Message);
			}
			finally
			{
				response.Success = errorMessages.Count == 0;

				if (response.Success == false)
				{
					response.Error = new Error
					{
						Messages = errorMessages.ToArray()
					};

					Logger.LogError<Error>(response.Error);
				}

				Logger.Log<string>($"Ended [{nameof(XmlNoviCasinoDesktopIforiumParser)}]");

				Logger.Log<string>($"Games count: [{response.Result?.Root.Games.Games.Count}]");
				Logger.Log<string>($"Jackpot games count: [{response.Result?.Root.JackpotGames?.JackpotGames.Count}]");
				Logger.Log<string>($"Game languages count: [{response.Result?.Root.GameLanguages.GameLanguages.Count}]");
			}

			return response;
		}
	}
}