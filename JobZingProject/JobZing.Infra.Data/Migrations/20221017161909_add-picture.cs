using Microsoft.EntityFrameworkCore.Migrations;

namespace JobZing.Infra.Data.Migrations
{
    public partial class addpicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "JobCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureAlt",
                table: "JobCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureTitle",
                table: "JobCategories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "PictureAlt",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "PictureTitle",
                table: "JobCategories");
        }
    }
}
