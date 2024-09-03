using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Infastructure.Data;

namespace Maroc.Infastructure.Repositories
{
    public class PaymentRepository : CrudRepository<Payment>, IPaymentRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
