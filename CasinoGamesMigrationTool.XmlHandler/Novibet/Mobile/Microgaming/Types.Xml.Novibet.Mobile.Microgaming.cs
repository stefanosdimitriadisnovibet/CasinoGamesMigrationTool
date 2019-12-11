namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Microgaming
{
	public class XmlNovibetMobileMicrogamingGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public string Type { get; set; }
		public string[] Cultures { get; set; }
		public string Source { get; set; }
		public string[] CountriesBanned { get; set; }
		public string HelpUrlPattern { get; set; }
		public bool IsMobile { get; set; }
	}

	public class XmlNovibetMobileMicrogamingJackpotGame
	{
		public string Sysname { get; set; }
		public int ModuleId { get; set; }
	}

	public class XmlNovibetMobileMicrogamingGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}