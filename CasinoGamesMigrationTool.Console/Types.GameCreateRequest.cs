namespace CasinoGamesMigrationTool.Console
{
	public class GameLegacyCreateRequest
	{
		public int SystemId { get; set; }
		public string Category { get; set; }
		public int Credits { get; set; }
		public bool DesktopCompatible { get; set; }
		public bool IsJackpot { get; set; }
		public bool IsLive { get; set; }
		public decimal JackpotContribution { get; set; }
		public string Manufacturer { get; set; }
		public bool MobileCompatible { get; set; }
		public string Name { get; set; }
		public decimal ProviderFee { get; set; }
		public int ProviderId { get; set; }
		public string ExternalSysname { get; set; }
	}
}