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
                    { 1, "BMW", 595.0, 44679, "6216 IS-6", 6, "Repair" },
                    { 2, "BMW", 918.0, 57996, "4530 DP-5", 6, "Repair" },
                    { 3, "Volvo", 308.0, 72369, "1930 FA-4", 3, "Busy" },
                    { 4, "Mercedes", 526.0, 50651, "8504 SG-5", 2, "Repair" },
                    { 5, "Audi", 629.0, 79539, "7259 YR-4", 5, "Busy" },
                    { 6, "Audi", 538.0, 22005, "6173 ZG-2", 4, "Repair" },
                    { 7, "Audi", 503.0, 73253, "9780 GZ-1", 5, "Repair" },
                    { 8, "Mercedes", 178.0, 39563, "1757 PF-4", 2, "Busy" },
                    { 9, "Mercedes", 872.0, 42919, "1085 JJ-2", 3, "Busy" },
                    { 10, "Audi", 447.0, 51686, "3233 BX-2", 3, "Busy" },
                    { 11, "Mercedes", 513.0, 35069, "8102 EI-2", 2, "Busy" },
                    { 12, "BMW", 188.0, 84195, "5657 ZH-3", 4, "Available" },
                    { 13, "Mercedes", 920.0, 55916, "7107 WA-3", 8, "Repair" },
                    { 14, "Audi", 117.0, 82842, "9156 RI-6", 7, "Available" },
                    { 15, "Audi", 146.0, 92487, "3723 DT-3", 4, "Busy" },
                    { 16, "Toyota", 989.0, 13286, "7606 DR-6", 7, "Available" },
                    { 17, "Mercedes", 492.0, 78622, "7912 QL-1", 3, "Repair" },
                    { 18, "Volvo", 555.0, 86270, "4698 VJ-6", 8, "Available" },
                    { 19, "BMW", 373.0, 11357, "6029 ZY-6", 3, "Available" },
                    { 20, "Audi", 811.0, 31207, "6144 WY-5", 5, "Busy" },
                    { 21, "Volvo", 571.0, 45096, "8070 VY-6", 6, "Busy" },
                    { 22, "BMW", 179.0, 67446, "7623 ZO-1", 4, "Repair" },
                    { 23, "Toyota", 460.0, 98829, "2679 IW-4", 8, "Available" },
                    { 24, "Toyota", 892.0, 7126, "5007 SN-5", 4, "Busy" },
                    { 25, "BMW", 202.0, 48416, "5542 BY-6", 6, "Busy" },
                    { 26, "Volvo", 111.0, 66525, "6762 AK-4", 4, "Repair" },
                    { 27, "Toyota", 256.0, 75541, "4831 SO-5", 5, "Repair" },
                    { 28, "Toyota", 805.0, 4884, "3451 IQ-4", 8, "Repair" },
                    { 29, "Toyota", 618.0, 71078, "6896 FX-3", 7, "Busy" },
                    { 30, "Volvo", 997.0, 33043, "9630 PU-5", 6, "Repair" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Name", "PassportDetails", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "97 Ninth Street, Lakeview", "John Brown", "HH6177350", "+375 29 7229503" },
                    { 2, "50 Lakeview Drive, Lexington", "Matthew Clark", "UK5930116", "+375 33 7084024" },
                    { 3, "97 Eighth Street, Townville", "Linda Miller", "KK7039373", "+375 33 4646062" },
                    { 4, "92 Eighth Street, Springfield", "Margaret Walker", "AQ5318582", "+375 25 1272502" },
                    { 5, "68 River Road, Northfield", "Charles Jackson", "ZS7662736", "+375 44 5294252" },
                    { 6, "94 Central Avenue, Township", "Matthew Hall", "QW8158281", "+375 44 7937687" },
                    { 7, "10 Elm Street, Eastwood", "Barbara Lee", "YS3278643", "+375 29 8747964" },
                    { 8, "93 Tenth Street, Springfield", "Maria Allen", "EB6781365", "+375 44 3087871" },
                    { 9, "59 Washington Avenue, Suburbia", "Linda Miller", "TI8413589", "+375 25 5076646" },
                    { 10, "36 Tenth Street, Springfield", "Elizabeth Thompson", "QI7420873", "+375 29 1946349" },
                    { 11, "23 Washington Avenue, Oakwood", "Jessica Miller", "GH2632456", "+375 33 7215455" },
                    { 12, "25 School Lane, Fairview", "Margaret Walker", "SV4595641", "+375 25 8264964" },
                    { 13, "21 Baker Street, Evergreen", "Robert Anderson", "JH8905517", "+375 33 7138300" },
                    { 14, "5 Sunset Boulevard, Villageville", "Sarah Smith", "OR4982548", "+375 33 1684760" },
                    { 15, "34 Central Avenue, Southfield", "Charles Thomas", "RF1521280", "+375 44 5437571" },
                    { 16, "14 River Road, Valleyview", "Susan Young", "UV2449492", "+375 232 7385583" },
                    { 17, "56 Maple Street, Suburbia", "Andrew Anderson", "HK7244740", "+375 232 7002906" },
                    { 18, "21 Fifth Street, Lexington", "Andrew Allen", "WI2566590", "+375 33 2410536" },
                    { 19, "99 Cedar Street, Harbor City", "Anthony Davis", "SB6107658", "+375 44 3643747" },
                    { 20, "76 Sixth Street, Harbor City", "Maria Young", "FM5409031", "+375 25 4350149" },
                    { 21, "73 Oak Street, Eastwood", "Maria Wilson", "NI1726114", "+375 44 8625681" },
                    { 22, "43 Fifth Street, Fairview", "Thomas Harris", "BB2680773", "+375 29 8934872" },
                    { 23, "62 Broadway, Maplewood", "Elizabeth Miller", "DJ1290611", "+375 33 1640028" },
                    { 24, "89 Sunset Boulevard, Mountainview", "John Lewis", "IU1969560", "+375 29 5362412" },
                    { 25, "14 First Street, Townville", "Margaret Wilson", "VX6584632", "+375 44 9540160" },
                    { 26, "29 School Lane, Harbor City", "Patricia White", "NT7748872", "+375 44 8303963" },
                    { 27, "52 River Road, Hillcrest", "William Taylor", "GC6456631", "+375 232 6630318" },
                    { 28, "45 Oak Street, Valleyview", "William Allen", "WL6816454", "+375 232 6756375" },
                    { 29, "4 Sixth Street, Northfield", "Michael White", "LF9444229", "+375 44 1083752" },
                    { 30, "22 Second Street, Cedarville", "James Allen", "QG4134025", "+375 33 3282386" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CarId", "CustomerId", "Deadline", "HireHours", "OrderDate", "OrderNumber" },
                values: new object[,]
                {
                    { 1, null, 13, 19, new DateTime(2014, 10, 28, 3, 15, 0, 0, DateTimeKind.Unspecified), 19, new DateTime(2014, 10, 27, 8, 15, 0, 0, DateTimeKind.Unspecified), 70356 },
                    { 2, null, 26, 29, new DateTime(2018, 4, 23, 19, 1, 0, 0, DateTimeKind.Unspecified), 44, new DateTime(2018, 4, 21, 23, 1, 0, 0, DateTimeKind.Unspecified), 16887 },
                    { 3, null, 1, 2, new DateTime(2021, 5, 31, 17, 6, 0, 0, DateTimeKind.Unspecified), 126, new DateTime(2021, 5, 26, 11, 6, 0, 0, DateTimeKind.Unspecified), 27430 },
                    { 4, null, 13, 7, new DateTime(2011, 12, 6, 18, 21, 0, 0, DateTimeKind.Unspecified), 59, new DateTime(2011, 12, 4, 7, 21, 0, 0, DateTimeKind.Unspecified), 50601 },
                    { 5, null, 10, 3, new DateTime(2023, 5, 30, 20, 11, 0, 0, DateTimeKind.Unspecified), 153, new DateTime(2023, 5, 24, 11, 11, 0, 0, DateTimeKind.Unspecified), 48006 },
                    { 6, null, 11, 15, new DateTime(2018, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified), 44, new DateTime(2018, 10, 5, 19, 44, 0, 0, DateTimeKind.Unspecified), 57287 },
                    { 7, null, 13, 5, new DateTime(2024, 2, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 166, new DateTime(2024, 1, 26, 13, 7, 0, 0, DateTimeKind.Unspecified), 30214 },
                    { 8, null, 22, 27, new DateTime(2021, 1, 22, 4, 47, 0, 0, DateTimeKind.Unspecified), 107, new DateTime(2021, 1, 17, 17, 47, 0, 0, DateTimeKind.Unspecified), 94030 },
                    { 9, null, 10, 11, new DateTime(2018, 7, 11, 5, 51, 0, 0, DateTimeKind.Unspecified), 160, new DateTime(2018, 7, 4, 13, 51, 0, 0, DateTimeKind.Unspecified), 16360 },
                    { 10, null, 15, 29, new DateTime(2004, 12, 20, 21, 27, 0, 0, DateTimeKind.Unspecified), 27, new DateTime(2004, 12, 19, 18, 27, 0, 0, DateTimeKind.Unspecified), 50077 },
                    { 11, null, 7, 12, new DateTime(2009, 5, 7, 18, 57, 0, 0, DateTimeKind.Unspecified), 82, new DateTime(2009, 5, 4, 8, 57, 0, 0, DateTimeKind.Unspecified), 11626 },
                    { 12, null, 10, 12, new DateTime(2023, 11, 30, 15, 47, 0, 0, DateTimeKind.Unspecified), 150, new DateTime(2023, 11, 24, 9, 47, 0, 0, DateTimeKind.Unspecified), 84623 },
                    { 13, null, 23, 22, new DateTime(2006, 12, 15, 7, 6, 0, 0, DateTimeKind.Unspecified), 36, new DateTime(2006, 12, 13, 19, 6, 0, 0, DateTimeKind.Unspecified), 50985 },
                    { 14, null, 18, 17, new DateTime(2015, 10, 28, 17, 39, 0, 0, DateTimeKind.Unspecified), 69, new DateTime(2015, 10, 25, 20, 39, 0, 0, DateTimeKind.Unspecified), 80068 },
                    { 15, null, 6, 23, new DateTime(2003, 10, 24, 0, 20, 0, 0, DateTimeKind.Unspecified), 79, new DateTime(2003, 10, 20, 17, 20, 0, 0, DateTimeKind.Unspecified), 40381 },
                    { 16, null, 15, 21, new DateTime(2019, 10, 7, 1, 11, 0, 0, DateTimeKind.Unspecified), 135, new DateTime(2019, 10, 1, 10, 11, 0, 0, DateTimeKind.Unspecified), 92551 },
                    { 17, null, 12, 8, new DateTime(2002, 1, 9, 9, 17, 0, 0, DateTimeKind.Unspecified), 66, new DateTime(2002, 1, 6, 15, 17, 0, 0, DateTimeKind.Unspecified), 10458 },
                    { 18, null, 23, 18, new DateTime(2004, 2, 4, 13, 47, 0, 0, DateTimeKind.Unspecified), 164, new DateTime(2004, 1, 28, 17, 47, 0, 0, DateTimeKind.Unspecified), 88809 },
                    { 19, null, 26, 6, new DateTime(2016, 11, 17, 21, 46, 0, 0, DateTimeKind.Unspecified), 135, new DateTime(2016, 11, 12, 6, 46, 0, 0, DateTimeKind.Unspecified), 43963 },
                    { 20, null, 12, 13, new DateTime(2018, 6, 7, 7, 32, 0, 0, DateTimeKind.Unspecified), 119, new DateTime(2018, 6, 2, 8, 32, 0, 0, DateTimeKind.Unspecified), 89578 },
                    { 21, null, 27, 18, new DateTime(2020, 5, 6, 10, 4, 0, 0, DateTimeKind.Unspecified), 46, new DateTime(2020, 5, 4, 12, 4, 0, 0, DateTimeKind.Unspecified), 95219 },
                    { 22, null, 29, 14, new DateTime(2015, 11, 27, 8, 59, 0, 0, DateTimeKind.Unspecified), 36, new DateTime(2015, 11, 25, 20, 59, 0, 0, DateTimeKind.Unspecified), 43114 },
                    { 23, null, 1, 7, new DateTime(2010, 4, 8, 21, 54, 0, 0, DateTimeKind.Unspecified), 51, new DateTime(2010, 4, 6, 18, 54, 0, 0, DateTimeKind.Unspecified), 93173 },
                    { 24, null, 20, 18, new DateTime(2002, 10, 21, 11, 13, 0, 0, DateTimeKind.Unspecified), 111, new DateTime(2002, 10, 16, 20, 13, 0, 0, DateTimeKind.Unspecified), 16009 },
                    { 25, null, 29, 13, new DateTime(2016, 3, 4, 16, 59, 0, 0, DateTimeKind.Unspecified), 19, new DateTime(2016, 3, 3, 21, 59, 0, 0, DateTimeKind.Unspecified), 67188 },
                    { 26, null, 7, 13, new DateTime(2021, 12, 10, 4, 27, 0, 0, DateTimeKind.Unspecified), 110, new DateTime(2021, 12, 5, 14, 27, 0, 0, DateTimeKind.Unspecified), 37464 },
                    { 27, null, 21, 24, new DateTime(2013, 11, 29, 12, 15, 0, 0, DateTimeKind.Unspecified), 116, new DateTime(2013, 11, 24, 16, 15, 0, 0, DateTimeKind.Unspecified), 66590 },
                    { 28, null, 17, 25, new DateTime(2018, 12, 20, 5, 30, 0, 0, DateTimeKind.Unspecified), 166, new DateTime(2018, 12, 13, 7, 30, 0, 0, DateTimeKind.Unspecified), 21789 },
                    { 29, null, 11, 19, new DateTime(2000, 11, 10, 9, 23, 0, 0, DateTimeKind.Unspecified), 77, new DateTime(2000, 11, 7, 4, 23, 0, 0, DateTimeKind.Unspecified), 96391 },
                    { 30, null, 8, 23, new DateTime(2013, 1, 10, 7, 1, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2013, 1, 6, 1, 1, 0, 0, DateTimeKind.Unspecified), 23958 },
                    { 31, null, 23, 6, new DateTime(2020, 4, 18, 1, 33, 0, 0, DateTimeKind.Unspecified), 117, new DateTime(2020, 4, 13, 4, 33, 0, 0, DateTimeKind.Unspecified), 95730 },
                    { 32, null, 10, 5, new DateTime(2007, 1, 23, 14, 1, 0, 0, DateTimeKind.Unspecified), 47, new DateTime(2007, 1, 21, 15, 1, 0, 0, DateTimeKind.Unspecified), 99447 },
                    { 33, null, 7, 8, new DateTime(2000, 3, 15, 0, 41, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2000, 3, 14, 16, 41, 0, 0, DateTimeKind.Unspecified), 88797 },
                    { 34, null, 28, 2, new DateTime(2007, 11, 22, 13, 2, 0, 0, DateTimeKind.Unspecified), 107, new DateTime(2007, 11, 18, 2, 2, 0, 0, DateTimeKind.Unspecified), 58206 },
                    { 35, null, 3, 17, new DateTime(2021, 9, 14, 3, 33, 0, 0, DateTimeKind.Unspecified), 71, new DateTime(2021, 9, 11, 4, 33, 0, 0, DateTimeKind.Unspecified), 88203 },
                    { 36, null, 22, 29, new DateTime(2000, 8, 12, 13, 34, 0, 0, DateTimeKind.Unspecified), 97, new DateTime(2000, 8, 8, 12, 34, 0, 0, DateTimeKind.Unspecified), 61339 },
                    { 37, null, 3, 21, new DateTime(2000, 2, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 36, new DateTime(2000, 2, 1, 1, 10, 0, 0, DateTimeKind.Unspecified), 91599 },
                    { 38, null, 26, 21, new DateTime(2009, 3, 5, 9, 55, 0, 0, DateTimeKind.Unspecified), 24, new DateTime(2009, 3, 4, 9, 55, 0, 0, DateTimeKind.Unspecified), 29867 },
                    { 39, null, 29, 21, new DateTime(2010, 1, 12, 1, 29, 0, 0, DateTimeKind.Unspecified), 80, new DateTime(2010, 1, 8, 17, 29, 0, 0, DateTimeKind.Unspecified), 65483 },
                    { 40, null, 20, 27, new DateTime(2002, 8, 17, 11, 45, 0, 0, DateTimeKind.Unspecified), 89, new DateTime(2002, 8, 13, 18, 45, 0, 0, DateTimeKind.Unspecified), 18795 },
                    { 41, null, 18, 21, new DateTime(2016, 8, 30, 2, 27, 0, 0, DateTimeKind.Unspecified), 111, new DateTime(2016, 8, 25, 11, 27, 0, 0, DateTimeKind.Unspecified), 84945 },
                    { 42, null, 15, 6, new DateTime(2000, 11, 2, 8, 9, 0, 0, DateTimeKind.Unspecified), 108, new DateTime(2000, 10, 28, 20, 9, 0, 0, DateTimeKind.Unspecified), 34330 },
                    { 43, null, 8, 18, new DateTime(2002, 4, 4, 5, 27, 0, 0, DateTimeKind.Unspecified), 146, new DateTime(2002, 3, 29, 3, 27, 0, 0, DateTimeKind.Unspecified), 22364 },
                    { 44, null, 23, 14, new DateTime(2012, 12, 10, 10, 46, 0, 0, DateTimeKind.Unspecified), 40, new DateTime(2012, 12, 8, 18, 46, 0, 0, DateTimeKind.Unspecified), 67912 },
                    { 45, null, 3, 21, new DateTime(2023, 2, 26, 19, 28, 0, 0, DateTimeKind.Unspecified), 158, new DateTime(2023, 2, 20, 5, 28, 0, 0, DateTimeKind.Unspecified), 27058 },
                    { 46, null, 1, 4, new DateTime(2009, 4, 9, 4, 39, 0, 0, DateTimeKind.Unspecified), 147, new DateTime(2009, 4, 3, 1, 39, 0, 0, DateTimeKind.Unspecified), 46690 },
                    { 47, null, 29, 23, new DateTime(2019, 9, 26, 4, 6, 0, 0, DateTimeKind.Unspecified), 37, new DateTime(2019, 9, 24, 15, 6, 0, 0, DateTimeKind.Unspecified), 26816 },
                    { 48, null, 3, 11, new DateTime(2004, 3, 6, 0, 20, 0, 0, DateTimeKind.Unspecified), 143, new DateTime(2004, 2, 29, 1, 20, 0, 0, DateTimeKind.Unspecified), 30978 },
                    { 49, null, 2, 27, new DateTime(2023, 6, 15, 21, 44, 0, 0, DateTimeKind.Unspecified), 13, new DateTime(2023, 6, 15, 8, 44, 0, 0, DateTimeKind.Unspecified), 51436 },
                    { 50, null, 9, 4, new DateTime(2009, 12, 15, 20, 27, 0, 0, DateTimeKind.Unspecified), 69, new DateTime(2009, 12, 12, 23, 27, 0, 0, DateTimeKind.Unspecified), 93624 }
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
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 19);

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
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

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
                keyValue: 16);

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
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7);

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
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 18);

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
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

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
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

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
                keyValue: 17);

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
        }
    }
}
