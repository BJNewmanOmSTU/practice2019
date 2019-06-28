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
    [Migration("20190628044832_Created_Models_Code_and_Attribute_Added_Context_and_relation_description")]
    partial class Created_Models_Code_and_Attribute_Added_Context_and_relation_description
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

                    b.Property<string>("ProductTemplateId");

                    b.Property<string>("SellSource");

                    b.Property<string>("StoreId");

                    b.Property<string>("Symbol");

                    b.HasKey("Id");

                    b.ToTable("Code");
                });

            modelBuilder.Entity("Practice.Domain.Attribute", b =>
                {
                    b.HasOne("Practice.Domain.Code", "Code")
                        .WithMany("Attributes")
                        .HasForeignKey("CodeId");
                });
#pragma warning restore 612, 618
        }
    }
}
