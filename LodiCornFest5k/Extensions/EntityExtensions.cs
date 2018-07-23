using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LodiCornFest5k.Extensions
{
    public static class EntityExtensions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }

        public static async Task ClearAsync<T>(this DbSet<T> dbSet) where T : class
        {
            await Task.Run(() => { Clear(dbSet); });
        }
    }
}