using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Entities;
using Blog.ApplicationCore.Interfaces.Repositories;
using Blog.ApplicationCore.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Services
{
	public class CommentService : ICommentService
	{
		private readonly IUnitOfWork _unitOfWork;

		public CommentService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<int> Add(CommentDTO model)
		{
			var comment = new Comment
			{
				ArticleComment = model.Comment,
				ArticleId = model.ArticleId,
				CommentAuthorId = model.CommentAuthorId
			};

			await _unitOfWork.Comments.Add(comment);
			await _unitOfWork.Complete();

			return comment.Id;
		}

		public async Task<IEnumerable<CommentDTO>> GetComments(int articleId)
		{
			string[] includes = new string[] {"Author"};
			var comments = await _unitOfWork.Comments.GetAll(c => c.ArticleId == articleId, includes);

			return comments.Select(c => new CommentDTO
			{
				Comment = c.ArticleComment,
				CommentAuthor = $"{c.CommentAuthor.Firstname} {c.CommentAuthor.Lastname}",
				CommentAuthorImageUrl = c.CommentAuthor.ProfilePhotoUrl,
				CommentDate = c.CreatedDate.ToString("f")
			}).ToList();
		}

	}
}
