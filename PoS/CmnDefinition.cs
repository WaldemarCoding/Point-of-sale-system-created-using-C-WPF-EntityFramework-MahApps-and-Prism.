﻿namespace PoS
{
	public static class ViewNames
	{
		public const string InventoryMainView = "InventoryMainView";
		public const string HomeMainView = "HomeTilesView";
	}

	public class ViewContent
	{
		public string ViewName
		{
			get; set;
		}

		public int IconIdx
		{
			get; set;
		}
	}
}
