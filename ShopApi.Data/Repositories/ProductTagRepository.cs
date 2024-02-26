using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface IProductTagRepository
    {
        
    }
    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
       
        public ProductTagRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
