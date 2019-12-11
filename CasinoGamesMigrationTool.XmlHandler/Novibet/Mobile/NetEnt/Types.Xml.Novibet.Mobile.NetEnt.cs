namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.NetEnt
{
	public class XmlNovibetMobileNetEntGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public string Theme { get; set; }
		public bool IsLive { get; set; }
		public string[] Cultures { get; set; }
		public string ProviderSysname { get; set; }
		public bool IsMobile { get; set; }
		public string TypeFilter { get; set; }
		public string[] CountriesBanned { get; set; }
		public int TableId { get; set; }
	}

	public class XmlNovibetMobileNetEntGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}