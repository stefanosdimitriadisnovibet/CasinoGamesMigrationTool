using CsvHelper.Configuration.Attributes;

namespace CasinoGamesMigrationTool.Console
{
	public class CsvUserCasinoGames
	{
		public int Id { get; set; }
		public int GameId { get; set; }
		public string GameSysname { get; set; }
		public int ProviderId { get; set; }
		public string Provider { get; set; }
		public int ManufId { get; set; }
		public string Manuf { get; set; }
		public int TypeId { get; set; }
		public string Type { get; set; }
		[Name("Alias")]
		public string Caption { get; set; }
		public string CaptionEN { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
		public int Credits { get; set; }
		[BooleanTrueValues("1")]
		[BooleanFalseValues("0")]
		public bool IsLive { get; set; }
		[BooleanTrueValues("1")]
		[BooleanFalseValues("0")]
		public bool IsMobile { get; set; }
		[BooleanTrueValues("1")]
		[BooleanFalseValues("0")]
		public bool IsJackpot { get; set; }
		[Name("JackpotContr.")]
		public decimal JackpotContr { get; set; }
		public decimal ProviderFee { get; set; }
		[BooleanTrueValues("1")]
		[BooleanFalseValues("0")]
		public bool IsBonusExcluded { get; set; }
	}
}