namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.ScientificGames
{
	public class XmlNovibetMobileScientificGamesGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public bool IsLive { get; set; }
		public bool IsMobile { get; set; }
		public string[] Cultures { get; set; }
		public string Source { get; set; }
		public string[] CountriesBanned { get; set; }
	}

	public class XmlNovibetMobileScientificGamesGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}