using BestPracticeProject.Core.Models;
using BestPracticeProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesProject.Data.Repository
{
    public class KatagoriRepository : Repository<Katagori>, IKatagoriRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public KatagoriRepository(DbContext context) : base(context)
        {
        }

        public async Task<Katagori> GetWithKatagoriByIdAsync(int KatagoriId)
        {
            return await _appDbContext.Katagoris.Include(x => x.Products).SingleOrDefaultAsync(X => X.Id == KatagoriId);
        }
    }


}
