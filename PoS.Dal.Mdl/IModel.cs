using System;

namespace PoS.Dal.Mdl
{
	public interface IModel
	{
		int Id { get; set; }

		string CreatedBy { get; set; }

		DateTime CreatedDate { get; set; }

		string ModifiedBy { get; set; }

		DateTime ModifiedDate { get; set; }
	}
}
