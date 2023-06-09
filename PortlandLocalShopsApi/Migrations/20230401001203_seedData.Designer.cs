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
    [Migration("20230401001203_seedData")]
    partial class seedData
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

                    b.HasData(
                        new
                        {
                            ShopId = 5,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kassulke, Schaden and Stamm",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 6,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Jacobi-Rohan",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 7,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Morissette, Bins and Champlin",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 8,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Schmidt, Bauch and DuBuque",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 9,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Bosco, Bradtke and Grimes",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 10,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Feest Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 11,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "McDermott LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 12,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Bradtke-Gleason",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 13,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Hackett-McClure",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 14,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Hills, Gorczany and Stamm",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 15,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Mohr Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 16,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Towne, Glover and Homenick",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 17,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Ondricka, Gutmann and Nolan",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 18,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Konopelski LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 19,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Blanda-Macejkovic",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 20,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Luettgen Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 21,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Hand-Paucek",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 22,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Zemlak-Hickle",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 23,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Reinger-Gutmann",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 24,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Ebert Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 25,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kessler Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 26,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Okuneva, Hermiston and Barrows",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 27,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Wolff, Wiza and Feeney",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 28,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Conroy-Kessler",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 29,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Spencer Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 30,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Haley, Leuschke and Kemmer",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 31,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Casper Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 32,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Beahan LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 33,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Heidenreich Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 34,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Morar, Labadie and Bechtelar",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 35,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Cremin-Herzog",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 36,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Langworth Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 37,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Lynch, Parisian and Monahan",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 38,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Spencer-Johnston",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 39,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Hintz, Ullrich and Marks",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 40,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Heaney, Armstrong and Hilpert",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 41,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Baumbach, Roob and Beier",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 42,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Buckridge-Kertzmann",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 43,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Lueilwitz, Price and Buckridge",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 44,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Veum, Marks and Schmidt",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 45,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Koss-Treutel",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 46,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Hettinger, Bahringer and Crist",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 47,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Glover LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 48,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kovacek, Kessler and Senger",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 49,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Friesen Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 50,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Sawayn LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 51,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kemmer, Bednar and Cassin",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 52,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Baumbach, Schultz and Brown",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 53,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kuhlman LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 54,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kozey Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 55,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Schuppe LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 56,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Bosco LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 57,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Jones, Nienow and Jast",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 58,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Borer LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 59,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Jenkins, Miller and Lind",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 60,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Oberbrunner-Schimmel",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 61,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Wintheiser, Beahan and Bartell",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 62,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Marvin-Jones",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 63,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Toy Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 64,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kunze, Little and Walker",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 65,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Schowalter Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 66,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Mante, Legros and Senger",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 67,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Hilpert Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 68,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Hintz LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 69,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Cruickshank Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 70,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Parker LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 71,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Yost-Wolff",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 72,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Anderson Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 73,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Daugherty-Breitenberg",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 74,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Pacocha LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 75,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Lind Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 76,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kirlin-Bailey",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 77,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Gottlieb, Reinger and Nolan",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 78,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Schiller Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 79,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Conroy-Wilderman",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 80,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Gorczany-Frami",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 81,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Champlin, Price and Gutmann",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 82,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Gusikowski-Wilderman",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 83,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Keeling, Goodwin and Hand",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 84,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Marquardt, Veum and Cummings",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 85,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Legros, Schumm and Spinka",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 86,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kuhic, Jacobs and Wyman",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 87,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Bednar, Purdy and Hudson",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 88,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Schmidt-Hackett",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 89,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Schneider-Lowe",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 90,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Cruickshank Group",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 91,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Bergnaum-Littel",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 92,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Fahey LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 93,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Kris LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 94,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "King-Schultz",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 95,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Ebert LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 96,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Swaniawski-Moen",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 97,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Price LLC",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 98,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "DuBuque, Casper and Swaniawski",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        },
                        new
                        {
                            ShopId = 99,
                            MusicType = "Faker.Lorem.Words(4)",
                            Name = "Yundt Inc and Sons",
                            PartOfTown = "Faker.Lorem.Words(4)",
                            StoreType = "Faker.Lorem.Words(4)"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
