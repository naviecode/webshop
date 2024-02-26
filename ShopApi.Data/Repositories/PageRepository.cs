using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface IPageRepository
    {
        
    }
    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
       
        public PageRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
