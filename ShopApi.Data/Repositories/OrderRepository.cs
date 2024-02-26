using ShopApi.Data.Infrastructure;
using ShopApi.Model.Models;

namespace ShopApi.Data.Repositories
{
    public interface IOrderRepository
    {
        
    }
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
       
        public OrderRepository(IDbFactory dbFactory, WebShopDbContext dataContext) : base(dbFactory, dataContext)
        {

        }

       
    }
}
