using API.Entities;
using API.Helpers;

namespace API.Interfaces;

public interface IMemberRepository
{
    void Update(Member member);
    Task<PaginatedResults<Member>> GetMembersAsync(MemberParams memberParams);
    Task<Member?> GetMemberByIdAsync(string id);
    Task<IEnumerable<Photo>> GetPhotosForMembersAsync(string memberId, bool isCurrentMember);
    Task<Member?> GetMemberForUpdate(string id);
}
