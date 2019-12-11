using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.ScientificGames
{
	public class XmlNoviCasinoMobileScientificGamesResponse : Response
	{
		new public XmlNoviCasinoMobileScientificGamesResult Result { get; set; }
	}

	public class XmlNoviCasinoMobileScientificGamesResult : Result
	{
		new public XmlNoviCasinoMobileScientificGamesRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNoviCasinoMobileScientificGamesGame : XmlGame
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "providerId")]
		public string ProviderId { get; set; }
		[XmlAttribute(AttributeName = "live")]
		public string Live { get; set; }
		[XmlAttribute(AttributeName = "mobile")]
		public string Mobile { get; set; }
		[XmlAttribute(AttributeName = "culture")]
		public string Culture { get; set; }
		[XmlAttribute(AttributeName = "source")]
		public string Source { get; set; }
		[XmlAttribute(AttributeName = "countriesBanned")]
		public string CountriesBanned { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class XmlNoviCasinoMobileScientificGamesGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNoviCasinoMobileScientificGamesGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNoviCasinoMobileScientificGamesGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNoviCasinoMobileScientificGamesGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNoviCasinoMobileScientificGamesGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNoviCasinoMobileScientificGamesRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNoviCasinoMobileScientificGamesGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNoviCasinoMobileScientificGamesGameLanguages GameLanguages { get; set; }
	}
}