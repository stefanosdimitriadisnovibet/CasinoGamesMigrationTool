using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.Microgaming
{
	public class XmlNovibetMobileMicrogamingResponse : Response
	{
		new public XmlNovibetMobileMicrogamingResult Result { get; set; }
	}

	public class XmlNovibetMobileMicrogamingResult : Result
	{
		new public XmlNovibetMobileMicrogamingRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetMobileMicrogamingGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "providerId")]
		public string ProviderId { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "culture")]
		public string Culture { get; set; }
		[XmlAttribute(AttributeName = "mobile")]
		public string Mobile { get; set; }
		[XmlAttribute(AttributeName = "source")]
		public string Source { get; set; }
		[XmlAttribute(AttributeName = "helpurlpattern")]
		public string Helpurlpattern { get; set; }
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNovibetMobileMicrogamingGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetMobileMicrogamingGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetMobileMicrogamingGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetMobileMicrogamingGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetMobileMicrogamingGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGame")]
	public class XmlNovibetMobileMicrogamingJackpotGame : XmlJackpotGame
	{
		[XmlAttribute(AttributeName = "moduleId")]
		public string ModuleId { get; set; }
		[XmlAttribute(AttributeName = "sysname")]
		public string Sysname { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGames")]
	public class XmlNovibetMobileMicrogamingJackpotGames : XmlJackpotGames
	{
		[XmlElement(ElementName = "JackpotGame")]
		new public List<XmlNovibetMobileMicrogamingJackpotGame> JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetMobileMicrogamingRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetMobileMicrogamingGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetMobileMicrogamingGameLanguages GameLanguages { get; set; }
		[XmlElement(ElementName = "JackpotGames")]
		new public XmlNovibetMobileMicrogamingJackpotGames JackpotGames { get; set; }
	}
}