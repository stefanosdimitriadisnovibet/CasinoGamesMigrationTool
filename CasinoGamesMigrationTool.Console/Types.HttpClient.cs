using System.Net.Http;

namespace CasinoGamesMigrationTool.Console
{
	public static class MyHttpClient
	{
		public static HttpClient _HttpClient = new HttpClient();

		public static string BaseUrl = "http://backoffice.casinogames.webapi.sdim.local/api";
	}
}