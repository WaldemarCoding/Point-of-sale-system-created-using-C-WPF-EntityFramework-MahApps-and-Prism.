using System;

namespace PoS.Dal.Mdl
{
	public class Discount: IModel
	{
		public string Name { get; set; }

		public string DiscountDesc { get; set; }

		public double Percent { get; set; }

		public int Id
		{
			get; set;
		}
		public string CreatedBy
		{
			get; set;
		}
		public DateTime CreatedDate
		{
			get; set;
		}
		public string ModifiedBy
		{
			get; set;
		}
		public DateTime ModifiedDate
		{
			get; set;
		}
	}
}
