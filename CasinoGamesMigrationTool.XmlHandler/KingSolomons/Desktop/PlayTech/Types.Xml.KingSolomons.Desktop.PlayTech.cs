namespace CasinoGamesMigrationTool.XmlHandler.KingSolomons.Desktop.PlayTech
{
	public class XmlKingSolomonsDesktopPlayTechGame
	{
		public string[] CountriesBanned { get; set; }
		public string[] Cultures { get; set; }
		public string TypeFilter { get; set; }
		public string Sysname { get; set; }
		public bool IsLive { get; set; }
		public bool IsDesktop { get; set; }
		public int ProviderId { get; set; }
		public string Source { get; set; }
	}

	public class XmlKingSolomonsDesktopPlayTechJackpotGame
	{
		public string Sysname { get; set; }
		public string GameGroup { get; set; }
	}

	public class XmlKingSolomonsDesktopPlayTechGameLanguages
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}