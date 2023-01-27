using LocalGoods.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using LocalGoods.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LocalGoods.DAL.Data;
#nullable disable
namespace LocalGoods.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly LocalGoodsDbContext _context;
        public Repository(LocalGoodsDbContext context)
        {
            this._context = context;
        }
        public async Task CreateAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
        }
        public async Task DeleteAsync(TEntity entity)
        {
            _context.Remove(entity);
        }

    }
}
