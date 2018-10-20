﻿using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Implementations
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly AppDbContext _context;
        protected DbSet<T> EntitySet => _context.Set<T>();
        public virtual IQueryable<T> Entities => EntitySet.AsQueryable();

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public T Get(params object[] keyValues)
        {
            var entity = EntitySet.Find(keyValues);
            return entity; //?? throw new EntityNotFoundException(keyValues);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Entities.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return Entities;
        }

        public void Create(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Delete(params object[] keyValues)
        {
            var entity = Get(keyValues);
            DeleteEntity(entity);
        }

        public int Delete(Expression<Func<T, bool>> predicate)
        {
            var entities = Get(predicate);
            entities.ToList().ForEach(DeleteEntity);
            return entities.Count();
        }

        public void Edit(T entity)
        {
            //_context.Entry(entity).State = EntityState.Modified;
        }

        private void DeleteEntity(T entity)
        {
            //if (entity is ILogicalDeleteEntity unDeletableEntity)
            //{
            //    unDeletableEntity.Deleted = true;
            //    _context.Entry(unDeletableEntity).State = EntityState.Modified;
            //}
            //else
            //{
            //    _context.Entry(entity).State = EntityState.Deleted;
            //}
        }
    }
}
