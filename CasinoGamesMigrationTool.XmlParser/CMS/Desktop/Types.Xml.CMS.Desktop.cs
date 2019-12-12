using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.CMS.Desktop
{
	public class XmlCMSDesktopResponse : Response
	{
		new public XmlCMSDesktopResult Result { get; set; }
	}

	public class XmlCMSDesktopResult : Result
	{
		new public XmlCMSDesktopRoot Root { get; set; }
	}

	public class XmlCMSDesktopRoot : XmlRoot
	{
		new public Games Games { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class Game
	{
		[XmlElement(ElementName = "SysName")]
		public string SysName { get; set; }
		[XmlElement(ElementName = "MobileGame")]
		public string MobileGame { get; set; }
		[XmlElement(ElementName = "TimeResrtictedGame")]
		public string TimeResrtictedGame { get; set; }
		[XmlElement(ElementName = "NewGame")]
		public string NewGame { get; set; }
		[XmlElement(ElementName = "BannerUrl")]
		public string BannerUrl { get; set; }
		[XmlElement(ElementName = "NoDemoPlayAllowed")]
		public string NoDemoPlayAllowed { get; set; }
		[XmlElement(ElementName = "Caption")]
		public string Caption { get; set; }
		[XmlElement(ElementName = "PopularGame")]
		public string PopularGame { get; set; }
		[XmlElement(ElementName = "BannerLiveCasinoUrl")]
		public string BannerLiveCasinoUrl { get; set; }
		[XmlElement(ElementName = "IsVisible")]
		public string IsVisible { get; set; }
		[XmlElement(ElementName = "LiveCasinoGame")]
		public string LiveCasinoGame { get; set; }
		[XmlElement(ElementName = "JackpotGame")]
		public string JackpotGame { get; set; }
		[XmlElement(ElementName = "CasinoSubProvider")]
		public string CasinoSubProvider { get; set; }
		[XmlElement(ElementName = "CasinoGameProvider")]
		public string CasinoGameProvider { get; set; }
		[XmlElement(ElementName = "AvailableFrom")]
		public string AvailableFrom { get; set; }
		[XmlElement(ElementName = "AvailableTo")]
		public string AvailableTo { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class Games
	{
		[XmlElement(ElementName = "Game")]
		public List<Game> Game { get; set; }
	}
}