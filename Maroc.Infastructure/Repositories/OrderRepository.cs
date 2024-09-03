using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Infastructure.Data;

namespace Maroc.Infastructure.Repositories
{
    public class OrderRepository : CrudRepository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
