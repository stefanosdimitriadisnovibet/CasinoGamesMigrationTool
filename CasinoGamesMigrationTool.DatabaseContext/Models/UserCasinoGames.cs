using System;

namespace CasinoGamesMigrationTool.DatabaseContext.Models
{
	public partial class UserCasinoGames
	{
		public int Id { get; set; }
		public int GameId { get; set; }
		public string Sysname { get; set; }
		public int Provider { get; set; }
		public decimal ProviderFee { get; set; }
		public decimal JackpotContribution { get; set; }
		public int Type { get; set; }
		public int? Credits { get; set; }
		public string Description { get; set; }
		public bool IsLive { get; set; }
		public bool IsJackpot { get; set; }
		public string Caption { get; set; }
		public string CaptionEn { get; set; }
		public int Manufacturer { get; set; }
		public string Category { get; set; }
		public bool IsMobile { get; set; }
		public bool IsBonusExcluded { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Updated { get; set; }

		public virtual UserCasinoGamesCategories CategoryNavigation { get; set; }
		public virtual CasinoManufacturer ManufacturerNavigation { get; set; }
		public virtual CasinoProviders ProviderNavigation { get; set; }
		public virtual UserCasinoGameTypes TypeNavigation { get; set; }
	}
}