using BestPracticeProject.Core.Models;
using BestPracticeProject.Core.Repositories;
using BestPracticeProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.service.Service
{
    public class KatagoriService : Service<Katagori>, IKatagoriService
    {
        public KatagoriService(IUnitOfWork unitofwork, IRepository<Katagori> repository) : base(unitofwork, repository)
        {
        }


        public async Task<Katagori> GetWithProductByIdAsync(int katagoriId)
        {
           return await _unitofWork.Katagoris.GetWithKatagoriByIdAsync(katagoriId);

        }

        Task IKatagoriService.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
