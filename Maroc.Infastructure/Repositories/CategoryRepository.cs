using Maroc.Core.Entities;
using Maroc.Core.Interfaces;
using Maroc.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maroc.Infastructure.Repositories
{
    public class CategoryRepository : CrudRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
