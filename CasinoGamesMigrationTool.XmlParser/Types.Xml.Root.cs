namespace CasinoGamesMigrationTool.XmlParser
{
	public abstract class XmlRoot
	{
		public XmlGames Games { get; set; }
		public XmlGameLanguages GameLanguages { get; set; }
		public XmlJackpotGames JackpotGames { get; set; }
	}
}