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
			mb.Entity<Code>(eb => {
				eb.HasKey(k => k.Id);
				eb.Property(p => p.Id).HasMaxLength(32);
				eb.HasMany(p => p.Attributes).WithOne(p => p.Code).HasForeignKey(p => p.CodeId);
			});

			mb.Entity<Attribute>(eb => {
				eb.HasKey(k => k.Id);
				eb.Property(p => p.Id).HasMaxLength(32);
			});

			mb.Entity<Store>(eb =>
			{
				eb.HasKey(p => p.Id);
				eb.Property(p => p.Id).HasMaxLength(32);
			});

			mb.Entity<ProductTemplate>(eb =>
			{
				eb.HasKey(p => p.Id);
				eb.Property(p => p.Id).HasMaxLength(32);
			});
		}
    }
}
