using AsignmentWinUI.Core.Entities;

namespace AsignmentWinUI.Core.UseCases.Repositories;

public interface IMessageRepository
{
    Task SaveMessageAsync(Message message);
    Task<IEnumerable<Message>> GetMessagesAsync();
}
