namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.NetEnt
{
	public class XmlNovibetDesktopNetEntGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public string Theme { get; set; }
		public bool IsLive { get; set; }
		public string[] Cultures { get; set; }
		public string ProviderSysname { get; set; }
		public bool IsDesktop { get; set; }
		public string TypeFilter { get; set; }
		public string[] CountriesBanned { get; set; }
		public int TableId { get; set; }
	}

	public class XmlNovibetDesktopNetEntJackpotGame
	{
		public string ProviderSysname { get; set; }
		public string Sysname { get; set; }
	}

	public class XmlNovibetDesktopNetEntGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}