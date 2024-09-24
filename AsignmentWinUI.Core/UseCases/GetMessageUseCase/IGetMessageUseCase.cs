using AsignmentWinUI.Core.Entities;

namespace AsignmentWinUI.Core.UseCases.GetMessageUseCase;

public interface IGetMessageUseCase
{
    Task<IEnumerable<Message>> ExecuteAsync();
}
