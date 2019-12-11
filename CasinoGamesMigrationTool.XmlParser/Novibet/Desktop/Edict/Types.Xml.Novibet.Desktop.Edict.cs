using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Edict
{
	public class XmlNovibetDesktopEdictResponse : Response
	{
		new public XmlNovibetDesktopEdictResult Result { get; set; }
	}

	public class XmlNovibetDesktopEdictResult : Result
	{
		new public XmlNovibetDesktopEdictRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetDesktopEdictGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
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
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
		[XmlAttribute(AttributeName = "noDemoPlayAllowed")]
		public string NoDemoPlayAllowed { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNovibetDesktopEdictGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetDesktopEdictGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetDesktopEdictGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetDesktopEdictGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetDesktopEdictGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetDesktopEdictRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetDesktopEdictGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetDesktopEdictGameLanguages GameLanguages { get; set; }
	}
}