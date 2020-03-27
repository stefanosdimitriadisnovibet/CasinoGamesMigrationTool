using System.Text.Json.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.CMS.New
{
	public class Rootobject
	{
		public Class1[] Property1 { get; set; }
	}

	public class Class1
	{
		public Game[] Games { get; set; }
		public string Sysname { get; set; }
	}

	public class Game
	{
		public string Sysname { get; set; }
		public string Caption { get; set; }
		public string CasinoProvider { get; set; }
		public string CasinoSubProvider { get; set; }
		public bool IsNew { get; set; }
		public bool IsMobile { get; set; }
		public bool IsTimeRestricted { get; set; }
		public object AvailableFrom { get; set; }
		public object AvailableTo { get; set; }
		public bool DemoPlayNotSupported { get; set; }
		[JsonPropertyName("BannerUrl")]
		public string DefaultImage { get; set; }
		public string HeroImage { get; set; }
		[JsonPropertyName("LiveCasinoBanner")]
		public string LiveImage { get; set; }
		public int NodeId { get; set; }
	}
}