﻿// <auto-generated />
using DataAPIDocker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAPI_LocalDB.Migrations
{
    [DbContext(typeof(MagContext))]
    [Migration("20191011220958_initsqlite")]
    partial class initsqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("DataAPIDocker.Magazine", b =>
                {
                    b.Property<int>("MagazineId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("MagazineId");

                    b.ToTable("Magazine");

                    b.HasData(
                        new
                        {
                            MagazineId = 1,
                            Name = "Concatenate Magazine"
                        },
                        new
                        {
                            MagazineId = 2,
                            Name = "Docker Magazine"
                        },
                        new
                        {
                            MagazineId = 3,
                            Name = "EFCore Magazine"
                        },
                        new
                        {
                            MagazineId = 4,
                            Name = "SQLite Magazine"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
