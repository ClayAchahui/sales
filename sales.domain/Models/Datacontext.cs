using System;
using System.Data.Entity;

namespace sales.domain.Models
{
	public class DataContext:DbContext
	{
		public DataContext():base("DefaultConnection")
		{
			
		}

		public System.Data.Entity.DbSet<sales.common.Models.Product> Products { get; set; }
	}
}
