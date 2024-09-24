using AsignmentWinUI.Core.Entities;

namespace AsignmentWinUI.Core.UseCases.GetOnlineGroupMemberUseCase;

public interface IGetOnlineGroupMemberUseCase
{
    Task<IEnumerable<GroupMember>>? ExecuteAsync(int groupId);
}
