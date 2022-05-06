using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    public partial class seedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into users Values (2 , 'user 2')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From users Where Name = 'user 2'");
        }
    }
}
