using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.NetEnt
{
	public class XmlNoviCasinoMobileNetEntResponse : Response
	{
		new public XmlNoviCasinoMobileNetEntResult Result { get; set; }
	}

	public class XmlNoviCasinoMobileNetEntResult : Result
	{
		new public XmlNoviCasinoMobileNetEntRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNoviCasinoMobileNetEntGame : XmlGame
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
	public class XmlNoviCasinoMobileNetEntGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNoviCasinoMobileNetEntGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNoviCasinoMobileNetEntGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNoviCasinoMobileNetEntGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNoviCasinoMobileNetEntGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNoviCasinoMobileNetEntRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNoviCasinoMobileNetEntGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNoviCasinoMobileNetEntGameLanguages GameLanguages { get; set; }
	}
}