namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.NYX
{
	public class XmlNovibetDesktopNYXGame
	{
		public string Sysname { get; set; }
		public int Id { get; set; }
		public bool IsLive { get; set; }
		public string[] Cultures { get; set; }
		public string ProviderId { get; set; }
		public bool IsDesktop { get; set; }
		public string[] CountriesBanned { get; set; }
		public bool NoDemoPlayAllowed { get; set; }
	}

	public class XmlNovibetDesktopNYXGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}