using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Iforium
{
	public class XmlNovibetDesktopIforiumResponse : Response
	{
		new public XmlNovibetDesktopIforiumResult Result { get; set; }
	}

	public class XmlNovibetDesktopIforiumResult : Result
	{
		new public XmlNovibetDesktopIforiumRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetDesktopIforiumGame : XmlGame
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
	public class XmlNovibetDesktopIforiumGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetDesktopIforiumGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetDesktopIforiumGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetDesktopIforiumGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetDesktopIforiumGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetDesktopIforiumRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetDesktopIforiumGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetDesktopIforiumGameLanguages GameLanguages { get; set; }
	}
}