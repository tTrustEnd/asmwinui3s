using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Core.UseCases._Repositories;

namespace AsignmentWinUI.Core.UseCases.GetOnlineGroupMemberUseCase;

public class GetOnlineGroupMemberUseCase : IGetOnlineGroupMemberUseCase
{
    private readonly IGroupMembersRepository _membersRepository;
    public GetOnlineGroupMemberUseCase(IGroupMembersRepository membersRepository)
    {
        _membersRepository = membersRepository;
    }
    public async Task<IEnumerable<GroupMember>> ExecuteAsync(int groupId)
    {
        try
        {
            return await _membersRepository.GetOnlineGroupMembersAsync(groupId);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
