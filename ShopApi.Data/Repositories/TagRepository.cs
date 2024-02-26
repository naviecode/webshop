using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface ITagRepository
    {
        
    }
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
       
        public TagRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
