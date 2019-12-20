namespace CasinoGamesMigrationTool.XmlHandler.KingSolomons.Mobile.PlayTech
{
	public class XmlKingSolomonsMobilePlayTechGame
	{
		public string[] CountriesBanned { get; set; }
		public string[] Cultures { get; set; }
		public string Sysname { get; set; }
		public bool IsLive { get; set; }
		public bool IsMobile { get; set; }
		public int Id { get; set; }
		public string Source { get; set; }
	}

	public class XmlKingSolomonsMobilePlayTechJackpotGame
	{
		public string Sysname { get; set; }
		public string GameGroup { get; set; }
	}

	public class XmlKingSolomonsMobilePlayTechGameLanguage
	{
		public string Type { get; set; }
		public string Path { get; set; }
		public string HelpLanguage { get; set; }
	}
}