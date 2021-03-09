using BestPracticeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticeProject.Core.Repositories
{
    public interface IKatagoriRepository : IRepository<Katagori>
    {
        Task<Katagori> GetWithKatagoriByIdAsync(int KatagoriId);
    }
}
