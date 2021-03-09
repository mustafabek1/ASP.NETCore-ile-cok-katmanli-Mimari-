using BestPracticeProject.Core.Repositories;
using BestPracticeProject.Core.UnitOfWorks;
using BestPractiesProject.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesProject.Data.UnitOfWorks
{
  public  class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;

        }

        private ProductRepository _productRepository;
        private KatagoriRepository _katagoriRepository;
        public IProductRepository Products => _productRepository =  _productRepository ?? new ProductRepository(_context);

        public IKatagoriRepository Katagoris => _katagoriRepository =  _katagoriRepository ?? new KatagoriRepository(_context);

        public void commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
           
        }
    }
}
