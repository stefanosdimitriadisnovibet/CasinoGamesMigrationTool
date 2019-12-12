using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext.Models
{
	public partial class UserCasinoGameTypes
	{
		public UserCasinoGameTypes()
		{
			UserCasinoGames = new HashSet<UserCasinoGames>();
		}

		public int Id { get; set; }
		public string Sysname { get; set; }
		public string Name { get; set; }
		public string Note { get; set; }

		public virtual ICollection<UserCasinoGames> UserCasinoGames { get; set; }
	}
}