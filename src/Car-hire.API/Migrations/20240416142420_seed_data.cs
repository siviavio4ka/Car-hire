using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_hire.API.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Employee", "EMPLOYEE" },
                    { 3, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PassportDetails", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "83 Main Street, Valleyview", "764d249a-3547-44a9-a8d4-769e5583f929", "jessicarobinson27@gmail.com", false, true, null, "Jessica Robinson", "JESSICAROBINSON27@GMAIL.COM", "JESSICAROBINSON", "GK3441473", "AQAAAAIAAYagAAAAEGfK43MQp99+2IM7N+BbS9/miMiYRzYRQE1R65FDhjBtTU18mjT0aRl6McOnkTpaUQ==", "+375 25 9940988", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948531b-9eac-44d7-97d6-9a222643c408", false, "jessicarobinson" },
                    { 2, 0, "20 Victory Street, Mountainview", "1c608374-b642-420f-a218-b9a26a43e429", "elizabethjohnson23@gmail.com", false, true, null, "Elizabeth Johnson", "ELIZABETHJOHNSON23@GMAIL.COM", "ELIZABETHJOHNSON", "CZ4396094", "AQAAAAIAAYagAAAAEIqm50WtEAfNuBZS458qPq/SdgCu3OPTI9a4JW4ROKzYMkSV6pAtYiTuoukO5IDTXA==", "+375 33 2192065", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e3e145b3-8eb7-477c-a83e-1d703276f84e", false, "elizabethjohnson" },
                    { 3, 0, "36 Third Street, Cedarville", "1bd7dbb9-4996-4148-b25f-c8ef009acadc", "lindahernandez52@gmail.com", false, true, null, "Linda Hernandez", "LINDAHERNANDEZ52@GMAIL.COM", "LINDAHERNANDEZ", "HR4906410", "AQAAAAIAAYagAAAAELDifYncuwdxccgmLM3Ruf4iv0NTWvyxKihGgIyJKa82nGtfwsQs4uH4XU1c8MjJ+A==", "+375 25 7748313", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bc32ba8c-208c-430a-b7cf-2f752cd9dfcf", false, "lindahernandez" },
                    { 4, 0, "33 High Street, Countyville", "965892c8-8d99-4bee-89ed-2d49901e834d", "emilywhite67@gmail.com", false, true, null, "Emily White", "EMILYWHITE67@GMAIL.COM", "EMILYWHITE", "LE1854169", "AQAAAAIAAYagAAAAEKcozGudx7UkaUXuPAyzQ9pfq6eQtI3N2TI0xRjw9vIj43zBAGW0tLUJz6jEPGOYmA==", "+375 29 9497300", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "39308c10-9b23-4521-8701-84ef72ed89c6", false, "emilywhite" },
                    { 5, 0, "59 School Lane, Cityville", "a16bf260-e601-41b0-b84a-612ff142248b", "williamallen96@gmail.com", false, true, null, "William Allen", "WILLIAMALLEN96@GMAIL.COM", "WILLIAMALLEN", "DB9660635", "AQAAAAIAAYagAAAAEMQ/JbnytSm7yH1KolgWXzsA46RvMBXYIB/HY1J03vQ5dwvUMnxCiDUDY3nSupkmcg==", "+375 29 5196312", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5cc5945-9ebe-490a-93a2-385243ef7f6d", false, "williamallen" },
                    { 6, 0, "82 Ninth Street, Harbor City", "ef8b939f-25bf-4f9a-83aa-4776880323be", "jamesharris85@gmail.com", false, true, null, "James Harris", "JAMESHARRIS85@GMAIL.COM", "JAMESHARRIS", "NO9820984", "AQAAAAIAAYagAAAAEOX8Tu2kIpu1aZRnT+8QZ5gFCD6Dwgx4+zCBOC8ZNpGjAxRZL6VUBmyIfS74R5qnAw==", "+375 44 4112906", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa0fa76d-544a-4839-ad25-315cf5173254", false, "jamesharris" },
                    { 7, 0, "39 Seventh Street, Oakwood", "45f5f9a3-c7b6-491d-a275-636191014a2f", "jessicamoore61@gmail.com", false, true, null, "Jessica Moore", "JESSICAMOORE61@GMAIL.COM", "JESSICAMOORE", "ZI6418769", "AQAAAAIAAYagAAAAEGsrl3doljD4k8t3/sFfuC2Vwcg45o8sVMB0jfJYHlk3nqqk+Ux7hTl8ynZl3MeetQ==", "+375 33 5094352", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "46c59809-20fb-40bb-9413-ac3ed0bf149a", false, "jessicamoore" },
                    { 8, 0, "19 Maple Street, Suburbia", "6b8d1ab5-deb0-400c-a09b-5c270d628897", "josephrobinson28@gmail.com", false, true, null, "Joseph Robinson", "JOSEPHROBINSON28@GMAIL.COM", "JOSEPHROBINSON", "HQ9999956", "AQAAAAIAAYagAAAAEOfEkqNn5hQJG+y82rW4xfM2u93Z+MxAkUYWQb53Tu+rdy6cMvMxdS/xh0z/15lOjg==", "+375 33 3868869", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c4b242b1-b59f-4bd1-96b0-3824902edfff", false, "josephrobinson" },
                    { 9, 0, "79 Washington Avenue, Cedarville", "bd667d14-2be3-4915-bd63-c179777833d0", "alicehernandez38@gmail.com", false, true, null, "Alice Hernandez", "ALICEHERNANDEZ38@GMAIL.COM", "ALICEHERNANDEZ", "KL9612367", "AQAAAAIAAYagAAAAEBI8hVaiCidSmCUnUFJNbF9WGEEBMy8fvl3zo882O3LN+6n7vTPOCEDwbXyKwH9PfQ==", "+375 29 9239737", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a080244c-4c5d-4a6f-b680-cd00cdee3e08", false, "alicehernandez" },
                    { 10, 0, "76 Maple Street, Hillcrest", "1dbebfc3-69bb-4cfc-af52-29dde4de35d6", "elizabethsmith75@gmail.com", false, true, null, "Elizabeth Smith", "ELIZABETHSMITH75@GMAIL.COM", "ELIZABETHSMITH", "BF7568603", "AQAAAAIAAYagAAAAEDCzrZMPvwy9AGkfMFFq4Ush5JH8X+mMZiJ/QUMPwKE4+iEJjvR3l6Wjc+MzNAcpKg==", "+375 25 4003941", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "09756f6c-2a84-45e6-a0cb-348a710f7790", false, "elizabethsmith" },
                    { 11, 0, "13 Green Avenue, Townville", "c5ffa7ec-c701-49bf-8fe9-289265e41c92", "sarahlewis26@gmail.com", false, true, null, "Sarah Lewis", "SARAHLEWIS26@GMAIL.COM", "SARAHLEWIS", "ZM9943869", "AQAAAAIAAYagAAAAECo2qJ0T9/pwtMEeKTVJEdP99opVbxQmZ3ldahtdBiKKSqy6au+0/CNal0mLtUGhTg==", "+375 44 8640631", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e793ed23-0430-40db-9844-705df8ef35cb", false, "sarahlewis" },
                    { 12, 0, "70 Second Street, Mountainview", "85328b9b-a01a-42f9-bc9e-ad33b5286c6a", "margaretrodriguez85@gmail.com", false, true, null, "Margaret Rodriguez", "MARGARETRODRIGUEZ85@GMAIL.COM", "MARGARETRODRIGUEZ", "CF2512370", "AQAAAAIAAYagAAAAEFXeO/1/hKp9bGUTNCOnVzKErjOA+YJtY/Qcmk0kJi+/pM4OOApV0KibjHUwR5Vx1g==", "+375 33 5919956", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01ea46af-a05a-49d2-9c63-75b28fa11916", false, "margaretrodriguez" },
                    { 13, 0, "78 Elm Street, Villageton", "36574398-3b0c-43b1-ad38-bf4ed176d727", "emilyjackson92@gmail.com", false, true, null, "Emily Jackson", "EMILYJACKSON92@GMAIL.COM", "EMILYJACKSON", "NS8243805", "AQAAAAIAAYagAAAAEOSY3i8V4H/fMw4obPnkYG9cZQcDprNejNXA5YeZd0SimzC98KSAqcqGGqCs/6k8wQ==", "+375 232 8140139", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7cbeea3d-41dd-408b-bad9-65e0c6ec94e0", false, "emilyjackson" },
                    { 14, 0, "97 Sunset Boulevard, Oakwood", "b07ec692-f6dd-4318-a3e2-74a0bcc04a5f", "matthewhernandez13@gmail.com", false, true, null, "Matthew Hernandez", "MATTHEWHERNANDEZ13@GMAIL.COM", "MATTHEWHERNANDEZ", "IN1149139", "AQAAAAIAAYagAAAAELrka4DAQQruTnfGKWDGUgpypgo8DRa/76yQKkTWRQs4xgNOXXpY4q3R+9pjq0j6hw==", "+375 44 1456318", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c0ce6e3d-27d2-412b-ac18-30e437029e81", false, "matthewhernandez" },
                    { 15, 0, "85 Fifth Street, Valleyview", "a49d2816-df9f-4766-9772-4fb18f713d72", "aliceking24@gmail.com", false, true, null, "Alice King", "ALICEKING24@GMAIL.COM", "ALICEKING", "AO3207312", "AQAAAAIAAYagAAAAEODQ1/zg4jKoYmTidYV1GgPkz+Z69rbENMTsLbjhOvHWM/Ny2VcPuMAOHyGEZvdpZw==", "+375 232 7108006", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "39485b15-8bf9-4631-bf54-363a62ffc2e1", false, "aliceking" },
                    { 16, 0, "74 Third Street, Cedarville", "0923368e-e567-46e7-8120-345da37d6dca", "lindamartinez88@gmail.com", false, true, null, "Linda Martinez", "LINDAMARTINEZ88@GMAIL.COM", "LINDAMARTINEZ", "RZ4485121", "AQAAAAIAAYagAAAAEB+LwwJ9SaJ5tLgoq3oauEVT2nCWq4co1RuTC2DwRuYMb+ZJYE8yRy/C1hlpWMal7w==", "+375 232 9261368", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e38b625e-7d6d-4790-a5c1-376b23f07d00", false, "lindamartinez" },
                    { 17, 0, "88 Hillside Avenue, Villageville", "b0a8f9ff-5408-4e86-8b95-d30d8fa30742", "margaretlewis84@gmail.com", false, true, null, "Margaret Lewis", "MARGARETLEWIS84@GMAIL.COM", "MARGARETLEWIS", "ME2972187", "AQAAAAIAAYagAAAAEEzk9VUtwSOXz6SBU/XSdc1tTSLbBTCZUuyskDS+95BVegwqPhjIq+P/r8PAtWI1Qg==", "+375 25 6297265", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7789540a-171c-4397-9bb9-9c137ef070e2", false, "margaretlewis" },
                    { 18, 0, "5 Broadway, Northfield", "b23697fb-aa24-439c-820f-2aab5887b4ca", "janemartin11@gmail.com", false, true, null, "Jane Martin", "JANEMARTIN11@GMAIL.COM", "JANEMARTIN", "DC6553664", "AQAAAAIAAYagAAAAEGwG58Sb29CYfybqcLviHBVqlvhX1U7M6AUceqqen9mKW4IM5C3fcsIxfp7kCJ091Q==", "+375 25 7731900", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "515eb88c-621d-4b7e-b7e1-9b0488c95d39", false, "janemartin" },
                    { 19, 0, "88 Seventh Street, Riverside", "d0de27e9-5506-4fce-9392-ea7b5305a954", "susanclark60@gmail.com", false, true, null, "Susan Clark", "SUSANCLARK60@GMAIL.COM", "SUSANCLARK", "XV6184111", "AQAAAAIAAYagAAAAEIosiYaxyu9LNsgykXhlzSvlnmSXt5iUkZgEYdn6yCnlQHCNFOuX6JjzRiqZ25QwzA==", "+375 232 3237463", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "da58fd7a-3566-46c3-8a9e-8a7b196037d0", false, "susanclark" },
                    { 20, 0, "95 Church Street, Hillcrest", "d354b8c0-6448-43ad-aba3-7e809ed4358c", "sarahlee46@gmail.com", false, true, null, "Sarah Lee", "SARAHLEE46@GMAIL.COM", "SARAHLEE", "KN3789345", "AQAAAAIAAYagAAAAEGtfBGjc4f43DYZTKCTjo6cERufHNEQCD9LBx1ULXKAP8RPcFak9UGMF1JLfPG0b3w==", "+375 29 1504891", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cfac2a46-c4f2-4ae0-b89f-da0c6ae5eaea", false, "sarahlee" },
                    { 21, 0, "1 Washington Avenue, Fairview", "43827f5d-ee1c-4947-8517-380d2e29a96d", "williamjackson76@gmail.com", false, true, null, "William Jackson", "WILLIAMJACKSON76@GMAIL.COM", "WILLIAMJACKSON", "QA4175563", "AQAAAAIAAYagAAAAENpuKg+b5I2eO5wyvjskY9j6KxMFAGxjySd5cC89h8CEKnU5l+/J/A2UKk6sxOkW8A==", "+375 29 2505990", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7e6da9aa-1c68-41de-a0ab-6def2e2158f2", false, "williamjackson" },
                    { 22, 0, "8 Pine Street, Cedarville", "96c0a451-0a25-4b1a-b5fb-1517fcd99d11", "jessicagarcia30@gmail.com", false, true, null, "Jessica Garcia", "JESSICAGARCIA30@GMAIL.COM", "JESSICAGARCIA", "CX7420290", "AQAAAAIAAYagAAAAEHyKPCFWxdohHLHDM0DR8NH/W97QUaC7OAuPKXyndoa7SVNwtFaJj7mJSlIi33m3Fg==", "+375 29 9736547", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7e8edb0-3a1b-4779-8b5d-eb2b9780ea63", false, "jessicagarcia" },
                    { 23, 0, "14 Main Street, Smalltown", "8938b2ac-9050-41e1-b906-1f745b975bef", "elizabethking31@gmail.com", false, true, null, "Elizabeth King", "ELIZABETHKING31@GMAIL.COM", "ELIZABETHKING", "DA2878316", "AQAAAAIAAYagAAAAEORELPwyXqzG4g45AqhAtPYXtw0jQTDk5YG2X+pYR01BWIlid5JP7znOxoJweqb4NA==", "+375 29 4126018", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ded49e75-01db-46ce-adc6-9f3aab369a27", false, "elizabethking" },
                    { 24, 0, "40 School Lane, Eastwood", "61703873-59c3-4112-809c-8ed4fbc70479", "jamesyoung10@gmail.com", false, true, null, "James Young", "JAMESYOUNG10@GMAIL.COM", "JAMESYOUNG", "LA4990713", "AQAAAAIAAYagAAAAECD4N6ngZHu0PnmJ5jejFvKz6S2PMoIlg/HeUPVDymvduMjAeEz8FQaKeDC1WD9Baw==", "+375 232 1512766", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "723301b7-1481-4e8e-9eca-96213d09e239", false, "jamesyoung" },
                    { 25, 0, "8 Broadway, Mountainview", "53a466fd-0947-40c2-bcec-c6b47658758d", "davidallen70@gmail.com", false, true, null, "David Allen", "DAVIDALLEN70@GMAIL.COM", "DAVIDALLEN", "HP8169054", "AQAAAAIAAYagAAAAEJ2i9nWVNzcLRUNByBEXg1VPwMv2jriKjrPhtumrSdg86BmyTxGRAFBxDX/cqO84jg==", "+375 33 5429618", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "76143ac6-d30f-467c-93fb-e5e45f1cf6c6", false, "davidallen" },
                    { 26, 0, "97 Elm Street, Township", "11d1edf9-5492-47c3-99d2-a82607a94a00", "bobyoung14@gmail.com", false, true, null, "Bob Young", "BOBYOUNG14@GMAIL.COM", "BOBYOUNG", "KY3512569", "AQAAAAIAAYagAAAAEFqG3pbPfySu7ZlrrT2xymd4hhMV2yYFEyC9Wq95wTx/OZeIDXVnWQhMWoHZrXVSXA==", "+375 25 7347721", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "04514c5b-36c1-47aa-a383-5ea02128caa1", false, "bobyoung" },
                    { 27, 0, "62 Tenth Street, Springfield", "3729eaf8-31d6-46d5-a8e6-49e5371eeac6", "janewalker27@gmail.com", false, true, null, "Jane Walker", "JANEWALKER27@GMAIL.COM", "JANEWALKER", "GF7827932", "AQAAAAIAAYagAAAAEJ19v659U00jeaSlqK97oX2ytQyRQnllIavX9Rn5nXYA5qHxyb9HkfLJ8lSrzi7+/g==", "+375 25 7713145", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b7d53d76-09f8-40d5-81c2-75f28d21eec2", false, "janewalker" },
                    { 28, 0, "7 Church Street, Lakeview", "3c199a71-2f52-466a-857b-a3acd4cc2cd5", "emilydavis76@gmail.com", false, true, null, "Emily Davis", "EMILYDAVIS76@GMAIL.COM", "EMILYDAVIS", "KJ7761350", "AQAAAAIAAYagAAAAELeb+1UjE98o5f5P97o9yPdfgpVW02yh7zM3RQGuYJ0eOJoGzJF686slH1lFDMr9uQ==", "+375 29 7122835", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e27b404c-18bc-4331-bd23-13fd20f360a8", false, "emilydavis" },
                    { 29, 0, "38 Elm Street, Countyville", "072e0b67-3197-4538-bb44-3347dfdb96da", "bobharris28@gmail.com", false, true, null, "Bob Harris", "BOBHARRIS28@GMAIL.COM", "BOBHARRIS", "FX8287766", "AQAAAAIAAYagAAAAEFOmArwv3H6yoD1SQOihwWOKqqFvzwDq76oOqzVfGUb1y/UN0+S4JF03mF6fno/zfA==", "+375 232 4148322", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "134a5eee-64f4-464e-8467-2057ca76dcfb", false, "bobharris" },
                    { 30, 0, "41 Victory Street, Metropolis", "eb455525-3d97-46fa-b14e-809ec252b1ed", "robertharris49@gmail.com", false, true, null, "Robert Harris", "ROBERTHARRIS49@GMAIL.COM", "ROBERTHARRIS", "GK9265718", "AQAAAAIAAYagAAAAEG12kaQGLOc9OJjJ32ui6gyl+68eLLJHvpJIepDOHiMgI1jXHULZ/1/J4x2i2mj7ow==", "+375 29 6228080", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "51458401-5bfb-4183-b200-140d20656929", false, "robertharris" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Brand", "HirePrice", "Mileage", "Number", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { 1, "Audi", 834.0, 36430, "1246 XV-1", 9, "Repair" },
                    { 2, "BMW", 274.0, 63112, "2974 XI-1", 8, "Available" },
                    { 3, "Toyota", 292.0, 93329, "1170 AF-5", 2, "Available" },
                    { 4, "Volvo", 740.0, 59771, "9963 SP-1", 3, "Repair" },
                    { 5, "Toyota", 108.0, 85560, "1413 QX-4", 7, "Busy" },
                    { 6, "Mercedes", 601.0, 9673, "9004 KV-6", 7, "Repair" },
                    { 7, "Mercedes", 789.0, 31397, "1845 GC-3", 7, "Available" },
                    { 8, "Audi", 216.0, 89519, "3376 DH-6", 4, "Repair" },
                    { 9, "Toyota", 588.0, 19787, "7625 OT-6", 3, "Repair" },
                    { 10, "Audi", 468.0, 26830, "7792 VO-5", 7, "Available" },
                    { 11, "BMW", 744.0, 80337, "5988 VC-2", 3, "Repair" },
                    { 12, "Audi", 878.0, 6866, "3370 TF-6", 9, "Busy" },
                    { 13, "Mercedes", 161.0, 9940, "8513 RZ-1", 6, "Available" },
                    { 14, "Volvo", 766.0, 7594, "2024 OP-3", 8, "Repair" },
                    { 15, "Mercedes", 849.0, 88835, "7103 CH-4", 3, "Repair" },
                    { 16, "Toyota", 592.0, 64512, "5346 HZ-6", 8, "Repair" },
                    { 17, "BMW", 586.0, 33607, "6922 PJ-5", 6, "Available" },
                    { 18, "Audi", 492.0, 75534, "5958 PE-4", 8, "Repair" },
                    { 19, "Volvo", 220.0, 94787, "9434 XU-2", 7, "Available" },
                    { 20, "BMW", 472.0, 77416, "6465 SL-6", 5, "Busy" },
                    { 21, "Mercedes", 481.0, 62681, "4904 ON-2", 5, "Busy" },
                    { 22, "BMW", 543.0, 14344, "4835 IF-6", 2, "Repair" },
                    { 23, "Volvo", 136.0, 86090, "2462 LT-3", 2, "Repair" },
                    { 24, "Audi", 493.0, 11472, "3591 GS-4", 4, "Available" },
                    { 25, "BMW", 690.0, 79656, "5098 XT-6", 2, "Repair" },
                    { 26, "Toyota", 489.0, 24450, "9304 GT-2", 6, "Available" },
                    { 27, "Toyota", 115.0, 38243, "6557 MZ-4", 6, "Available" },
                    { 28, "Mercedes", 845.0, 35492, "6819 JJ-5", 3, "Repair" },
                    { 29, "Mercedes", 332.0, 58982, "7044 QW-1", 2, "Repair" },
                    { 30, "BMW", 478.0, 77162, "5454 CI-2", 3, "Busy" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 2, 18 },
                    { 3, 19 },
                    { 3, 20 },
                    { 2, 21 },
                    { 3, 22 },
                    { 1, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 3, 26 },
                    { 1, 27 },
                    { 2, 28 },
                    { 1, 29 },
                    { 3, 30 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CarId", "Deadline", "HireHours", "OrderDate", "OrderNumber", "UserId" },
                values: new object[,]
                {
                    { 1, null, 5, new DateTime(2002, 9, 30, 14, 48, 0, 0, DateTimeKind.Unspecified), 41, new DateTime(2002, 9, 28, 21, 48, 0, 0, DateTimeKind.Unspecified), 11348, 22 },
                    { 2, null, 25, new DateTime(2022, 1, 13, 4, 53, 0, 0, DateTimeKind.Unspecified), 44, new DateTime(2022, 1, 11, 8, 53, 0, 0, DateTimeKind.Unspecified), 74410, 24 },
                    { 3, null, 20, new DateTime(2009, 3, 15, 1, 33, 0, 0, DateTimeKind.Unspecified), 158, new DateTime(2009, 3, 8, 11, 33, 0, 0, DateTimeKind.Unspecified), 51083, 29 },
                    { 4, null, 6, new DateTime(2000, 9, 5, 1, 10, 0, 0, DateTimeKind.Unspecified), 63, new DateTime(2000, 9, 2, 10, 10, 0, 0, DateTimeKind.Unspecified), 55889, 19 },
                    { 5, null, 28, new DateTime(2008, 4, 1, 0, 31, 0, 0, DateTimeKind.Unspecified), 99, new DateTime(2008, 3, 27, 21, 31, 0, 0, DateTimeKind.Unspecified), 66642, 15 },
                    { 6, null, 21, new DateTime(2022, 4, 1, 23, 33, 0, 0, DateTimeKind.Unspecified), 77, new DateTime(2022, 3, 29, 18, 33, 0, 0, DateTimeKind.Unspecified), 67395, 11 },
                    { 7, null, 21, new DateTime(2006, 11, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), 156, new DateTime(2006, 10, 26, 4, 18, 0, 0, DateTimeKind.Unspecified), 94089, 26 },
                    { 8, null, 2, new DateTime(2007, 8, 17, 20, 23, 0, 0, DateTimeKind.Unspecified), 22, new DateTime(2007, 8, 16, 22, 23, 0, 0, DateTimeKind.Unspecified), 35152, 5 },
                    { 9, null, 25, new DateTime(2002, 5, 23, 13, 31, 0, 0, DateTimeKind.Unspecified), 26, new DateTime(2002, 5, 22, 11, 31, 0, 0, DateTimeKind.Unspecified), 58286, 19 },
                    { 10, null, 10, new DateTime(2022, 3, 19, 9, 58, 0, 0, DateTimeKind.Unspecified), 128, new DateTime(2022, 3, 14, 1, 58, 0, 0, DateTimeKind.Unspecified), 33015, 29 },
                    { 11, null, 2, new DateTime(2003, 10, 23, 7, 12, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2003, 10, 22, 16, 12, 0, 0, DateTimeKind.Unspecified), 77724, 25 },
                    { 12, null, 22, new DateTime(2020, 12, 22, 21, 17, 0, 0, DateTimeKind.Unspecified), 72, new DateTime(2020, 12, 19, 21, 17, 0, 0, DateTimeKind.Unspecified), 89597, 12 },
                    { 13, null, 3, new DateTime(2016, 1, 21, 13, 37, 0, 0, DateTimeKind.Unspecified), 41, new DateTime(2016, 1, 19, 20, 37, 0, 0, DateTimeKind.Unspecified), 41653, 17 },
                    { 14, null, 28, new DateTime(2001, 9, 12, 9, 15, 0, 0, DateTimeKind.Unspecified), 92, new DateTime(2001, 9, 8, 13, 15, 0, 0, DateTimeKind.Unspecified), 93403, 25 },
                    { 15, null, 15, new DateTime(2009, 3, 19, 0, 11, 0, 0, DateTimeKind.Unspecified), 68, new DateTime(2009, 3, 16, 4, 11, 0, 0, DateTimeKind.Unspecified), 66911, 28 },
                    { 16, null, 19, new DateTime(2000, 4, 26, 4, 15, 0, 0, DateTimeKind.Unspecified), 131, new DateTime(2000, 4, 20, 17, 15, 0, 0, DateTimeKind.Unspecified), 26322, 16 },
                    { 17, null, 9, new DateTime(2010, 6, 21, 6, 15, 0, 0, DateTimeKind.Unspecified), 100, new DateTime(2010, 6, 17, 2, 15, 0, 0, DateTimeKind.Unspecified), 68801, 20 },
                    { 18, null, 19, new DateTime(2018, 8, 27, 18, 4, 0, 0, DateTimeKind.Unspecified), 160, new DateTime(2018, 8, 21, 2, 4, 0, 0, DateTimeKind.Unspecified), 85055, 26 },
                    { 19, null, 27, new DateTime(2017, 11, 22, 4, 31, 0, 0, DateTimeKind.Unspecified), 34, new DateTime(2017, 11, 20, 18, 31, 0, 0, DateTimeKind.Unspecified), 50499, 9 },
                    { 20, null, 10, new DateTime(2014, 9, 14, 17, 48, 0, 0, DateTimeKind.Unspecified), 109, new DateTime(2014, 9, 10, 4, 48, 0, 0, DateTimeKind.Unspecified), 30412, 6 },
                    { 21, null, 25, new DateTime(2007, 11, 19, 15, 38, 0, 0, DateTimeKind.Unspecified), 149, new DateTime(2007, 11, 13, 10, 38, 0, 0, DateTimeKind.Unspecified), 62309, 13 },
                    { 22, null, 13, new DateTime(2021, 2, 17, 5, 34, 0, 0, DateTimeKind.Unspecified), 36, new DateTime(2021, 2, 15, 17, 34, 0, 0, DateTimeKind.Unspecified), 81108, 13 },
                    { 23, null, 29, new DateTime(2014, 7, 9, 11, 55, 0, 0, DateTimeKind.Unspecified), 25, new DateTime(2014, 7, 8, 10, 55, 0, 0, DateTimeKind.Unspecified), 68167, 19 },
                    { 24, null, 24, new DateTime(2023, 3, 20, 17, 36, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2023, 3, 20, 1, 36, 0, 0, DateTimeKind.Unspecified), 98648, 24 },
                    { 25, null, 10, new DateTime(2003, 10, 24, 4, 18, 0, 0, DateTimeKind.Unspecified), 114, new DateTime(2003, 10, 19, 10, 18, 0, 0, DateTimeKind.Unspecified), 93845, 15 },
                    { 26, null, 19, new DateTime(2018, 6, 9, 7, 20, 0, 0, DateTimeKind.Unspecified), 59, new DateTime(2018, 6, 6, 20, 20, 0, 0, DateTimeKind.Unspecified), 65564, 18 },
                    { 27, null, 17, new DateTime(2005, 10, 20, 14, 27, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2005, 10, 19, 23, 27, 0, 0, DateTimeKind.Unspecified), 77733, 23 },
                    { 28, null, 1, new DateTime(2000, 7, 4, 1, 22, 0, 0, DateTimeKind.Unspecified), 153, new DateTime(2000, 6, 27, 16, 22, 0, 0, DateTimeKind.Unspecified), 45088, 14 },
                    { 29, null, 24, new DateTime(2000, 8, 27, 11, 44, 0, 0, DateTimeKind.Unspecified), 28, new DateTime(2000, 8, 26, 7, 44, 0, 0, DateTimeKind.Unspecified), 68655, 25 },
                    { 30, null, 20, new DateTime(2013, 3, 8, 19, 55, 0, 0, DateTimeKind.Unspecified), 41, new DateTime(2013, 3, 7, 2, 55, 0, 0, DateTimeKind.Unspecified), 87361, 14 },
                    { 31, null, 25, new DateTime(2021, 3, 26, 2, 53, 0, 0, DateTimeKind.Unspecified), 106, new DateTime(2021, 3, 21, 16, 53, 0, 0, DateTimeKind.Unspecified), 46625, 1 },
                    { 32, null, 15, new DateTime(2010, 10, 8, 11, 36, 0, 0, DateTimeKind.Unspecified), 82, new DateTime(2010, 10, 5, 1, 36, 0, 0, DateTimeKind.Unspecified), 23685, 27 },
                    { 33, null, 1, new DateTime(2002, 4, 14, 15, 2, 0, 0, DateTimeKind.Unspecified), 157, new DateTime(2002, 4, 8, 2, 2, 0, 0, DateTimeKind.Unspecified), 86461, 1 },
                    { 34, null, 2, new DateTime(2018, 5, 14, 0, 14, 0, 0, DateTimeKind.Unspecified), 129, new DateTime(2018, 5, 8, 15, 14, 0, 0, DateTimeKind.Unspecified), 40559, 10 },
                    { 35, null, 8, new DateTime(2010, 4, 19, 1, 35, 0, 0, DateTimeKind.Unspecified), 153, new DateTime(2010, 4, 12, 16, 35, 0, 0, DateTimeKind.Unspecified), 77690, 27 },
                    { 36, null, 19, new DateTime(2012, 8, 21, 17, 56, 0, 0, DateTimeKind.Unspecified), 56, new DateTime(2012, 8, 19, 9, 56, 0, 0, DateTimeKind.Unspecified), 21765, 2 },
                    { 37, null, 1, new DateTime(2011, 4, 3, 23, 15, 0, 0, DateTimeKind.Unspecified), 87, new DateTime(2011, 3, 31, 8, 15, 0, 0, DateTimeKind.Unspecified), 21905, 20 },
                    { 38, null, 27, new DateTime(2009, 7, 16, 10, 43, 0, 0, DateTimeKind.Unspecified), 29, new DateTime(2009, 7, 15, 5, 43, 0, 0, DateTimeKind.Unspecified), 31127, 4 },
                    { 39, null, 24, new DateTime(2003, 9, 3, 0, 49, 0, 0, DateTimeKind.Unspecified), 126, new DateTime(2003, 8, 28, 18, 49, 0, 0, DateTimeKind.Unspecified), 14679, 20 },
                    { 40, null, 16, new DateTime(2019, 2, 22, 18, 6, 0, 0, DateTimeKind.Unspecified), 37, new DateTime(2019, 2, 21, 5, 6, 0, 0, DateTimeKind.Unspecified), 17721, 20 },
                    { 41, null, 3, new DateTime(2017, 9, 7, 0, 13, 0, 0, DateTimeKind.Unspecified), 89, new DateTime(2017, 9, 3, 7, 13, 0, 0, DateTimeKind.Unspecified), 26754, 5 },
                    { 42, null, 27, new DateTime(2007, 6, 16, 10, 49, 0, 0, DateTimeKind.Unspecified), 146, new DateTime(2007, 6, 10, 8, 49, 0, 0, DateTimeKind.Unspecified), 52534, 26 },
                    { 43, null, 23, new DateTime(2011, 4, 10, 7, 2, 0, 0, DateTimeKind.Unspecified), 146, new DateTime(2011, 4, 4, 5, 2, 0, 0, DateTimeKind.Unspecified), 29701, 26 },
                    { 44, null, 14, new DateTime(2005, 10, 5, 20, 20, 0, 0, DateTimeKind.Unspecified), 73, new DateTime(2005, 10, 2, 19, 20, 0, 0, DateTimeKind.Unspecified), 10856, 20 },
                    { 45, null, 23, new DateTime(2022, 10, 11, 5, 6, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2022, 10, 10, 17, 6, 0, 0, DateTimeKind.Unspecified), 57065, 25 },
                    { 46, null, 6, new DateTime(2018, 2, 21, 5, 50, 0, 0, DateTimeKind.Unspecified), 78, new DateTime(2018, 2, 17, 23, 50, 0, 0, DateTimeKind.Unspecified), 86932, 11 },
                    { 47, null, 28, new DateTime(2013, 8, 5, 12, 22, 0, 0, DateTimeKind.Unspecified), 62, new DateTime(2013, 8, 2, 22, 22, 0, 0, DateTimeKind.Unspecified), 67931, 11 },
                    { 48, null, 22, new DateTime(2022, 2, 27, 16, 11, 0, 0, DateTimeKind.Unspecified), 147, new DateTime(2022, 2, 21, 13, 11, 0, 0, DateTimeKind.Unspecified), 12154, 10 },
                    { 49, null, 14, new DateTime(2016, 1, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 152, new DateTime(2015, 12, 26, 21, 3, 0, 0, DateTimeKind.Unspecified), 29809, 14 },
                    { 50, null, 12, new DateTime(2018, 11, 3, 6, 59, 0, 0, DateTimeKind.Unspecified), 140, new DateTime(2018, 10, 28, 10, 59, 0, 0, DateTimeKind.Unspecified), 12688, 8 }
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
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 28 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30);

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
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 29);
        }
    }
}
