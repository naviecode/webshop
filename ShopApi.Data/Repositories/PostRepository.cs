using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface IPostRepository
    {
        
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
       
        public PostRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
