using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.KingSolomons.Desktop.PlayTech
{
	public class XmlKingSolomonsDesktopPlayTechResponse : Response
	{
		new public XmlKingSolomonsDesktopPlayTechResult Result { get; set; }
	}

	public class XmlKingSolomonsDesktopPlayTechResult : Result
	{
		new public XmlKingSolomonsDesktopPlayTechRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlKingSolomonsDesktopPlayTechRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlKingSolomonsDesktopPlayTechGames Games { get; set; }

		[XmlElement(ElementName = "GameLanguages")]
		new public XmlKingSolomonsDesktopPlayTechGameLanguages GameLanguages { get; set; }

		[XmlElement(ElementName = "JackpotGames")]
		new public XmlKingSolomonsDesktopPlayTechJackpotGames JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlKingSolomonsDesktopPlayTechGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlKingSolomonsDesktopPlayTechGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlKingSolomonsDesktopPlayTechGame : XmlGame
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

		[XmlAttribute(AttributeName = "Desktop")]
		public string Desktop { get; set; }

		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }

		[XmlAttribute(AttributeName = "gameTypeFilter")]
		public string GameTypeFilter { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlKingSolomonsDesktopPlayTechGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlKingSolomonsDesktopPlayTechGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlKingSolomonsDesktopPlayTechGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }

		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGames")]
	public class XmlKingSolomonsDesktopPlayTechJackpotGames : XmlJackpotGames
	{
		[XmlElement(ElementName = "JackpotGame")]
		new public List<XmlKingSolomonsDesktopPlayTechJackpotGame> JackpotGames { get; set; }
	}

	[XmlRoot(ElementName = "JackpotGame")]
	public class XmlKingSolomonsDesktopPlayTechJackpotGame : XmlJackpotGame
	{
		[XmlAttribute(AttributeName = "sysname")]
		public string Sysname { get; set; }

		[XmlAttribute(AttributeName = "gameGroup")]
		public string GameGroup { get; set; }
	}
}