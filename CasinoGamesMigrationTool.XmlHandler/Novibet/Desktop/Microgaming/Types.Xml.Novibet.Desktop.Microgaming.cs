namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Microgaming
{
	public class XmlNovibetDesktopMicrogamingGame
	{
		public string Sysname { get; set; }
		public bool IsLive { get; set; }
		public int Id { get; set; }
		public string Type { get; set; }
		public string[] Cultures { get; set; }
		public string Source { get; set; }
		public string[] CountriesBanned { get; set; }
		public string HelpUrlPattern { get; set; }
		public bool IsDesktop { get; set; }
	}

	public class XmlNovibetDesktopMicrogamingJackpotGame
	{
		public string Sysname { get; set; }
		public int ModuleId { get; set; }
	}

	public class XmlNovibetDesktopMicrogamingGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}