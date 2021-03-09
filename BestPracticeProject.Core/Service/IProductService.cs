using BestPracticeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticeProject.Core.Service
{
   public interface IProductService : IService<Product>
    {
        Task<Product> GetWithProductsiByIdAsync(int productId);
        Task<Katagori> GetWihtKatagoriByIdAsync(int id);
    }
}
