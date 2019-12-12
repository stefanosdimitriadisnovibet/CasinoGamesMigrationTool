using System.Collections.Generic;
using System.Xml.Serialization;

namespace CasinoGamesMigrationTool.XmlParser.CMS.Mobile
{
	public class XmlCMSMobileResponse : Response
	{
		new public XmlCMSMobileResult Result { get; set; }
	}

	public class XmlCMSMobileResult : Result
	{
		new public XmlCMSMobileRoot Root { get; set; }
	}

	public class XmlCMSMobileRoot : XmlRoot
	{
		new public Games Games { get; set; }
	}

	[XmlRoot(ElementName = "Game")]
	public class Game
	{
		[XmlElement(ElementName = "SysName")]
		public string SysName { get; set; }
		[XmlElement(ElementName = "NewGame")]
		public string NewGame { get; set; }
		[XmlElement(ElementName = "BannerUrl")]
		public string BannerUrl { get; set; }
		[XmlElement(ElementName = "Caption")]
		public string Caption { get; set; }
		[XmlElement(ElementName = "PopularGame")]
		public string PopularGame { get; set; }
		[XmlElement(ElementName = "BannerLiveCasinoUrl")]
		public string BannerLiveCasinoUrl { get; set; }
		[XmlElement(ElementName = "IsVisible")]
		public string IsVisible { get; set; }
		[XmlElement(ElementName = "JackpotGame")]
		public string JackpotGame { get; set; }
		[XmlElement(ElementName = "CasinoSubProvider")]
		public string CasinoSubProvider { get; set; }
		[XmlElement(ElementName = "CasinoGameProvider")]
		public string CasinoGameProvider { get; set; }
	}

	[XmlRoot(ElementName = "Games")]
	public class Games
	{
		[XmlElement(ElementName = "Game")]
		public List<Game> Game { get; set; }
	}
}