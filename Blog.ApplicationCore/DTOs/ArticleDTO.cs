namespace Blog.ApplicationCore.DTOs
{
	public class ArticleDTO
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public string Category { get; set; }
		public string Author { get; set; }
		public string ArthorImageUrl { get; set; }
		public string ArticleImageUrl { get; set; }
		public string ArticleDate { get; set; }
		public string AuthorId { get; set; }
	}
}
