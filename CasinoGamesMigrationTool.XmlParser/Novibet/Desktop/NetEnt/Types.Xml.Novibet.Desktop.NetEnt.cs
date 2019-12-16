using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.NetEnt
{
	public class XmlNovibetDesktopNetEntResponse : Response
	{
		new public XmlNovibetDesktopNetEntResult Result { get; set; }
	}

	public class XmlNovibetDesktopNetEntResult : Result
	{
		new public XmlNovibetDesktopNetEntRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetDesktopNetEntGame : XmlGame
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
	public class XmlNovibetDesktopNetEntGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetDesktopNetEntGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGame")]
	public class XmlNovibetDesktopNetEntJackpotGame : XmlJackpotGame
	{
		[XmlAttribute(AttributeName = "jackpotName")]
		public string JackpotName { get; set; }
		[XmlAttribute(AttributeName = "sysname")]
		public string Sysname { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGames")]
	public class XmlNovibetDesktopNetEntJackpotGames : XmlJackpotGames
	{
		[XmlElement(ElementName = "JackpotGame")]
		new public List<XmlNovibetDesktopNetEntJackpotGame> JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetDesktopNetEntGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetDesktopNetEntGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetDesktopNetEntGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetDesktopNetEntRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetDesktopNetEntGames Games { get; set; }
		[XmlElement(ElementName = "JackpotGames")]
		new public XmlNovibetDesktopNetEntJackpotGames JackpotGames { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetDesktopNetEntGameLanguages GameLanguages { get; set; }
	}
}