﻿namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.ScientificGames
{
	public class XmlNovibetDesktopScientificGamesGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public bool IsLive { get; set; }
		public bool IsMobile { get; set; }
		public string[] Cultures { get; set; }
		public string Source { get; set; }
		public string[] CountriesBanned { get; set; }
	}

	public class XmlNovibetDesktopScientificGamesGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}