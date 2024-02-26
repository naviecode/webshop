using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface IMenuGroupRepository
    {
        
    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
       
        public MenuGroupRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
