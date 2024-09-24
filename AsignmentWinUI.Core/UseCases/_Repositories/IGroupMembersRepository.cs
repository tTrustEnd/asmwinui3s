using AsignmentWinUI.Core.Entities;

namespace AsignmentWinUI.Core.UseCases._Repositories;

public interface IGroupMembersRepository
{
    Task<IEnumerable<GroupMember>> GetOnlineGroupMembersAsync(int groupID);
}
