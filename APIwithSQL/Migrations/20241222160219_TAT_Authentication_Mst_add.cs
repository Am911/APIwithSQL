using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIwithSQL.Migrations
{
    /// <inheritdoc />
    public partial class TAT_Authentication_Mst_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TAT_Authentication_Mst",
                columns: table => new
                {
                    UserAuthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAT_Authentication_Mst", x => x.UserAuthId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAT_Authentication_Mst");
        }
    }
}
