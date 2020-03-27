using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CasinoGamesMigrationTool.XmlParser.CMS.New
{
	public static class CMSDesktopParser
	{
		public static Rootobject ParseXml()
		{
			try
			{
				var directory = $"{Directory.GetCurrentDirectory()}/CMS/New";

				var directoryInfo = new DirectoryInfo(directory);

				if (directoryInfo == null)
					throw new Exception("Directory not found");

				var fileInfo = directoryInfo
					.GetFiles("Desktop.json")
					.FirstOrDefault();

				if (fileInfo == null)
					throw new Exception("Json not found");

				var json = File.ReadAllText(fileInfo.FullName);

				var rootobject = JsonSerializer.Deserialize<Rootobject>(json);

				if (rootobject == null)
					throw new Exception("json could not be deserialized");

				return rootobject;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}

	public static class CMSMobileParser
	{
		public static Rootobject ParseXml()
		{
			try
			{
				var directory = $"{Directory.GetCurrentDirectory()}/CMS/New";

				var directoryInfo = new DirectoryInfo(directory);

				if (directoryInfo == null)
					throw new Exception("Directory not found");

				var fileInfo = directoryInfo
					.GetFiles("Mobile.json")
					.FirstOrDefault();

				if (fileInfo == null)
					throw new Exception("Json not found");

				var json = File.ReadAllText(fileInfo.FullName);

				var rootobject = JsonSerializer.Deserialize<Rootobject>(json);

				if (rootobject == null)
					throw new Exception("json could not be deserialized");

				return rootobject;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}