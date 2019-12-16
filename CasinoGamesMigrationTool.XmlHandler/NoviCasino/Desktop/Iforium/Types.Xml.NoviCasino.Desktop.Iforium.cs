namespace CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.Iforium
{
	public class XmlNoviCasinoDesktopIforiumGame
	{
		public string Sysname { get; set; }
		public string Caption { get; set; }
		public int Id { get; set; }
		public bool IsLive { get; set; }
		public string[] Cultures { get; set; }
		public int ProviderId { get; set; }
		public bool IsMobile { get; set; }
		public string TypeFilter { get; set; }
		public string[] CountriesBanned { get; set; }
	}

	public class XmlNoviCasinoDesktopIforiumGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}