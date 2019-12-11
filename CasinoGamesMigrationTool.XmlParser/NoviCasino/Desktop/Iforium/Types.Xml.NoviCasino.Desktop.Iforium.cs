using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.Iforium
{
	public class XmlNoviCasinoDesktopIforiumResponse : Response
	{
		new public XmlNoviCasinoDesktopIforiumResult Result { get; set; }
	}

	public class XmlNoviCasinoDesktopIforiumResult : Result
	{
		new public XmlNoviCasinoDesktopIforiumRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNoviCasinoDesktopIforiumGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "caption")]
		public string Caption { get; set; }
		[XmlAttribute(AttributeName = "providerId")]
		public string ProviderId { get; set; }
		[XmlAttribute(AttributeName = "live")]
		public string Live { get; set; }
		[XmlAttribute(AttributeName = "culture")]
		public string Culture { get; set; }
		[XmlAttribute(AttributeName = "source")]
		public string Source { get; set; }
		[XmlAttribute(AttributeName = "Desktop")]
		public string Desktop { get; set; }
		[XmlAttribute(AttributeName = "gameTypeFilter")]
		public string GameTypeFilter { get; set; }
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNoviCasinoDesktopIforiumGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNoviCasinoDesktopIforiumGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNoviCasinoDesktopIforiumGameLanguage : XmlGameLanguages
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNoviCasinoDesktopIforiumGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNoviCasinoDesktopIforiumGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNoviCasinoDesktopIforiumRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNoviCasinoDesktopIforiumGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNoviCasinoDesktopIforiumGameLanguages GameLanguages { get; set; }
	}
}