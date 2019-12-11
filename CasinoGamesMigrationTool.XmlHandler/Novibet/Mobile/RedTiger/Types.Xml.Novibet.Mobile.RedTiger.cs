namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.RedTiger
{
	public class XmlNovibetMobileRedTigerGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public bool IsLive { get; set; }
		public string[] Cultures { get; set; }
		public string ProviderSysname { get; set; }
		public bool IsMobile { get; set; }
		public string[] CountriesBanned { get; set; }
		public bool NoDemoPlayAllowed { get; set; }
	}

	public class XmlNovibetMobileRedTigerGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}