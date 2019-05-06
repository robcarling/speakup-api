using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Speakup.API.Domain.Models;
using Speakup.API.Domain.Repositories;
using Speakup.API.Domain.Services;
using Speakup.API.Domain.Services.Communication;

namespace Speakup.API.Services
{
    public class CommentService : ICommentService
{
	private readonly ICommentRepository _commentRepository;
	private readonly IUnitOfWork _unitOfWork;

	public CommentService(ICommentRepository commentRepository, IUnitOfWork unitOfWork)
	{
		_commentRepository = commentRepository;
		_unitOfWork = unitOfWork;
	}

	public async Task<IEnumerable<Comment>> ListAsync()
	{
		return await _commentRepository.ListAsync();
	}

	public async Task<SaveCommentResponse> SaveAsync(Comment comment)
	{
		try
		{
			await _commentRepository.AddAsync(comment);
			await _unitOfWork.CompleteAsync();
			
			return new SaveCommentResponse(comment);
		}
		catch (Exception ex)
		{
			// Do some logging stuff
			return new SaveCommentResponse($"An error occurred when saving the comment: {ex.Message}");
		}
	}
}
}


