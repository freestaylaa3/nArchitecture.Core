using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Core.Security;

public class UserCompany : Entity<int>
{
    public int UserId { get; set; }
    public int CompanyId { get; set; }
    public virtual User User { get; set; }
    public virtual Company Company { get; set; }

    public UserCompany()
    {
    }

    public UserCompany(int userId, int companyId)
    {
        UserId = userId;
        CompanyId = companyId;
    }
}
