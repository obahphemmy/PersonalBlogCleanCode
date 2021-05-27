using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Presentation.Web.ViewModels
{
	public class CommentViewModel
	{
		[Required(ErrorMessage ="Please enter your comment")]
		public string Comment { get; set; }
		public string CommentAuthor { get; set; }
		public string CommentAuthorEmail { get; set; }
		public string CommentAuthorId { get; set; }
		public int ArticleId { get; set; }
	}
}
