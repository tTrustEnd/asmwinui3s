using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Core.UseCases.GetMessageUseCase;
using AsignmentWinUI.Core.UseCases.SendMessageUseCase;

namespace AsignmentWinUI.Core.UseCases.Services;

public class MessageService: IMessageService
{
    private readonly ISendMessageUseCase _sendMessageUseCase;
    private readonly IGetMessageUseCase _getMessageUseCase;
    public MessageService(ISendMessageUseCase sendMessageUseCase, IGetMessageUseCase getMessageUseCase)
    {
        _sendMessageUseCase = sendMessageUseCase;
        _getMessageUseCase = getMessageUseCase;
    }

    public async Task<IEnumerable<Message>> GetMessagesAsync()
    {
        return await _getMessageUseCase.ExecuteAsync();
    }
    public async Task SendMessageAsync(string user, string message)
    {
        await _sendMessageUseCase.ExecuteAsync(user, message);
    }
        
}
