﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.ScientificGames
{
	public class XmlNovibetMobileScientificGamesResponse : Response
	{
		new public XmlNovibetMobileScientificGamesResult Result { get; set; }
	}

	public class XmlNovibetMobileScientificGamesResult : Result
	{
		new public XmlNovibetMobileScientificGamesRoot Root { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class XmlNovibetMobileScientificGamesGame : XmlGame
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
	public class XmlNovibetMobileScientificGamesGames : XmlGames
	{
		[XmlElement(ElementName = "Game")]
		new public List<XmlNovibetMobileScientificGamesGame> Games { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguage")]
	public class XmlNovibetMobileScientificGamesGameLanguage : XmlGameLanguage
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "path")]
		public string Path { get; set; }
		[XmlAttribute(AttributeName = "helpLang")]
		public string HelpLang { get; set; }
	}

	[XmlRoot(ElementName = "GameLanguages")]
	public class XmlNovibetMobileScientificGamesGameLanguages : XmlGameLanguages
	{
		[XmlElement(ElementName = "GameLanguage")]
		new public List<XmlNovibetMobileScientificGamesGameLanguage> GameLanguages { get; set; }
	}

	[XmlRoot(ElementName = "Root")]
	public class XmlNovibetMobileScientificGamesRoot : XmlRoot
	{
		[XmlElement(ElementName = "Games")]
		new public XmlNovibetMobileScientificGamesGames Games { get; set; }
		[XmlElement(ElementName = "GameLanguages")]
		new public XmlNovibetMobileScientificGamesGameLanguages GameLanguages { get; set; }
	}
}