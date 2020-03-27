using System;

namespace CasinoGamesMigrationTool.Console
{
	public class Provider
	{
		public int id { get; set; }
		public string sysname { get; set; }
		public string name { get; set; }
		public int gamesCount { get; set; }
		public DateTime created { get; set; }
	}
}