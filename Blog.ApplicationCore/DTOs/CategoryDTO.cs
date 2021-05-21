namespace Blog.ApplicationCore.DTOs
{
	public class CategoryDTO
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public int NumberOfArticles { get; set; }
		public string CategoryImageUrl { get; set; } 
	}
}
