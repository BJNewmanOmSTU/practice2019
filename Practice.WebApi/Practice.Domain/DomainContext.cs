﻿using Microsoft.EntityFrameworkCore;

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

		public DbSet<Code> Codes { get; set; }
		public DbSet<Attribute> Attributes { get; set; }
		public DbSet<Store> Stores { get; set; }
		public DbSet<ProductTemplate> ProductTemplates { get; set; }

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
			});

			mb.Entity<ProductTemplate>(eb =>
			{
				eb.HasKey(p => p.Id);
				eb.Property(p => p.Id).HasMaxLength(ProjectConstants.ID_MAX_LENGTH_32);
			});
		}
    }
}
