using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ApplicationCore.Entities
{
	public class AuditableEntity
	{
		public int Id { get; set; }
		public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
		public DateTimeOffset ModifiedDate { get; set; } = DateTimeOffset.Now;
		public string ModifiedBy { get; set; }
		public string CreatedBy { get; set; }
	}
}
