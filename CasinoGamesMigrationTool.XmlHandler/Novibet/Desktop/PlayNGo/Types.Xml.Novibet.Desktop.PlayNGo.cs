namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.PlayNGo
{
	public class XmlNovibetDesktopPlayNGoGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public bool IsLive { get; set; }
		public string[] Cultures { get; set; }
		public string ProviderSysname { get; set; }
		public bool IsDesktop { get; set; }
		public string[] CountriesBanned { get; set; }
	}

	public class XmlNovibetDesktopPlayNGoGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}