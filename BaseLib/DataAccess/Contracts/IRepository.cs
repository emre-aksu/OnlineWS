using BaseLib.Model;
using System.Linq.Expressions;

namespace BaseLib.DataAccess.Contracts
{

    public interface IRepository<TEntity,TId>
        where TEntity:BaseEntity<TId>
    {
       /// <summary>
       /// Tüm Listeyi dönenen yer
       /// </summary>
       /// <param name="includeList"></param>
       /// <returns></returns>
        Task<List<TEntity>> GetAllAsycn(params string[] includeList);

       /// <summary>
       /// Kritere uyan kayıtları döndürdüğümüz yer
       /// </summary>
       /// <param name="predicate">Kriter</param>
       /// <param name="includeList">Elde edilen Entity içerisine dahil edilecek olan ilişkili nesneler</param>
       /// <returns></returns>
        Task<List<TEntity>> FilterAsycn(Expression<Func<TEntity,bool>> predicate,params string[] includeList);

        /// <summary>
        /// Kritere göre tek kaydı döndürdüğümüz yer
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includeList"></param>
        /// <returns></returns>
        Task<TEntity> GetAsync(Expression<Func<TEntity,bool>>predicate,params string[] includeList);

        /// <summary>
        /// Id ye göre getiriyor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeList">Include edilmesi gerek yerleri de dahil ediyor</param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(TId id, params string[] includeList);

        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(TId id);


    }
}
