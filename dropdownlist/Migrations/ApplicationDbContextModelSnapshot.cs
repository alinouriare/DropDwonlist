﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dropdownlist.Models;

namespace dropdownlist.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dropdownlist.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.Property<int>("ProvinceID");

                    b.HasKey("ID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("cityTbl");
                });

            modelBuilder.Entity("dropdownlist.Models.Province", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProvinceName");

                    b.HasKey("ID");

                    b.ToTable("provinceTbl");
                });

            modelBuilder.Entity("dropdownlist.Models.userInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID");

                    b.Property<string>("Family");

                    b.Property<string>("FirstName");

                    b.Property<int>("ProvinceID");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("userinfiTbl");
                });

            modelBuilder.Entity("dropdownlist.Models.City", b =>
                {
                    b.HasOne("dropdownlist.Models.Province", "prv")
                        .WithMany()
                        .HasForeignKey("ProvinceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dropdownlist.Models.userInfo", b =>
                {
                    b.HasOne("dropdownlist.Models.City", "cy")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
