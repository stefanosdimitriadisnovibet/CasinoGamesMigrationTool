using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.PlayNGo
{
	public class XmlNoviCasinoMobilePlayNGoResponse : Response
	{
		new public XmlNoviCasinoMobilePlayNGoResult Result { get; set; }
	}

	public class XmlNoviCasinoMobilePlayNGoResult : Result
	{
		new public XmlNoviCasinoMobilePlayNGoRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNoviCasinoMobilePlayNGoGame : XmlGame
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
		[XmlAttribute(AttributeName = "mobile")]
		public string Mobile { get; set; }
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNoviCasinoMobilePlayNGoGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNoviCasinoMobilePlayNGoGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNoviCasinoMobilePlayNGoGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNoviCasinoMobilePlayNGoGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNoviCasinoMobilePlayNGoGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNoviCasinoMobilePlayNGoRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNoviCasinoMobilePlayNGoGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNoviCasinoMobilePlayNGoGameLanguages GameLanguages { get; set; }
	}
}