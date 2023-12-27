using Identity.Domain.Entities;
using Identity.Persistence.DataContexts;
using Identity.Persistence.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Identity.Persistence.Repositories;

public class RoleRepository : EntityRepositoryBase<Role, IdentityDbContext>, IRoleRepository
{
    public RoleRepository(IdentityDbContext dbContext) : base(dbContext)
    {
    }

    public new IQueryable<Role> Get(Expression<Func<Role, bool>>? predicate = default, bool asNoTracking = false)
    {
        return base.Get(predicate, asNoTracking);
    }
}