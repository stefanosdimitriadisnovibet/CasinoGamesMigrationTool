namespace CasinoGamesMigrationTool.Console
{
	public class BonusProfileCreateRequest
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public GameAttributeCreateRequest[] Attributes { get; set; }
	}
}