using BestPracticeProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticeProject.Core.UnitOfWorks
{
   public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        IKatagoriRepository Katagoris { get; }




        Task CommitAsync();

        void commit();
    }
}
