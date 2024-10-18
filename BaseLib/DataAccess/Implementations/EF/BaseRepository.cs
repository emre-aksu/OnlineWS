using BaseLib.DataAccess.Contracts;
using BaseLib.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BaseLib.DataAccess.Implementations.EF
{
    public abstract class BaseRepository<TEntity, TId, TContext> : IRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TContext : DbContext, new()
    {
        public async Task<List<TEntity>> FilterAsycn(Expression<Func<TEntity, bool>> predicate, params string[] includeList)
        {
            using TContext ctx = new();

            IQueryable<TEntity> dbSet = ctx.Set<TEntity>(); // DbSet'e erişiyoruz IQueryyable tipinde
            if (includeList != null && includeList.Length > 0) // eğer inculuede edilecek bir şeyler varsa null değil birden fazla bilgi var ise bunu yapıyoruz
            {
                foreach (var item in includeList) // birden fazla include edilecek tablomuz var ise döngü kullanıyoruz

                    dbSet = dbSet.Include(item);
            }
            dbSet = dbSet.Where(predicate); // burada da kriter uyguluyoruz
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params string[] includeList)
        {
            using TContext ctx = new();

            IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
            if (includeList != null)
            {
                foreach (var item in includeList) //includeleri yaptık 

                    dbSet = dbSet.Include(item);
            }
            return await dbSet.SingleOrDefaultAsync(predicate); // Kriterleri yaptık


        }

        public async Task<List<TEntity>> GetAllAsycn(params string[] includeList) // krirter yok bunu kullan
        {
            using TContext ctx = new();

            IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
            if (includeList != null && includeList.Length > 0)
            {
                foreach (var item in includeList)

                    dbSet = dbSet.Include(item);
            }

            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(TId id, params string[] includeList)
        {
            using TContext ctx = new();

            IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
            if (includeList != null)
            {
                foreach (var item in includeList) // includeleri yaptık sonra Id ye göre ürünleri çektik

                    dbSet = dbSet.Include(item);
            }
            return await dbSet.SingleOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task InsertAsync(TEntity entity)
        {
            using TContext ctx = new();

            await ctx.Set<TEntity>().AddAsync(entity);
            await ctx.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using TContext ctx = new();
            ctx.Set<TEntity>().Update(entity);
            await ctx.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using TContext ctx = new();
            ctx.Set<TEntity>().Remove(entity);
            await ctx.SaveChangesAsync();
        }

        public async Task DeleteAsync(TId id) // Id ye göre silme 
        {
            var entity = await GetByIdAsync(id);
            using TContext ctx = new();
            ctx.Set<TEntity>().Remove(entity);
            await ctx.SaveChangesAsync();
        }

    }
}
