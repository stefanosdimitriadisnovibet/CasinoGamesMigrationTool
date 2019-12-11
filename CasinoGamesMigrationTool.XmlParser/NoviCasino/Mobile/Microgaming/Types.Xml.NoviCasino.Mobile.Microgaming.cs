using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.Microgaming
{
	public class XmlNoviCasinoMobileMicrogamingResponse : Response
	{
		new public XmlNoviCasinoMobileMicrogamingResult Result { get; set; }
	}

	public class XmlNoviCasinoMobileMicrogamingResult : Result
	{
		new public XmlNoviCasinoMobileMicrogamingRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNoviCasinoMobileMicrogamingGame : XmlGame
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
	public class XmlNoviCasinoMobileMicrogamingGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNoviCasinoMobileMicrogamingGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNoviCasinoMobileMicrogamingGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNoviCasinoMobileMicrogamingGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNoviCasinoMobileMicrogamingGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGame")]
	public class XmlNoviCasinoMobileMicrogamingJackpotGame : XmlJackpotGame
	{
		[XmlAttribute(AttributeName = "moduleId")]
		public string ModuleId { get; set; }
		[XmlAttribute(AttributeName = "sysname")]
		public string Sysname { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGames")]
	public class XmlNoviCasinoMobileMicrogamingJackpotGames : XmlJackpotGames
	{
		[XmlElement(ElementName = "JackpotGame")]
		new public List<XmlNoviCasinoMobileMicrogamingJackpotGame> JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNoviCasinoMobileMicrogamingRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNoviCasinoMobileMicrogamingGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNoviCasinoMobileMicrogamingGameLanguages GameLanguages { get; set; }
		[XmlElement(ElementName = "JackpotGames")]
		new public XmlNoviCasinoMobileMicrogamingJackpotGames JackpotGames { get; set; }
	}
}