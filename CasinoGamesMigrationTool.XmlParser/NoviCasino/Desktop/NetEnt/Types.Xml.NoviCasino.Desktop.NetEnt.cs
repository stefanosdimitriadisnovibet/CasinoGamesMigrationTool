using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.NetEnt
{
	public class XmlNoviCasinoDesktopNetEntResponse : Response
	{
		new public XmlNoviCasinoDesktopNetEntResult Result { get; set; }
	}

	public class XmlNoviCasinoDesktopNetEntResult : Result
	{
		new public XmlNoviCasinoDesktopNetEntRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNoviCasinoDesktopNetEntGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "providerId")]
		public string ProviderId { get; set; }
		[XmlAttribute(AttributeName = "theme")]
		public string Theme { get; set; }
		[XmlAttribute(AttributeName = "live")]
		public string Live { get; set; }
		[XmlAttribute(AttributeName = "culture")]
		public string Culture { get; set; }
		[XmlAttribute(AttributeName = "source")]
		public string Source { get; set; }
		[XmlAttribute(AttributeName = "mobile")]
		public string Mobile { get; set; }
		[XmlAttribute(AttributeName = "gameTypeFilter")]
		public string GameTypeFilter { get; set; }
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
		[XmlAttribute(AttributeName = "tableId")]
		public string TableId { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNoviCasinoDesktopNetEntGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNoviCasinoDesktopNetEntGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGame")]
	public class XmlNoviCasinoDesktopNetEntJackpotGame : XmlJackpotGame
	{
		[XmlAttribute(AttributeName = "jackpotName")]
		public string JackpotName { get; set; }
		[XmlAttribute(AttributeName = "sysname")]
		public string Sysname { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGames")]
	public class XmlNoviCasinoDesktopNetEntJackpotGames : XmlJackpotGames
	{
		[XmlElement(ElementName = "JackpotGame")]
		new public List<XmlNoviCasinoDesktopNetEntJackpotGame> JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNoviCasinoDesktopNetEntGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNoviCasinoDesktopNetEntGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNoviCasinoDesktopNetEntGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNoviCasinoDesktopNetEntRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNoviCasinoDesktopNetEntGames Games { get; set; }
		[XmlElement(ElementName = "JackpotGames")]
		new public XmlNoviCasinoDesktopNetEntJackpotGames JackpotGames { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNoviCasinoDesktopNetEntGameLanguages GameLanguages { get; set; }
	}
}