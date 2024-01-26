using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BolalarBogchasi.Migrations
{
    /// <inheritdoc />
    public partial class ModellarYaratildiFirstStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    IshchiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BerilganGuruhNomi = table.Column<string>(type: "text", nullable: false),
                    IshningNomi = table.Column<string>(type: "text", nullable: false),
                    IshchiIsmi = table.Column<string>(type: "text", nullable: false),
                    IshchiFamiliyasi = table.Column<string>(type: "text", nullable: false),
                    IshchiKelganKun = table.Column<string>(type: "text", nullable: false),
                    IshchiTelRaqami = table.Column<string>(type: "text", nullable: false),
                    IshchiElektronPochta = table.Column<string>(type: "text", nullable: false),
                    IshchiMaoshi = table.Column<int>(type: "integer", nullable: false),
                    IshchiBogchadami = table.Column<bool>(type: "boolean", nullable: false),
                    IshId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.IshchiId);
                    table.ForeignKey(
                        name: "FK_Coach_Works_IshId",
                        column: x => x.IshId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cook",
                columns: table => new
                {
                    IshchiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IshningNomi = table.Column<string>(type: "text", nullable: false),
                    IshchiIsmi = table.Column<string>(type: "text", nullable: false),
                    IshchiFamiliyasi = table.Column<string>(type: "text", nullable: false),
                    IshchiKelganKun = table.Column<string>(type: "text", nullable: false),
                    IshchiTelRaqami = table.Column<string>(type: "text", nullable: false),
                    IshchiElektronPochta = table.Column<string>(type: "text", nullable: false),
                    IshchiMaoshi = table.Column<int>(type: "integer", nullable: false),
                    IshchiBogchadami = table.Column<bool>(type: "boolean", nullable: false),
                    IshId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cook", x => x.IshchiId);
                    table.ForeignKey(
                        name: "FK_Cook_Works_IshId",
                        column: x => x.IshId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taxi",
                columns: table => new
                {
                    IshchiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IshningNomi = table.Column<string>(type: "text", nullable: false),
                    HaydovchiManzili = table.Column<string>(type: "text", nullable: false),
                    IshchiIsmi = table.Column<string>(type: "text", nullable: false),
                    IshchiFamiliyasi = table.Column<string>(type: "text", nullable: false),
                    IshchiKelganKun = table.Column<string>(type: "text", nullable: false),
                    IshchiTelRaqami = table.Column<string>(type: "text", nullable: false),
                    IshchiElektronPochta = table.Column<string>(type: "text", nullable: false),
                    IshchiMaoshi = table.Column<int>(type: "integer", nullable: false),
                    IshchiBogchadami = table.Column<bool>(type: "boolean", nullable: false),
                    IshId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxi", x => x.IshchiId);
                    table.ForeignKey(
                        name: "FK_Taxi_Works_IshId",
                        column: x => x.IshId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GuruhId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GuruhNomi = table.Column<string>(type: "text", nullable: false),
                    Tarbiyachi_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GuruhId);
                    table.ForeignKey(
                        name: "FK_Group_Coach_Tarbiyachi_id",
                        column: x => x.Tarbiyachi_id,
                        principalTable: "Coach",
                        principalColumn: "IshchiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    BolaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BolaGuruhi = table.Column<string>(type: "text", nullable: false),
                    BolaningManzili = table.Column<string>(type: "text", nullable: false),
                    BolaIsmi = table.Column<string>(type: "text", nullable: false),
                    BolaFamiliyasi = table.Column<string>(type: "text", nullable: false),
                    BolaKelganKun = table.Column<string>(type: "text", nullable: false),
                    BolagaBoglanishTelRaqami = table.Column<string>(type: "text", nullable: false),
                    BolagaBoglanishElektronPochta = table.Column<string>(type: "text", nullable: false),
                    BolaBogchadami = table.Column<bool>(type: "boolean", nullable: false),
                    BolaTolovi = table.Column<long>(type: "bigint", nullable: false),
                    GuruhId = table.Column<int>(type: "integer", nullable: false),
                    HaydovchiId = table.Column<int>(type: "integer", nullable: false),
                    TarbiyachiId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.BolaId);
                    table.ForeignKey(
                        name: "FK_Child_Coach_TarbiyachiId",
                        column: x => x.TarbiyachiId,
                        principalTable: "Coach",
                        principalColumn: "IshchiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Child_Group_GuruhId",
                        column: x => x.GuruhId,
                        principalTable: "Group",
                        principalColumn: "GuruhId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Child_Taxi_HaydovchiId",
                        column: x => x.HaydovchiId,
                        principalTable: "Taxi",
                        principalColumn: "IshchiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "haydovchi" },
                    { 2, "tarbiyachi" },
                    { 3, "oshpaz" }
                });

            migrationBuilder.InsertData(
                table: "Coach",
                columns: new[] { "IshchiId", "BerilganGuruhNomi", "IshId", "IshchiBogchadami", "IshchiElektronPochta", "IshchiFamiliyasi", "IshchiIsmi", "IshchiKelganKun", "IshchiMaoshi", "IshchiTelRaqami", "IshningNomi" },
                values: new object[] { 1, "guruh1", 2, true, "tarbiyachi@gmail.com", "NoOne", "Unknown", "01/01/01", 4500000, "+2222222222222", "tarbiyachi" });

            migrationBuilder.InsertData(
                table: "Cook",
                columns: new[] { "IshchiId", "IshId", "IshchiBogchadami", "IshchiElektronPochta", "IshchiFamiliyasi", "IshchiIsmi", "IshchiKelganKun", "IshchiMaoshi", "IshchiTelRaqami", "IshningNomi" },
                values: new object[] { 1, 3, true, "oshpaz@gmail.com", "NoOne", "Unknown", "01/01/01", 4500000, "+111111111111", "oshpaz" });

            migrationBuilder.InsertData(
                table: "Taxi",
                columns: new[] { "IshchiId", "HaydovchiManzili", "IshId", "IshchiBogchadami", "IshchiElektronPochta", "IshchiFamiliyasi", "IshchiIsmi", "IshchiKelganKun", "IshchiMaoshi", "IshchiTelRaqami", "IshningNomi" },
                values: new object[] { 1, "yunusobod", 1, true, "Haydovchi@gmail.com", "NoOne", "Unknown", "01/01/01", 4500000, "+000000000000", "haydovchi" });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GuruhId", "GuruhNomi", "Tarbiyachi_id" },
                values: new object[] { 1, "guruh1", 1 });

            migrationBuilder.InsertData(
                table: "Child",
                columns: new[] { "BolaId", "BolaBogchadami", "BolaFamiliyasi", "BolaGuruhi", "BolaIsmi", "BolaKelganKun", "BolaTolovi", "BolagaBoglanishElektronPochta", "BolagaBoglanishTelRaqami", "BolaningManzili", "GuruhId", "HaydovchiId", "TarbiyachiId" },
                values: new object[] { 1, true, "Nobody", "guruh1", "Nobody", "01/01/01", 270000L, "Email@gmail.com", "+000000000000", "yunusobod", 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Child_GuruhId",
                table: "Child",
                column: "GuruhId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_HaydovchiId",
                table: "Child",
                column: "HaydovchiId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_TarbiyachiId",
                table: "Child",
                column: "TarbiyachiId");

            migrationBuilder.CreateIndex(
                name: "IX_Coach_IshId",
                table: "Coach",
                column: "IshId");

            migrationBuilder.CreateIndex(
                name: "IX_Cook_IshId",
                table: "Cook",
                column: "IshId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Tarbiyachi_id",
                table: "Group",
                column: "Tarbiyachi_id");

            migrationBuilder.CreateIndex(
                name: "IX_Taxi_IshId",
                table: "Taxi",
                column: "IshId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "Cook");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Taxi");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
