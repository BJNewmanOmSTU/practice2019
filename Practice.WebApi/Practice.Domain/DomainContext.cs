using Microsoft.EntityFrameworkCore;

namespace Practice.Domain
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class DomainContext : DbContext
    {
        public DomainContext()
            : base()
        {
        }

        public DomainContext(DbContextOptions<DomainContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// В этом методе описывается создание моделей и настройка полей
        /// </summary>
        /// <param name="mb">Модель БД</param>
        protected override void OnModelCreating(ModelBuilder mb)
        {
            // TODO:
        }
    }
}
