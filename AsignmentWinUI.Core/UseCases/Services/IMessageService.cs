using AsignmentWinUI.Core.Entities;

namespace AsignmentWinUI.Core.UseCases.Services;

public interface IMessageService
{
    Task SendMessageAsync(string user, string message);
    Task <IEnumerable<Message>> GetMessagesAsync();
}
