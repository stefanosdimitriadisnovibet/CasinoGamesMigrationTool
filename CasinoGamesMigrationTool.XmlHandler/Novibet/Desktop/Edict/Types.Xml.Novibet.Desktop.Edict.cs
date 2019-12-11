namespace CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Edict
{
	public class XmlNovibetDesktopEdictGame
	{
		public string[] CountriesBanned { get; set; }
		public string[] Cultures { get; set; }
		public string Sysname { get; set; }
		public bool IsLive { get; set; }
		public bool IsDesktop { get; set; }
		public int ProviderId { get; set; }
		public string Source { get; set; }
		public bool NoDemoPlayAllowed { get; set; }
	}

	public class XmlNovibetDesktopEdictGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}