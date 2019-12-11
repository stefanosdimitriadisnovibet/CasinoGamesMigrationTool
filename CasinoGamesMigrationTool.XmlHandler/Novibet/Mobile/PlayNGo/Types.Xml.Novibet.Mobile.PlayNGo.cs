namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.PlayNGo
{
	public class XmlNovibetMobilePlayNGoGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public bool IsLive { get; set; }
		public string[] Cultures { get; set; }
		public string ProviderSysname { get; set; }
		public bool IsMobile { get; set; }
		public string[] CountriesBanned { get; set; }
	}

	public class XmlNovibetMobilePlayNGoGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}