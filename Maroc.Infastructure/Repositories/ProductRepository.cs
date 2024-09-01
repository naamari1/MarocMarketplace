using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Infastructure.Data;

namespace Maroc.Infastructure.Repositories
{
    public class ProductRepository : CrudRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
