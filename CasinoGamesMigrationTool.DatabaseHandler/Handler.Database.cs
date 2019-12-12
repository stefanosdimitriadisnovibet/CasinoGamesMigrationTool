using CasinoGamesMigrationTool.DatabaseContext.Context;
using CasinoGamesMigrationTool.DatabaseContext.Models;
using CasinoGamesMigrationTool.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CasinoGamesMigrationTool.DatabaseHandler
{
	public static class DatabaseHandler
	{
		public static readonly ILogger Logger = new FileLogger();

		public static UserCasinoGames[] HandleGames()
		{
			using (BBBetsArchiveDbContext dbContext = new BBBetsArchiveDbContext())
			{
				UserCasinoGames[] games = dbContext.UserCasinoGames
					.Include(game => game.CategoryNavigation)
					.Include(game => game.ManufacturerNavigation)
					.Include(game => game.ProviderNavigation)
					.Include(game => game.TypeNavigation)
					.ToArray();

				return games;
			}
		}
	}
}