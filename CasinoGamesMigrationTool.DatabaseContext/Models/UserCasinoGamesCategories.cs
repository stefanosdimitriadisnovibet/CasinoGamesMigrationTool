using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext.Models
{
	public partial class UserCasinoGamesCategories
	{
		public UserCasinoGamesCategories()
		{
			UserCasinoGames = new HashSet<UserCasinoGames>();
		}

		public int Id { get; set; }
		public string Category { get; set; }

		public virtual ICollection<UserCasinoGames> UserCasinoGames { get; set; }
	}
}