namespace SnehaPieShop.Models
{
    public class OrderRepository :IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        public OrderRepository(AppDbContext appDbContext)
        {
           this._appDbContext = appDbContext; ;
        }
        public IEnumerable<Order> AllOrder => _appDbContext.order;
    }
}
