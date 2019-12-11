using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.Evolution
{
	public class XmlNoviCasinoDesktopEvolutionResponse : Response
	{
		new public XmlNoviCasinoDesktopEvolutionResult Result { get; set; }
	}

	public class XmlNoviCasinoDesktopEvolutionResult : Result
	{
		new public XmlNoviCasinoDesktopEvolutionRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNoviCasinoDesktopEvolutionRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNoviCasinoDesktopEvolutionGames Games { get; set; }

		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNoviCasinoDesktopEvolutionGameLanguages GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNoviCasinoDesktopEvolutionGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNoviCasinoDesktopEvolutionGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNoviCasinoDesktopEvolutionGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "alias")]
		public string Alias { get; set; }

		[XmlAttribute(AttributeName = "live")]
		public string Live { get; set; }

		[XmlAttribute(AttributeName = "norealitycheck")]
		public string Norealitycheck { get; set; }

		[XmlAttribute(AttributeName = "system")]
		public string System { get; set; }

		[XmlAttribute(AttributeName = "culture")]
		public string Culture { get; set; }

		[XmlAttribute(AttributeName = "source")]
		public string Source { get; set; }

		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }

		[XmlAttribute(AttributeName = "noDemoPlayAllowed")]
		public string NoDemoPlayAllowed { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNoviCasinoDesktopEvolutionGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNoviCasinoDesktopEvolutionGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNoviCasinoDesktopEvolutionGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }

		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}
}