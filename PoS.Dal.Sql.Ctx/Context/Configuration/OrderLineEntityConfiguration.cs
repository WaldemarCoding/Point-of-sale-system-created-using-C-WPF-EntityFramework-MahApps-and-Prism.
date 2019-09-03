using PoS.Dal.Mdl;
using System.Data.Entity.ModelConfiguration;

namespace PoS.Dal.Sql.Ctx.Configuration
{
	public class OrderLineEntityConfiguration: EntityTypeConfiguration<OrderLine>
	{
		public OrderLineEntityConfiguration ()
		{
			HasKey (ol => ol.Id);
		}
	}
}
