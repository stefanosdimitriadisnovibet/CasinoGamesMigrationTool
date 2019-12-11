namespace CasinoGamesMigrationTool.XmlParser
{
	public abstract class Response
	{
		public bool Success { get; set; }
		public Error Error { get; set; }
		public Result Result { get; set; }
	}
}