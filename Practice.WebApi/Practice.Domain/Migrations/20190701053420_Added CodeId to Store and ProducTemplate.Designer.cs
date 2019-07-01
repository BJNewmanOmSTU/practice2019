﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practice.Domain;

namespace Practice.Domain.Migrations
{
    [DbContext(typeof(DomainContext))]
    [Migration("20190701053420_Added CodeId to Store and ProducTemplate")]
    partial class AddedCodeIdtoStoreandProducTemplate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Practice.Domain.Attribute", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<string>("CodeId");

                    b.Property<string>("Comment");

                    b.Property<string>("Title");

                    b.Property<string>("TypeId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CodeId");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("Practice.Domain.Code", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<long>("Amount");

                    b.Property<string>("ProductTemplateId");

                    b.Property<string>("SellSource");

                    b.Property<string>("StoreId");

                    b.Property<string>("Symbol");

                    b.HasKey("Id");

                    b.HasIndex("ProductTemplateId")
                        .IsUnique()
                        .HasFilter("[ProductTemplateId] IS NOT NULL");

                    b.HasIndex("StoreId")
                        .IsUnique()
                        .HasFilter("[StoreId] IS NOT NULL");

                    b.ToTable("Codes");
                });

            modelBuilder.Entity("Practice.Domain.ProductTemplate", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("ProductTemplates");
                });

            modelBuilder.Entity("Practice.Domain.Store", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Practice.Domain.Attribute", b =>
                {
                    b.HasOne("Practice.Domain.Code", "Code")
                        .WithMany("Attributes")
                        .HasForeignKey("CodeId");
                });

            modelBuilder.Entity("Practice.Domain.Code", b =>
                {
                    b.HasOne("Practice.Domain.ProductTemplate")
                        .WithOne("Code")
                        .HasForeignKey("Practice.Domain.Code", "ProductTemplateId");

                    b.HasOne("Practice.Domain.Store")
                        .WithOne("Code")
                        .HasForeignKey("Practice.Domain.Code", "StoreId");
                });
#pragma warning restore 612, 618
        }
    }
}
