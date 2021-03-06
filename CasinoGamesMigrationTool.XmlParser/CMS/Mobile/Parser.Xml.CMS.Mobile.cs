﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.CMS.Mobile
{
	public class XmlCMSMobileParser : XmlParser
	{
		public static XmlCMSMobileResponse ParseXml()
		{
			Logger.Log<string>($"Started [{nameof(XmlCMSMobileParser)}]");

			XmlCMSMobileResponse response = new XmlCMSMobileResponse();
			List<string> errorMessages = new List<string>();

			try
			{
				string directory = $"{Directory.GetCurrentDirectory()}/CMS/Mobile";

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
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(Games), XmlAttributeOverrides);

					Games games = xmlSerializer.Deserialize(stream) as Games;

					if (games == null)
						errorMessages.Add("Xml could not be deserialized");

					response.Result = new XmlCMSMobileResult
					{
						Root = new XmlCMSMobileRoot
						{
							Games = games
						}
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

				Logger.Log<string>($"Games count: [{response.Result.Root.Games.Game.Count}]");

				Logger.Log<string>($"Ended [{nameof(XmlCMSMobileParser)}]");
			}

			return response;
		}
	}
}