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
   public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        public readonly IUnitOfWork _unitofWork;
        private readonly IRepository<TEntity> _repository;

        public Service(IUnitOfWork unitofwork,IRepository<TEntity> repository)
        {
            _unitofWork = unitofwork;
            _repository = repository;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitofWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitofWork.CommitAsync();
            return entities;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
           return await _repository.GetAllAsync();
           
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
            _unitofWork.commit();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _repository.RemoveRange(entities);
            _unitofWork.commit();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> Predicate)
        {
            return await _repository.SingleOrDefaultAsync(Predicate);
        }

        public  TEntity Update(TEntity entities)
        {
            TEntity updateEntity = _repository.Update(entities);
            _unitofWork.commit();
            return updateEntity;
        }

        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> Predicate)
        {
            return await _repository.Where(Predicate);
        }
    }
}
