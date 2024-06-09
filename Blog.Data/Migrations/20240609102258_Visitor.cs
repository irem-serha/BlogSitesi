using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccessLayer.Migrations
{
    public partial class Visitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("97cc30ef-609e-42f9-bf08-4bd8047be8dd"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd3be256-486d-4297-a6f9-b8793bd59be3"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1fbc0c3a-2847-4809-bab8-7e6e4ad3ccb5"), new Guid("c8711160-e666-4106-9d63-4f04b886b52a"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", "Admin Test", new DateTime(2024, 6, 9, 13, 22, 57, 419, DateTimeKind.Local).AddTicks(4345), null, null, new Guid("3873785e-2e56-4747-b5ba-0ab6e7cff833"), false, null, null, "Visual Studio Core Deneme Makalesi 1", new Guid("f1949dc5-7d0f-44b0-8a75-4c36a5218b9b"), 15 },
                    { new Guid("a3eb2d0c-25f0-4e48-a50d-f37f48184c49"), new Guid("7cb57ebd-a4a2-4de9-b3ae-1fb226dda0c8"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", "Admin Test", new DateTime(2024, 6, 9, 13, 22, 57, 419, DateTimeKind.Local).AddTicks(4333), null, null, new Guid("3f7c23e8-8329-4677-91d2-c557b83ecc68"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("22aa7ee1-3b01-40f3-bf28-d6db0b7636db"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("14b1d4d7-f625-4e23-a804-80471120fccd"),
                column: "ConcurrencyStamp",
                value: "b79cdd3e-b286-46c0-a1ca-df4ee45e647c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2816978b-4352-4209-b9f5-d93b3e306271"),
                column: "ConcurrencyStamp",
                value: "c340a1b9-672c-4659-a7b7-5e958f0ed78b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2bf79887-d581-4dee-8029-3fd0c3702ec8"),
                column: "ConcurrencyStamp",
                value: "29e8f79d-5963-4e5e-a3d8-ba5157f16286");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("22aa7ee1-3b01-40f3-bf28-d6db0b7636db"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fa05dba-c55d-4f2a-b869-64b47b0a9725", "AQAAAAEAACcQAAAAEJc64PCWRAFtyiYZX7O+5CreV60RZy1ueabHks0A74ixWSOx5updgg0IO0rYmvDU/A==", "d0509dad-8289-4e6c-a616-d0ed3bf31b96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1949dc5-7d0f-44b0-8a75-4c36a5218b9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bba35cb-de99-40a0-a030-f9f95d2e8ab0", "AQAAAAEAACcQAAAAENl4nY6hA4TmH5x6l05DYuQl4We4VgQ+x0Gn6Wu5YFYF9jdxM8/B/loo8qHa0Pg1FA==", "dbfcf793-7654-4a98-808f-4ecfd08ec72a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cb57ebd-a4a2-4de9-b3ae-1fb226dda0c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 22, 57, 419, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8711160-e666-4106-9d63-4f04b886b52a"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 22, 57, 419, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3873785e-2e56-4747-b5ba-0ab6e7cff833"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 22, 57, 419, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f7c23e8-8329-4677-91d2-c557b83ecc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 13, 22, 57, 419, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1fbc0c3a-2847-4809-bab8-7e6e4ad3ccb5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a3eb2d0c-25f0-4e48-a50d-f37f48184c49"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("97cc30ef-609e-42f9-bf08-4bd8047be8dd"), new Guid("7cb57ebd-a4a2-4de9-b3ae-1fb226dda0c8"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", "Admin Test", new DateTime(2024, 6, 2, 16, 29, 13, 829, DateTimeKind.Local).AddTicks(4162), null, null, new Guid("3f7c23e8-8329-4677-91d2-c557b83ecc68"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("22aa7ee1-3b01-40f3-bf28-d6db0b7636db"), 15 },
                    { new Guid("dd3be256-486d-4297-a6f9-b8793bd59be3"), new Guid("c8711160-e666-4106-9d63-4f04b886b52a"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.", "Admin Test", new DateTime(2024, 6, 2, 16, 29, 13, 829, DateTimeKind.Local).AddTicks(4173), null, null, new Guid("3873785e-2e56-4747-b5ba-0ab6e7cff833"), false, null, null, "Visual Studio Core Deneme Makalesi 1", new Guid("f1949dc5-7d0f-44b0-8a75-4c36a5218b9b"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("14b1d4d7-f625-4e23-a804-80471120fccd"),
                column: "ConcurrencyStamp",
                value: "513e1414-ba11-4c59-9b30-dedfa5ef6552");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2816978b-4352-4209-b9f5-d93b3e306271"),
                column: "ConcurrencyStamp",
                value: "154f7601-d293-4137-8394-f4d38a4e15e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2bf79887-d581-4dee-8029-3fd0c3702ec8"),
                column: "ConcurrencyStamp",
                value: "52fd5d01-0b06-4978-b722-1d812c02179d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("22aa7ee1-3b01-40f3-bf28-d6db0b7636db"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f0c8354-ad03-46f0-be4b-7d1c4d860371", "AQAAAAEAACcQAAAAEFxIj9Dy43/nX36MxVxbaevJeYddMIQ+LztPsvKl/VreFeHbXo2aPZIgTLF06sjGAw==", "ac4ed212-c0bc-4010-9d18-ab5aa55d38c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1949dc5-7d0f-44b0-8a75-4c36a5218b9b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b071d9a-76ab-424f-a5c0-dddda55585d2", "AQAAAAEAACcQAAAAEEjBeIxasSsubXghmOY9fGH7zuoAvJCGNgWklEi5RofqXsCtcwOFpIABYBi7WcPO2A==", "212350a7-3e3b-4c1e-a6f7-863dbfb20030" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cb57ebd-a4a2-4de9-b3ae-1fb226dda0c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 2, 16, 29, 13, 829, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8711160-e666-4106-9d63-4f04b886b52a"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 2, 16, 29, 13, 829, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3873785e-2e56-4747-b5ba-0ab6e7cff833"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 2, 16, 29, 13, 829, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f7c23e8-8329-4677-91d2-c557b83ecc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 2, 16, 29, 13, 829, DateTimeKind.Local).AddTicks(4939));
        }
    }
}
