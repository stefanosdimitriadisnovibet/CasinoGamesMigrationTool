using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.ScientificGames
{
	public class XmlNovibetDesktopScientificGamesResponse : Response
	{
		new public XmlNovibetDesktopScientificGamesResult Result { get; set; }
	}

	public class XmlNovibetDesktopScientificGamesResult : Result
	{
		new public XmlNovibetDesktopScientificGamesRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetDesktopScientificGamesGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "providerId")]
		public string ProviderId { get; set; }
		[XmlAttribute(AttributeName = "live")]
		public string Live { get; set; }
		[XmlAttribute(AttributeName = "mobile")]
		public string Mobile { get; set; }
		[XmlAttribute(AttributeName = "culture")]
		public string Culture { get; set; }
		[XmlAttribute(AttributeName = "source")]
		public string Source { get; set; }
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNovibetDesktopScientificGamesGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetDesktopScientificGamesGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetDesktopScientificGamesGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetDesktopScientificGamesGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetDesktopScientificGamesGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetDesktopScientificGamesRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetDesktopScientificGamesGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetDesktopScientificGamesGameLanguages GameLanguages { get; set; }
	}
}