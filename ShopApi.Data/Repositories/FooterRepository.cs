using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface IFooterRepository
    {
        
    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
       
        public FooterRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

    }
}
