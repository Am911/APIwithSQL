using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIwithSQL.Migrations
{
    /// <inheritdoc />
    public partial class TAT_VehicleType_Mst_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TAT_VehicleType_Mst",
                columns: table => new
                {
                    VehicleType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CretaedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAT_VehicleType_Mst", x => x.VehicleType_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAT_VehicleType_Mst");
        }
    }
}
