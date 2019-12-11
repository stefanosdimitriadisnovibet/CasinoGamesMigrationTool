using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.RedTiger
{
	public class XmlNovibetMobileRedTigerResponse : Response
	{
		new public XmlNovibetMobileRedTigerResult Result { get; set; }
	}

	public class XmlNovibetMobileRedTigerResult : Result
	{
		new public XmlNovibetMobileRedTigerRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetMobileRedTigerGame : XmlGame
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
		[XmlAttribute(AttributeName = "noDemoPlayAllowed")]
		public string NoDemoPlayAllowed { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNovibetMobileRedTigerGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetMobileRedTigerGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetMobileRedTigerGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetMobileRedTigerGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetMobileRedTigerGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetMobileRedTigerRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetMobileRedTigerGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetMobileRedTigerGameLanguages GameLanguages { get; set; }
	}
}