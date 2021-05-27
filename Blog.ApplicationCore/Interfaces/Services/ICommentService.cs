using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Interfaces.Services
{
	public interface ICommentService
	{
		Task<int> Add(CommentDTO comment);
		Task<IEnumerable<CommentDTO>> GetComments(int articleId);
	}
}