﻿using PoS.Dal.Mdl;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace PoS.Dal.Sql.Ctx.Configuration
{
	public class OrderEntityConfiguration: EntityTypeConfiguration<Order>
	{
		public OrderEntityConfiguration ()
		{
			HasKey (o => o.Id);

			Property(o => o.BarCode).HasMaxLength(100)
				.HasColumnAnnotation("Index",
				new IndexAnnotation(new IndexAttribute("IDX_UQ_ORDBC")
				{ IsUnique = true }));
			HasRequired(o => o.OrderLine).WithMany(ol => ol.Orders).HasForeignKey(o => o.OrderLineId);
		}
	}
}
