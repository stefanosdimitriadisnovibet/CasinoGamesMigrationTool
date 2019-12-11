using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.KingSolomons.Mobile.PlayTech
{
	public class XmlKingSolomonsMobilePlayTechResponse : Response
	{
		new public XmlKingSolomonsMobilePlayTechResult Result { get; set; }
	}

	public class XmlKingSolomonsMobilePlayTechResult : Result
	{
		new public XmlKingSolomonsMobilePlayTechRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlKingSolomonsMobilePlayTechGame : XmlGame
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
	public class XmlKingSolomonsMobilePlayTechGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlKingSolomonsMobilePlayTechGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlKingSolomonsMobilePlayTechGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlKingSolomonsMobilePlayTechGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlKingSolomonsMobilePlayTechGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGame")]
	public class XmlKingSolomonsMobilePlayTechJackpotGame : XmlJackpotGame
	{
		[XmlAttribute(AttributeName = "sysname")]
		public string Sysname { get; set; }
		[XmlAttribute(AttributeName = "gameGroup")]
		public string GameGroup { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGames")]
	public class XmlKingSolomonsMobilePlayTechJackpotGames : XmlJackpotGames
	{
		[XmlElement(ElementName = "JackpotGame")]
		new public List<XmlKingSolomonsMobilePlayTechJackpotGame> JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlKingSolomonsMobilePlayTechRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlKingSolomonsMobilePlayTechGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlKingSolomonsMobilePlayTechGameLanguages GameLanguages { get; set; }
		[XmlElement(ElementName = "JackpotGames")]
		new public XmlKingSolomonsMobilePlayTechJackpotGames JackpotGames { get; set; }
	}
}