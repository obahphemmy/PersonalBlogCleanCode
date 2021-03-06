using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Presentation.Web.Areas.Admin.ViewModels
{
	public class AddArticleViewModel
	{
		[Required(ErrorMessage = "Enter a title for your article")]
		[Display(Name ="Article title")]
		public string Title { get; set; }
		
		[Required(ErrorMessage = "Provide body text for your article")]
		[Display(Name ="Article body")]
		[DataType(DataType.MultilineText)]
		public string Body { get; set; }

		public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
		
		[Required(ErrorMessage ="Please select a category for your article")]
		[Display(Name ="Category")]
		[DataType(DataType.Text, ErrorMessage ="Select a valid category")]
		public int CategoryId { get; set; }

		public string AuthorId { get; set; }

		[Required(ErrorMessage ="Please enter a post image URL")]
		[RegularExpression(@"https?.+", ErrorMessage ="Plese provide a valid image URL")]
		public string PostImageUrl { get; set; } = "https://picsum.photos/600";

	}
}
