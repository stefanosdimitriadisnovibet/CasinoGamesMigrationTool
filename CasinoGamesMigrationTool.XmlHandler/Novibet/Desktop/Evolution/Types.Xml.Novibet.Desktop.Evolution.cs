namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Evolution
{
	public class XmlNovibetDesktopEvolutionGame
	{
		public string Sysname { get; set; }
		public string Alias { get; set; }
		public bool IsLive { get; set; }
		public bool NoRealityCheck { get; set; }
		public int System { get; set; }
		public string[] Cultures { get; set; }
		public string Source { get; set; }
		public string[] CountriesBanned { get; set; }
		public bool NoDemoPlayAllowed { get; set; }
	}

	public class XmlNovibetDesktopEvolutionGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}