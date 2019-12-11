using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.PlayNGo
{
	public class XmlNovibetMobilePlayNGoResponse : Response
	{
		new public XmlNovibetMobilePlayNGoResult Result { get; set; }
	}

	public class XmlNovibetMobilePlayNGoResult : Result
	{
		new public XmlNovibetMobilePlayNGoRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetMobilePlayNGoGame : XmlGame
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
	public class XmlNovibetMobilePlayNGoGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetMobilePlayNGoGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetMobilePlayNGoGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetMobilePlayNGoGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetMobilePlayNGoGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetMobilePlayNGoRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetMobilePlayNGoGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetMobilePlayNGoGameLanguages GameLanguages { get; set; }
	}
}