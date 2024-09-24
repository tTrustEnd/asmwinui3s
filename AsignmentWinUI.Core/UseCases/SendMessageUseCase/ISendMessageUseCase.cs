using AsignmentWinUI.Core.Entities;

namespace AsignmentWinUI.Core.UseCases.SendMessageUseCase;

public interface ISendMessageUseCase
{
    Task ExecuteAsync(string user, string message);
}

