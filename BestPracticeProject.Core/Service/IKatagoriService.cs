using BestPracticeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticeProject.Core.Service
{
   public interface IKatagoriService:IService<Katagori>
    {
        Task<Product> GetWithKatagoriByIdAsync(int katagoriId);
        Task<Product> GetWithProductsByIdAsync(int id);

        

    }
}
