using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface IPostTagRepository
    {
        
    }
    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
       
        public PostTagRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
