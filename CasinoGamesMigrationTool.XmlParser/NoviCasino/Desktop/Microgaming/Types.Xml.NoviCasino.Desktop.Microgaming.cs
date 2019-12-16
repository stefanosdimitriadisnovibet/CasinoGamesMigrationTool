using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.Microgaming
{
	public class XmlNoviCasinoDesktopMicrogamingResponse : Response
	{
		new public XmlNoviCasinoDesktopMicrogamingResult Result { get; set; }
	}

	public class XmlNoviCasinoDesktopMicrogamingResult : Result
	{
		new public XmlNoviCasinoDesktopMicrogamingRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNoviCasinoDesktopMicrogamingGame : XmlGame
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
		[XmlAttribute(AttributeName = "mobile")]
		public string Mobile { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNoviCasinoDesktopMicrogamingGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNoviCasinoDesktopMicrogamingGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNoviCasinoDesktopMicrogamingGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNoviCasinoDesktopMicrogamingGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNoviCasinoDesktopMicrogamingGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGame")]
	public class XmlNoviCasinoDesktopMicrogamingJackpotGame : XmlJackpotGame
	{
		[XmlAttribute(AttributeName = "moduleId")]
		public string ModuleId { get; set; }
		[XmlAttribute(AttributeName = "sysname")]
		public string Sysname { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGames")]
	public class XmlNoviCasinoDesktopMicrogamingJackpotGames : XmlJackpotGames
	{
		[XmlElement(ElementName = "JackpotGame")]
		new public List<XmlNoviCasinoDesktopMicrogamingJackpotGame> JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNoviCasinoDesktopMicrogamingRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNoviCasinoDesktopMicrogamingGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNoviCasinoDesktopMicrogamingGameLanguages GameLanguages { get; set; }
		[XmlElement(ElementName = "JackpotGames")]
		new public XmlNoviCasinoDesktopMicrogamingJackpotGames JackpotGames { get; set; }
	}
}