using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface ISystemConfigRepository
    {
        
    }
    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
       
        public SystemConfigRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
