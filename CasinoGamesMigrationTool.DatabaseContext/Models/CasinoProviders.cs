using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext.Models
{
	public partial class CasinoProviders
	{
		public CasinoProviders()
		{
			UserCasinoGames = new HashSet<UserCasinoGames>();
		}

		public int Id { get; set; }
		public string Sysname { get; set; }
		public int ProviderId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<UserCasinoGames> UserCasinoGames { get; set; }
	}
}