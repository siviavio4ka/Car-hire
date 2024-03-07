using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_hire.API.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Brand", "HirePrice", "Mileage", "Number", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { 1, "Audi", 307.0, 95816, "7158 IK-6", 4, "Available" },
                    { 2, "Audi", 162.0, 8974, "3960 SG-2", 4, "Busy" },
                    { 3, "Audi", 885.0, 39424, "8925 HP-5", 8, "Available" },
                    { 4, "Mercedes", 509.0, 47012, "6531 QD-2", 5, "Repair" },
                    { 5, "Mercedes", 392.0, 44109, "9222 TB-1", 4, "Busy" },
                    { 6, "Mercedes", 695.0, 65583, "1291 SR-6", 9, "Repair" },
                    { 7, "Audi", 684.0, 7069, "2554 TL-5", 5, "Repair" },
                    { 8, "Volvo", 638.0, 95063, "9569 TM-2", 8, "Available" },
                    { 9, "BMW", 610.0, 98671, "2678 WG-6", 8, "Busy" },
                    { 10, "Volvo", 503.0, 68388, "7841 RP-3", 4, "Repair" },
                    { 11, "BMW", 643.0, 94739, "7254 SW-6", 4, "Repair" },
                    { 12, "Audi", 136.0, 19914, "9332 ZK-3", 7, "Repair" },
                    { 13, "BMW", 947.0, 52161, "9900 TU-1", 4, "Repair" },
                    { 14, "Mercedes", 327.0, 93601, "4805 QU-6", 3, "Repair" },
                    { 15, "Audi", 408.0, 37206, "5362 OJ-6", 7, "Available" },
                    { 16, "Audi", 186.0, 48083, "5038 XA-1", 9, "Busy" },
                    { 17, "Audi", 210.0, 50288, "2717 YZ-6", 9, "Repair" },
                    { 18, "Audi", 147.0, 16525, "2926 ZF-6", 2, "Repair" },
                    { 19, "BMW", 413.0, 86469, "1073 FU-5", 4, "Available" },
                    { 20, "BMW", 703.0, 28231, "3477 AB-2", 9, "Repair" },
                    { 21, "Audi", 671.0, 37990, "2627 UB-6", 3, "Repair" },
                    { 22, "Mercedes", 444.0, 55491, "8305 AV-4", 5, "Repair" },
                    { 23, "Mercedes", 235.0, 99620, "2101 VL-6", 2, "Busy" },
                    { 24, "Toyota", 568.0, 1056, "9766 MN-4", 9, "Busy" },
                    { 25, "Volvo", 372.0, 359, "4519 JY-3", 3, "Busy" },
                    { 26, "Audi", 951.0, 19461, "2458 FE-2", 9, "Repair" },
                    { 27, "BMW", 746.0, 49875, "9361 ZK-2", 2, "Repair" },
                    { 28, "Mercedes", 580.0, 49196, "2693 ZX-1", 4, "Busy" },
                    { 29, "Mercedes", 893.0, 64353, "3704 WU-1", 3, "Repair" },
                    { 30, "Audi", 958.0, 13831, "2666 XM-2", 9, "Repair" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "DriverLicenceNumber", "Name", "PassportDetails", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "44 Cedar Street, Westminster", 911066353, "Linda, Lewis", "FE3005840", "+375 29 4996787" },
                    { 2, "39 High Street, Bayview", 599196788, "James, Clark", "IR7607639", "+375 25 9491008" },
                    { 3, "62 Green Avenue, Maplewood", 583456215, "Emily, Young", "VR5052469", "+375 33 4872845" },
                    { 4, "30 Fifth Street, Mountainview", 862770818, "Susan, Walker", "OJ4934713", "+375 25 5207736" },
                    { 5, "16 Fourth Street, Villageville", 127856558, "James, Hall", "PG9900460", "+375 232 6374803" },
                    { 6, "33 Baker Street, Cityville", 752474147, "Alice, Martinez", "OS5133450", "+375 29 8816358" },
                    { 7, "37 Washington Avenue, Fairview", 148897718, "Mary, Wright", "XK1846059", "+375 44 8228807" },
                    { 8, "51 Baker Street, Mountainview", 105798663, "Robert, Wilson", "QB5463078", "+375 232 7204345" },
                    { 9, "4 Main Street, Lakeview", 609319106, "Elizabeth, Lewis", "FQ8216649", "+375 33 3010027" },
                    { 10, "33 Elm Street, Riverside", 512826692, "Anthony, Harris", "BI9671605", "+375 29 7136996" },
                    { 11, "66 High Street, Metropolis", 292696365, "Patricia, Hall", "SV6971714", "+375 44 7127844" },
                    { 12, "59 Pine Street, Villageville", 263918006, "Jane, Hall", "FS1094292", "+375 33 7637965" },
                    { 13, "83 Fifth Street, Metropolis", 138424899, "Matthew, Moore", "VO2959692", "+375 33 4864766" },
                    { 14, "12 Second Street, Countyville", 828331477, "Daniel, Lewis", "NV6854389", "+375 232 8737495" },
                    { 15, "66 High Street, Maplewood", 278687645, "Jessica, Harris", "IH7658021", "+375 33 1799369" },
                    { 16, "31 Green Avenue, Oakwood", 121322673, "Jessica, Anderson", "BT6449859", "+375 44 2949074" },
                    { 17, "3 Park Avenue, Hillcrest", 397674501, "Mary, Robinson", "QF4424477", "+375 29 6022740" },
                    { 18, "70 Central Avenue, Township", 858706059, "Robert, Lewis", "FD7221629", "+375 44 7645309" },
                    { 19, "13 Pine Street, Valleyview", 205207721, "Elizabeth, Smith", "QI7062390", "+375 29 1225857" },
                    { 20, "8 First Street, Cityville", 438920826, "Charles, Rodriguez", "CM9641552", "+375 232 4643646" },
                    { 21, "80 Green Avenue, Evergreen", 678809728, "Andrew, Martin", "RU2114540", "+375 29 2803896" },
                    { 22, "72 Park Avenue, Cedarville", 153653941, "Sarah, Miller", "RW7388145", "+375 33 8387746" },
                    { 23, "38 Pine Street, Mountainview", 535453549, "Patricia, Jackson", "LC7353554", "+375 25 2451088" },
                    { 24, "83 High Street, Villageton", 143466410, "Maria, Garcia", "IN5299436", "+375 25 6940560" },
                    { 25, "85 Fourth Street, Smalltown", 658223022, "Robert, Garcia", "RC5424479", "+375 29 1078092" },
                    { 26, "19 Lakeview Drive, Springfield", 239435885, "Jennifer, Thomas", "WH4678299", "+375 33 1592437" },
                    { 27, "62 School Lane, Riverside", 428732781, "James, Young", "EH6585166", "+375 232 4952963" },
                    { 28, "82 Washington Avenue, Smalltown", 789668484, "Jessica, Anderson", "BI5500670", "+375 33 9940327" },
                    { 29, "18 Victory Street, Countyville", 810042737, "Mary, Lee", "YD4756283", "+375 232 4334350" },
                    { 30, "2 Baker Street, Hillcrest", 170098284, "Robert, Taylor", "WH2417242", "+375 25 3945086" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Name" },
                values: new object[,]
                {
                    { 1, "Margaret, Robinson" },
                    { 2, "Linda, Brown" },
                    { 3, "Thomas, Taylor" },
                    { 4, "James, Williams" },
                    { 5, "Susan, Thomas" },
                    { 6, "Bob, King" },
                    { 7, "James, Brown" },
                    { 8, "Maria, Garcia" },
                    { 9, "Matthew, Wilson" },
                    { 10, "Jessica, Moore" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CarId", "CustomerId", "Deadline", "EmployeeId", "HireHours", "OrderDate", "OrderNumber" },
                values: new object[,]
                {
                    { 1, null, 22, 23, new DateTime(2023, 10, 15, 9, 40, 0, 0, DateTimeKind.Unspecified), 1, 139, new DateTime(2023, 10, 9, 14, 40, 0, 0, DateTimeKind.Unspecified), 94548 },
                    { 2, null, 23, 5, new DateTime(2001, 12, 8, 6, 17, 0, 0, DateTimeKind.Unspecified), 2, 63, new DateTime(2001, 12, 5, 15, 17, 0, 0, DateTimeKind.Unspecified), 81802 },
                    { 3, null, 3, 16, new DateTime(2011, 9, 16, 12, 35, 0, 0, DateTimeKind.Unspecified), 5, 51, new DateTime(2011, 9, 14, 9, 35, 0, 0, DateTimeKind.Unspecified), 25705 },
                    { 4, null, 16, 19, new DateTime(2006, 6, 23, 21, 38, 0, 0, DateTimeKind.Unspecified), 8, 42, new DateTime(2006, 6, 22, 3, 38, 0, 0, DateTimeKind.Unspecified), 79010 },
                    { 5, null, 8, 23, new DateTime(2000, 11, 19, 22, 37, 0, 0, DateTimeKind.Unspecified), 2, 19, new DateTime(2000, 11, 19, 3, 37, 0, 0, DateTimeKind.Unspecified), 99148 },
                    { 6, null, 17, 25, new DateTime(2017, 9, 6, 17, 8, 0, 0, DateTimeKind.Unspecified), 2, 156, new DateTime(2017, 8, 31, 5, 8, 0, 0, DateTimeKind.Unspecified), 52466 },
                    { 7, null, 3, 25, new DateTime(2021, 7, 19, 15, 20, 0, 0, DateTimeKind.Unspecified), 9, 72, new DateTime(2021, 7, 16, 15, 20, 0, 0, DateTimeKind.Unspecified), 19262 },
                    { 8, null, 6, 27, new DateTime(2018, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 4, 130, new DateTime(2018, 7, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 82577 },
                    { 9, null, 25, 9, new DateTime(2004, 8, 7, 5, 49, 0, 0, DateTimeKind.Unspecified), 8, 110, new DateTime(2004, 8, 2, 15, 49, 0, 0, DateTimeKind.Unspecified), 77272 },
                    { 10, null, 27, 22, new DateTime(2001, 4, 16, 9, 58, 0, 0, DateTimeKind.Unspecified), 1, 6, new DateTime(2001, 4, 16, 3, 58, 0, 0, DateTimeKind.Unspecified), 16309 },
                    { 11, null, 10, 23, new DateTime(2003, 5, 9, 19, 11, 0, 0, DateTimeKind.Unspecified), 1, 124, new DateTime(2003, 5, 4, 15, 11, 0, 0, DateTimeKind.Unspecified), 73854 },
                    { 12, null, 21, 29, new DateTime(2002, 2, 5, 21, 9, 0, 0, DateTimeKind.Unspecified), 5, 126, new DateTime(2002, 1, 31, 15, 9, 0, 0, DateTimeKind.Unspecified), 38651 },
                    { 13, null, 19, 5, new DateTime(2019, 6, 23, 22, 4, 0, 0, DateTimeKind.Unspecified), 9, 7, new DateTime(2019, 6, 23, 15, 4, 0, 0, DateTimeKind.Unspecified), 14542 },
                    { 14, null, 24, 4, new DateTime(2013, 2, 22, 17, 50, 0, 0, DateTimeKind.Unspecified), 7, 143, new DateTime(2013, 2, 16, 18, 50, 0, 0, DateTimeKind.Unspecified), 78954 },
                    { 15, null, 12, 16, new DateTime(2021, 3, 24, 16, 2, 0, 0, DateTimeKind.Unspecified), 9, 109, new DateTime(2021, 3, 20, 3, 2, 0, 0, DateTimeKind.Unspecified), 30140 },
                    { 16, null, 14, 25, new DateTime(2017, 8, 12, 4, 40, 0, 0, DateTimeKind.Unspecified), 6, 50, new DateTime(2017, 8, 10, 2, 40, 0, 0, DateTimeKind.Unspecified), 85667 },
                    { 17, null, 25, 9, new DateTime(2013, 11, 4, 18, 8, 0, 0, DateTimeKind.Unspecified), 9, 85, new DateTime(2013, 11, 1, 5, 8, 0, 0, DateTimeKind.Unspecified), 88264 },
                    { 18, null, 16, 14, new DateTime(2013, 3, 6, 17, 59, 0, 0, DateTimeKind.Unspecified), 4, 8, new DateTime(2013, 3, 6, 9, 59, 0, 0, DateTimeKind.Unspecified), 96028 },
                    { 19, null, 11, 6, new DateTime(2014, 10, 19, 3, 58, 0, 0, DateTimeKind.Unspecified), 7, 86, new DateTime(2014, 10, 15, 13, 58, 0, 0, DateTimeKind.Unspecified), 23210 },
                    { 20, null, 17, 5, new DateTime(2013, 8, 26, 16, 43, 0, 0, DateTimeKind.Unspecified), 7, 100, new DateTime(2013, 8, 22, 12, 43, 0, 0, DateTimeKind.Unspecified), 24161 },
                    { 21, null, 3, 18, new DateTime(2001, 4, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 5, 45, new DateTime(2001, 3, 30, 15, 3, 0, 0, DateTimeKind.Unspecified), 47220 },
                    { 22, null, 2, 6, new DateTime(2018, 12, 26, 11, 31, 0, 0, DateTimeKind.Unspecified), 8, 112, new DateTime(2018, 12, 21, 19, 31, 0, 0, DateTimeKind.Unspecified), 26784 },
                    { 23, null, 12, 6, new DateTime(2002, 8, 3, 4, 34, 0, 0, DateTimeKind.Unspecified), 4, 53, new DateTime(2002, 7, 31, 23, 34, 0, 0, DateTimeKind.Unspecified), 61734 },
                    { 24, null, 8, 4, new DateTime(2023, 6, 10, 15, 18, 0, 0, DateTimeKind.Unspecified), 1, 101, new DateTime(2023, 6, 6, 10, 18, 0, 0, DateTimeKind.Unspecified), 95854 },
                    { 25, null, 6, 15, new DateTime(2004, 4, 27, 13, 58, 0, 0, DateTimeKind.Unspecified), 8, 82, new DateTime(2004, 4, 24, 3, 58, 0, 0, DateTimeKind.Unspecified), 80848 },
                    { 26, null, 13, 21, new DateTime(2007, 10, 24, 10, 42, 0, 0, DateTimeKind.Unspecified), 1, 124, new DateTime(2007, 10, 19, 6, 42, 0, 0, DateTimeKind.Unspecified), 12926 },
                    { 27, null, 21, 21, new DateTime(2024, 2, 9, 7, 53, 0, 0, DateTimeKind.Unspecified), 8, 66, new DateTime(2024, 2, 6, 13, 53, 0, 0, DateTimeKind.Unspecified), 98732 },
                    { 28, null, 21, 13, new DateTime(2019, 6, 16, 8, 45, 0, 0, DateTimeKind.Unspecified), 6, 163, new DateTime(2019, 6, 9, 13, 45, 0, 0, DateTimeKind.Unspecified), 87549 },
                    { 29, null, 1, 21, new DateTime(2013, 2, 21, 17, 47, 0, 0, DateTimeKind.Unspecified), 9, 11, new DateTime(2013, 2, 21, 6, 47, 0, 0, DateTimeKind.Unspecified), 70383 },
                    { 30, null, 23, 15, new DateTime(2018, 9, 1, 6, 13, 0, 0, DateTimeKind.Unspecified), 7, 4, new DateTime(2018, 9, 1, 2, 13, 0, 0, DateTimeKind.Unspecified), 26124 },
                    { 31, null, 24, 11, new DateTime(2012, 9, 4, 12, 17, 0, 0, DateTimeKind.Unspecified), 6, 136, new DateTime(2012, 8, 29, 20, 17, 0, 0, DateTimeKind.Unspecified), 93175 },
                    { 32, null, 5, 21, new DateTime(2019, 3, 6, 14, 18, 0, 0, DateTimeKind.Unspecified), 3, 36, new DateTime(2019, 3, 5, 2, 18, 0, 0, DateTimeKind.Unspecified), 47129 },
                    { 33, null, 4, 23, new DateTime(2023, 3, 30, 18, 57, 0, 0, DateTimeKind.Unspecified), 1, 52, new DateTime(2023, 3, 28, 14, 57, 0, 0, DateTimeKind.Unspecified), 42698 },
                    { 34, null, 16, 13, new DateTime(2013, 9, 26, 5, 51, 0, 0, DateTimeKind.Unspecified), 5, 30, new DateTime(2013, 9, 24, 23, 51, 0, 0, DateTimeKind.Unspecified), 63479 },
                    { 35, null, 13, 16, new DateTime(2004, 4, 9, 18, 48, 0, 0, DateTimeKind.Unspecified), 4, 143, new DateTime(2004, 4, 3, 19, 48, 0, 0, DateTimeKind.Unspecified), 38014 },
                    { 36, null, 13, 6, new DateTime(2015, 6, 4, 3, 17, 0, 0, DateTimeKind.Unspecified), 3, 29, new DateTime(2015, 6, 2, 22, 17, 0, 0, DateTimeKind.Unspecified), 79835 },
                    { 37, null, 8, 19, new DateTime(2018, 1, 7, 23, 23, 0, 0, DateTimeKind.Unspecified), 1, 92, new DateTime(2018, 1, 4, 3, 23, 0, 0, DateTimeKind.Unspecified), 85011 },
                    { 38, null, 28, 18, new DateTime(2023, 1, 28, 23, 42, 0, 0, DateTimeKind.Unspecified), 4, 133, new DateTime(2023, 1, 23, 10, 42, 0, 0, DateTimeKind.Unspecified), 82739 },
                    { 39, null, 26, 7, new DateTime(2008, 1, 2, 0, 42, 0, 0, DateTimeKind.Unspecified), 7, 41, new DateTime(2007, 12, 31, 7, 42, 0, 0, DateTimeKind.Unspecified), 32781 },
                    { 40, null, 14, 23, new DateTime(2002, 9, 10, 15, 49, 0, 0, DateTimeKind.Unspecified), 1, 29, new DateTime(2002, 9, 9, 10, 49, 0, 0, DateTimeKind.Unspecified), 16079 },
                    { 41, null, 4, 15, new DateTime(2004, 7, 12, 6, 46, 0, 0, DateTimeKind.Unspecified), 2, 59, new DateTime(2004, 7, 9, 19, 46, 0, 0, DateTimeKind.Unspecified), 17020 },
                    { 42, null, 9, 8, new DateTime(2002, 11, 23, 15, 15, 0, 0, DateTimeKind.Unspecified), 9, 88, new DateTime(2002, 11, 19, 23, 15, 0, 0, DateTimeKind.Unspecified), 51526 },
                    { 43, null, 16, 21, new DateTime(2022, 1, 13, 10, 21, 0, 0, DateTimeKind.Unspecified), 3, 67, new DateTime(2022, 1, 10, 15, 21, 0, 0, DateTimeKind.Unspecified), 58716 },
                    { 44, null, 20, 24, new DateTime(2015, 5, 13, 10, 20, 0, 0, DateTimeKind.Unspecified), 5, 84, new DateTime(2015, 5, 9, 22, 20, 0, 0, DateTimeKind.Unspecified), 71255 },
                    { 45, null, 25, 7, new DateTime(2009, 11, 4, 17, 5, 0, 0, DateTimeKind.Unspecified), 1, 50, new DateTime(2009, 11, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 98318 },
                    { 46, null, 1, 22, new DateTime(2022, 11, 13, 21, 46, 0, 0, DateTimeKind.Unspecified), 4, 1, new DateTime(2022, 11, 13, 20, 46, 0, 0, DateTimeKind.Unspecified), 97851 },
                    { 47, null, 12, 10, new DateTime(2007, 3, 13, 0, 47, 0, 0, DateTimeKind.Unspecified), 8, 164, new DateTime(2007, 3, 6, 4, 47, 0, 0, DateTimeKind.Unspecified), 65261 },
                    { 48, null, 6, 27, new DateTime(2009, 11, 15, 23, 28, 0, 0, DateTimeKind.Unspecified), 7, 136, new DateTime(2009, 11, 10, 7, 28, 0, 0, DateTimeKind.Unspecified), 22342 },
                    { 49, null, 15, 3, new DateTime(2008, 7, 15, 13, 34, 0, 0, DateTimeKind.Unspecified), 2, 16, new DateTime(2008, 7, 14, 21, 34, 0, 0, DateTimeKind.Unspecified), 81257 },
                    { 50, null, 24, 15, new DateTime(2012, 3, 28, 14, 18, 0, 0, DateTimeKind.Unspecified), 7, 20, new DateTime(2012, 3, 27, 18, 18, 0, 0, DateTimeKind.Unspecified), 34369 }
                });

            migrationBuilder.Sql(@"
                UPDATE ""Orders"" AS O
                SET ""Amount"" = O.""HireHours"" * C.""HirePrice""
                FROM ""Cars"" AS C
                WHERE C.""CarId"" = O.""CarId"";");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);
        }
    }
}
