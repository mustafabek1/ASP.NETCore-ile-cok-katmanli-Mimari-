using BestPracticeProject.Core.Models;
using BestPracticeProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesProject.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
       

        private AppDbContext AppDbContext { get => _context as AppDbContext; }

        public ProductRepository(DbContext context) : base(context)
        { 
        }
        public async Task<Product> GetWithProductsByIdAsync(int productId)
        {
            return await AppDbContext.Products.Include(x => x.Katagori).SingleOrDefaultAsync(X => X.Id == productId);
        }
    }
}
