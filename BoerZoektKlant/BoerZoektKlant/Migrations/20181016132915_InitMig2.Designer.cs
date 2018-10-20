﻿// <auto-generated />
using System;
using BoerZoektKlant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoerZoektKlant.Migrations
{
    [DbContext(typeof(RepositoryDbContext))]
    [Migration("20181016132915_InitMig2")]
    partial class InitMig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoerZoektKlant.Models.App.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessCategoriesBusinessId");

                    b.Property<int?>("BusinessCategoriesCategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Excerpt");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Rating");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BusinessCategoriesBusinessId", "BusinessCategoriesCategoryId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("BoerZoektKlant.Models.App.BusinessCategories", b =>
                {
                    b.Property<int>("BusinessId");

                    b.Property<int>("CategoryId");

                    b.HasKey("BusinessId", "CategoryId");

                    b.ToTable("BusinessCategorieses");
                });

            modelBuilder.Entity("BoerZoektKlant.Models.App.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessCategoriesBusinessId");

                    b.Property<int?>("BusinessCategoriesCategoryId");

                    b.Property<int?>("BusinessId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.HasIndex("BusinessCategoriesBusinessId", "BusinessCategoriesCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BoerZoektKlant.Models.App.Prices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessId");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("BoerZoektKlant.Models.App.Business", b =>
                {
                    b.HasOne("BoerZoektKlant.Models.App.BusinessCategories")
                        .WithMany("Businesses")
                        .HasForeignKey("BusinessCategoriesBusinessId", "BusinessCategoriesCategoryId");
                });

            modelBuilder.Entity("BoerZoektKlant.Models.App.Category", b =>
                {
                    b.HasOne("BoerZoektKlant.Models.App.Business")
                        .WithMany("Categories")
                        .HasForeignKey("BusinessId");

                    b.HasOne("BoerZoektKlant.Models.App.BusinessCategories")
                        .WithMany("Categories")
                        .HasForeignKey("BusinessCategoriesBusinessId", "BusinessCategoriesCategoryId");
                });

            modelBuilder.Entity("BoerZoektKlant.Models.App.Prices", b =>
                {
                    b.HasOne("BoerZoektKlant.Models.App.Business")
                        .WithMany("Prices")
                        .HasForeignKey("BusinessId");
                });
#pragma warning restore 612, 618
        }
    }
}
