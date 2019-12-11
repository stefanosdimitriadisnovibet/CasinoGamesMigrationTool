using CasinoGamesMigrationTool.Domain;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser
{
	public class XmlParser
	{
		protected static readonly ILogger Logger;

		protected static readonly XmlAttributes XmlAttributes;

		protected static readonly XmlAttributeOverrides XmlAttributeOverrides;

		static XmlParser()
		{
			//Logger = new ConsoleLogger();
			Logger = new FileLogger();

			XmlAttributes = new XmlAttributes
			{
				XmlIgnore = true
			};

			XmlAttributeOverrides = new XmlAttributeOverrides();

			XmlAttributeOverrides.Add(typeof(XmlRoot), "Games", XmlAttributes);
			XmlAttributeOverrides.Add(typeof(XmlRoot), "GameLanguages", XmlAttributes);
			XmlAttributeOverrides.Add(typeof(XmlRoot), "JackpotGames", XmlAttributes);

			XmlAttributeOverrides.Add(typeof(XmlGames), "Games", XmlAttributes);

			XmlAttributeOverrides.Add(typeof(XmlGameLanguages), "GameLanguages", XmlAttributes);

			XmlAttributeOverrides.Add(typeof(XmlJackpotGames), "JackpotGames", XmlAttributes);
		}
	}
}