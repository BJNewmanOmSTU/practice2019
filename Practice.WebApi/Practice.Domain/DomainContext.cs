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
				eb.Property(p => p.Id).HasMaxLength(ProjectConstants.ID_MAX_LENGTH_32);
				eb.HasMany(p => p.Attributes).WithOne(p => p.Code).HasForeignKey(p => p.CodeId);
				eb.HasOne(p => p.ProductTemplate).WithMany(p => p.Codes).HasForeignKey(p => p.ProductTemplateId);
				eb.HasOne(p => p.Store).WithMany(p => p.Codes).HasForeignKey(p => p.StoreId);
			});

			mb.Entity<Attribute>(eb => {
				eb.HasKey(k => k.Id);
				eb.Property(p => p.Id).HasMaxLength(ProjectConstants.ID_MAX_LENGTH_32);
				eb.HasOne(p => p.Code).WithMany(p => p.Attributes).HasForeignKey(p => p.CodeId);
			});

			mb.Entity<Store>(eb =>
			{
				eb.HasKey(p => p.Id);
				eb.Property(p => p.Id).HasMaxLength(ProjectConstants.ID_MAX_LENGTH_32);
				eb.HasMany(p => p.Codes).WithOne(p => p.Store).HasForeignKey(p => p.StoreId);
			});

			mb.Entity<ProductTemplate>(eb =>
			{
				eb.HasKey(p => p.Id);
				eb.Property(p => p.Id).HasMaxLength(ProjectConstants.ID_MAX_LENGTH_32);
				eb.HasMany(p => p.Codes).WithOne(p => p.ProductTemplate).HasForeignKey(p => p.ProductTemplateId);
			});
		}
    }
}
