﻿using System;
using System.Collections.Generic;

namespace PoS.Dal.Mdl
{
	public class OrderLine: IModel
	{
		public double TotalPrice { get; set; }

		public int UserId { get; set; }

		public int EmployeeId { get; set; }

		public double Points { get; set; }

		public string Remarks { get; set; }

		public int ItemCount { get; set; }

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

		public virtual ICollection<Order> Orders { get; set; }
	}
}
