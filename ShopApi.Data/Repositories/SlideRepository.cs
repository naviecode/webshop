using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface ISlideRepository
    {
        
    }
    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
       
        public SlideRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
