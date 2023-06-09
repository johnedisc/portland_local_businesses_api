﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortlandLocalShopsApi.Models;

#nullable disable

namespace PortlandLocalShopsApi.Migrations
{
    [DbContext(typeof(PortlandLocalShopsApiContext))]
    [Migration("20230331174102_addMusicType")]
    partial class addMusicType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PortlandLocalShopsApi.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MusicType")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PartOfTown")
                        .HasColumnType("longtext");

                    b.Property<string>("StoreType")
                        .HasColumnType("longtext");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");
                });
#pragma warning restore 612, 618
        }
    }
}
