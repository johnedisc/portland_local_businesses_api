using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortlandLocalShopsApi.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "MusicType", "Name", "PartOfTown", "StoreType" },
                values: new object[,]
                {
                    { 5, "Faker.Lorem.Words(4)", "Kassulke, Schaden and Stamm", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 6, "Faker.Lorem.Words(4)", "Jacobi-Rohan", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 7, "Faker.Lorem.Words(4)", "Morissette, Bins and Champlin", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 8, "Faker.Lorem.Words(4)", "Schmidt, Bauch and DuBuque", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 9, "Faker.Lorem.Words(4)", "Bosco, Bradtke and Grimes", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 10, "Faker.Lorem.Words(4)", "Feest Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 11, "Faker.Lorem.Words(4)", "McDermott LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 12, "Faker.Lorem.Words(4)", "Bradtke-Gleason", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 13, "Faker.Lorem.Words(4)", "Hackett-McClure", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 14, "Faker.Lorem.Words(4)", "Hills, Gorczany and Stamm", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 15, "Faker.Lorem.Words(4)", "Mohr Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 16, "Faker.Lorem.Words(4)", "Towne, Glover and Homenick", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 17, "Faker.Lorem.Words(4)", "Ondricka, Gutmann and Nolan", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 18, "Faker.Lorem.Words(4)", "Konopelski LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 19, "Faker.Lorem.Words(4)", "Blanda-Macejkovic", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 20, "Faker.Lorem.Words(4)", "Luettgen Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 21, "Faker.Lorem.Words(4)", "Hand-Paucek", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 22, "Faker.Lorem.Words(4)", "Zemlak-Hickle", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 23, "Faker.Lorem.Words(4)", "Reinger-Gutmann", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 24, "Faker.Lorem.Words(4)", "Ebert Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 25, "Faker.Lorem.Words(4)", "Kessler Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 26, "Faker.Lorem.Words(4)", "Okuneva, Hermiston and Barrows", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 27, "Faker.Lorem.Words(4)", "Wolff, Wiza and Feeney", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 28, "Faker.Lorem.Words(4)", "Conroy-Kessler", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 29, "Faker.Lorem.Words(4)", "Spencer Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 30, "Faker.Lorem.Words(4)", "Haley, Leuschke and Kemmer", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 31, "Faker.Lorem.Words(4)", "Casper Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 32, "Faker.Lorem.Words(4)", "Beahan LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 33, "Faker.Lorem.Words(4)", "Heidenreich Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 34, "Faker.Lorem.Words(4)", "Morar, Labadie and Bechtelar", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 35, "Faker.Lorem.Words(4)", "Cremin-Herzog", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 36, "Faker.Lorem.Words(4)", "Langworth Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 37, "Faker.Lorem.Words(4)", "Lynch, Parisian and Monahan", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 38, "Faker.Lorem.Words(4)", "Spencer-Johnston", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 39, "Faker.Lorem.Words(4)", "Hintz, Ullrich and Marks", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 40, "Faker.Lorem.Words(4)", "Heaney, Armstrong and Hilpert", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 41, "Faker.Lorem.Words(4)", "Baumbach, Roob and Beier", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 42, "Faker.Lorem.Words(4)", "Buckridge-Kertzmann", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 43, "Faker.Lorem.Words(4)", "Lueilwitz, Price and Buckridge", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 44, "Faker.Lorem.Words(4)", "Veum, Marks and Schmidt", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 45, "Faker.Lorem.Words(4)", "Koss-Treutel", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 46, "Faker.Lorem.Words(4)", "Hettinger, Bahringer and Crist", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 47, "Faker.Lorem.Words(4)", "Glover LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 48, "Faker.Lorem.Words(4)", "Kovacek, Kessler and Senger", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 49, "Faker.Lorem.Words(4)", "Friesen Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 50, "Faker.Lorem.Words(4)", "Sawayn LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 51, "Faker.Lorem.Words(4)", "Kemmer, Bednar and Cassin", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 52, "Faker.Lorem.Words(4)", "Baumbach, Schultz and Brown", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 53, "Faker.Lorem.Words(4)", "Kuhlman LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 54, "Faker.Lorem.Words(4)", "Kozey Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 55, "Faker.Lorem.Words(4)", "Schuppe LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 56, "Faker.Lorem.Words(4)", "Bosco LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 57, "Faker.Lorem.Words(4)", "Jones, Nienow and Jast", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 58, "Faker.Lorem.Words(4)", "Borer LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 59, "Faker.Lorem.Words(4)", "Jenkins, Miller and Lind", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 60, "Faker.Lorem.Words(4)", "Oberbrunner-Schimmel", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 61, "Faker.Lorem.Words(4)", "Wintheiser, Beahan and Bartell", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 62, "Faker.Lorem.Words(4)", "Marvin-Jones", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 63, "Faker.Lorem.Words(4)", "Toy Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 64, "Faker.Lorem.Words(4)", "Kunze, Little and Walker", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 65, "Faker.Lorem.Words(4)", "Schowalter Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 66, "Faker.Lorem.Words(4)", "Mante, Legros and Senger", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 67, "Faker.Lorem.Words(4)", "Hilpert Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 68, "Faker.Lorem.Words(4)", "Hintz LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 69, "Faker.Lorem.Words(4)", "Cruickshank Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 70, "Faker.Lorem.Words(4)", "Parker LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 71, "Faker.Lorem.Words(4)", "Yost-Wolff", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 72, "Faker.Lorem.Words(4)", "Anderson Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 73, "Faker.Lorem.Words(4)", "Daugherty-Breitenberg", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 74, "Faker.Lorem.Words(4)", "Pacocha LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 75, "Faker.Lorem.Words(4)", "Lind Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 76, "Faker.Lorem.Words(4)", "Kirlin-Bailey", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 77, "Faker.Lorem.Words(4)", "Gottlieb, Reinger and Nolan", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 78, "Faker.Lorem.Words(4)", "Schiller Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 79, "Faker.Lorem.Words(4)", "Conroy-Wilderman", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 80, "Faker.Lorem.Words(4)", "Gorczany-Frami", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 81, "Faker.Lorem.Words(4)", "Champlin, Price and Gutmann", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 82, "Faker.Lorem.Words(4)", "Gusikowski-Wilderman", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 83, "Faker.Lorem.Words(4)", "Keeling, Goodwin and Hand", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 84, "Faker.Lorem.Words(4)", "Marquardt, Veum and Cummings", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 85, "Faker.Lorem.Words(4)", "Legros, Schumm and Spinka", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 86, "Faker.Lorem.Words(4)", "Kuhic, Jacobs and Wyman", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 87, "Faker.Lorem.Words(4)", "Bednar, Purdy and Hudson", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 88, "Faker.Lorem.Words(4)", "Schmidt-Hackett", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 89, "Faker.Lorem.Words(4)", "Schneider-Lowe", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 90, "Faker.Lorem.Words(4)", "Cruickshank Group", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 91, "Faker.Lorem.Words(4)", "Bergnaum-Littel", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 92, "Faker.Lorem.Words(4)", "Fahey LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 93, "Faker.Lorem.Words(4)", "Kris LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 94, "Faker.Lorem.Words(4)", "King-Schultz", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 95, "Faker.Lorem.Words(4)", "Ebert LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 96, "Faker.Lorem.Words(4)", "Swaniawski-Moen", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 97, "Faker.Lorem.Words(4)", "Price LLC", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 98, "Faker.Lorem.Words(4)", "DuBuque, Casper and Swaniawski", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" },
                    { 99, "Faker.Lorem.Words(4)", "Yundt Inc and Sons", "Faker.Lorem.Words(4)", "Faker.Lorem.Words(4)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 99);

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "MusicType", "Name", "PartOfTown", "StoreType" },
                values: new object[,]
                {
                    { 1, "various, singer-songwriter, guitar-bass-drums", "doug fir lounge", "e, east", "music venue" },
                    { 2, "various, salsa, timba, singer-songwriter, guitar-bass-drums", "mississippi pizza", "ne, northeast", "pizza restaurant, music venue" },
                    { 3, "various, funk, salsa, guitar-bass-drums", "the goodfoot", "ne, northeast", "bar, music venue" },
                    { 4, "jazz", "the 1905", "ne, northeast", "bar, pizza, music venue" }
                });
        }
    }
}
