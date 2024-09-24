using System.CodeDom;
using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Core.UseCases.Repositories;

namespace AsignmentWinUI.Core.UseCases.GetMessageUseCase;

public class GetMessageUseCase : IGetMessageUseCase
{
    private readonly IMessageRepository _messageRepository;
    public GetMessageUseCase(IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }
    public async Task<IEnumerable<Message>> ExecuteAsync()
    {
        return await _messageRepository.GetMessagesAsync();
    }
}
