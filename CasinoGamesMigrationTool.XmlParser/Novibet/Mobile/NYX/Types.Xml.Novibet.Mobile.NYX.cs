using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.NYX
{
	public class XmlNovibetMobileNYXResponse : Response
	{
		new public XmlNovibetMobileNYXResult Result { get; set; }
	}

	public class XmlNovibetMobileNYXResult : Result
	{
		new public XmlNovibetMobileNYXRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetMobileNYXGame : XmlGame
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
	public class XmlNovibetMobileNYXGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetMobileNYXGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetMobileNYXGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetMobileNYXGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetMobileNYXGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetMobileNYXRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetMobileNYXGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetMobileNYXGameLanguages GameLanguages { get; set; }
	}
}