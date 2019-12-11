using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Evolution
{
	public class XmlNovibetDesktopEvolutionResponse : Response
	{
		new public XmlNovibetDesktopEvolutionResult Result { get; set; }
	}

	public class XmlNovibetDesktopEvolutionResult : Result
	{
		new public XmlNovibetDesktopEvolutionRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetDesktopEvolutionGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "alias")]
		public string Alias { get; set; }
		[XmlAttribute(AttributeName = "live")]
		public string Live { get; set; }
		[XmlAttribute(AttributeName = "norealitycheck")]
		public string Norealitycheck { get; set; }
		[XmlAttribute(AttributeName = "system")]
		public string System { get; set; }
		[XmlAttribute(AttributeName = "culture")]
		public string Culture { get; set; }
		[XmlAttribute(AttributeName = "source")]
		public string Source { get; set; }
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
		[XmlAttribute(AttributeName = "noDemoPlayAllowed")]
		public string NoDemoPlayAllowed { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNovibetDesktopEvolutionGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetDesktopEvolutionGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetDesktopEvolutionGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetDesktopEvolutionGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetDesktopEvolutionGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetDesktopEvolutionRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetDesktopEvolutionGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetDesktopEvolutionGameLanguages GameLanguages { get; set; }
	}
}