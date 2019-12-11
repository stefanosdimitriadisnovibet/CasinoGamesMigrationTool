using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Microgaming
{
	public class XmlNovibetDesktopMicrogamingResponse : Response
	{
		new public XmlNovibetDesktopMicrogamingResult Result { get; set; }
	}

	public class XmlNovibetDesktopMicrogamingResult : Result
	{
		new public XmlNovibetDesktopMicrogamingRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetDesktopMicrogamingGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "live")]
		public string Live { get; set; }
		[XmlAttribute(AttributeName = "providerId")]
		public string ProviderId { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "culture")]
		public string Culture { get; set; }
		[XmlAttribute(AttributeName = "source")]
		public string Source { get; set; }
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
		[XmlAttribute(AttributeName = "helpurlpattern")]
		public string Helpurlpattern { get; set; }
		[XmlAttribute(AttributeName = "Desktop")]
		public string Desktop { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNovibetDesktopMicrogamingGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetDesktopMicrogamingGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetDesktopMicrogamingGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetDesktopMicrogamingGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetDesktopMicrogamingGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGame")]
	public class XmlNovibetDesktopMicrogamingJackpotGame : XmlJackpotGame
	{
		[XmlAttribute(AttributeName = "moduleId")]
		public string ModuleId { get; set; }
		[XmlAttribute(AttributeName = "sysname")]
		public string Sysname { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGames")]
	public class XmlNovibetDesktopMicrogamingJackpotGames : XmlJackpotGames
	{
		[XmlElement(ElementName = "JackpotGame")]
		new public List<XmlNovibetDesktopMicrogamingJackpotGame> JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetDesktopMicrogamingRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetDesktopMicrogamingGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetDesktopMicrogamingGameLanguages GameLanguages { get; set; }
		[XmlElement(ElementName = "JackpotGames")]
		new public XmlNovibetDesktopMicrogamingJackpotGames JackpotGames { get; set; }
	}
}