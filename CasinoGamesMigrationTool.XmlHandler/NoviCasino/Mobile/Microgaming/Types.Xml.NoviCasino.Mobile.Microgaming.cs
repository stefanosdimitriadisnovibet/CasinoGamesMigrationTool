namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.Microgaming
{
	public class XmlNoviCasinoMobileMicrogamingGame
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

	public class XmlNoviCasinoMobileMicrogamingJackpotGame
	{
		public string Sysname { get; set; }
		public int ModuleId { get; set; }
	}

	public class XmlNoviCasinoMobileMicrogamingGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}