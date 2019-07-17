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
    [Migration("20190712035138_Replaces_string_Status_to_enum")]
    partial class Replaces_string_Status_to_enum
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

                    b.ToTable("Attribute");
                });

            modelBuilder.Entity("Practice.Domain.Code", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<long>("Amount");

                    b.Property<string>("OrderUniqNumber");

                    b.Property<string>("ProductTemplateId");

                    b.Property<string>("RedeemCode");

                    b.Property<bool>("Removed");

                    b.Property<string>("SellSource");

                    b.Property<string>("StoreId");

                    b.Property<string>("Symbol");

                    b.HasKey("Id");

                    b.HasIndex("ProductTemplateId");

                    b.HasIndex("StoreId");

                    b.ToTable("Code");
                });

            modelBuilder.Entity("Practice.Domain.ProductTemplate", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ProductTemplate");
                });

            modelBuilder.Entity("Practice.Domain.Store", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("Practice.Domain.Attribute", b =>
                {
                    b.HasOne("Practice.Domain.Code", "Code")
                        .WithMany("Attributes")
                        .HasForeignKey("CodeId");
                });

            modelBuilder.Entity("Practice.Domain.Code", b =>
                {
                    b.HasOne("Practice.Domain.ProductTemplate", "ProductTemplate")
                        .WithMany("Codes")
                        .HasForeignKey("ProductTemplateId");

                    b.HasOne("Practice.Domain.Store", "Store")
                        .WithMany("Codes")
                        .HasForeignKey("StoreId");
                });
#pragma warning restore 612, 618
        }
    }
}
