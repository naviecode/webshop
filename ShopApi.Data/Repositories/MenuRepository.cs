using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface IMenuRepository
    {
        
    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
       
        public MenuRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
