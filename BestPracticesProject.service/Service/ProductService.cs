using BestPracticeProject.Core.Models;
using BestPracticeProject.Core.Repositories;
using BestPracticeProject.Core.Service;
using BestPracticeProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.service.Service
{
    public class ProductService:Service<Product>, IProductService
    {
        public async Task<Product> GetWithProductsiByIdAsync(int productId)
        {
            return await _unitofWork.Products.GetWithProductsByIdAsync(productId);
        }

        public Task<Katagori> GetWihtKatagoriByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository): base
            (unitOfWork,repository)
        {
                
        }
    }
}
