using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext.Models
{
	public partial class CasinoManufacturer
	{
		public CasinoManufacturer()
		{
			UserCasinoGames = new HashSet<UserCasinoGames>();
		}

		public int Id { get; set; }
		public string Sysname { get; set; }

		public virtual ICollection<UserCasinoGames> UserCasinoGames { get; set; }
	}
}