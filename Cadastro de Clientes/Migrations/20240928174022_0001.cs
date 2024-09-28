using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace Cadastro_de_Clientes.Migrations
{
    /// <inheritdoc />
    public partial class _0001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Users SET PhoneNumber = '1612354687' WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Users SET PhoneNumber = '1665898742' WHERE Id = 2");
            migrationBuilder.Sql("UPDATE Users SET PhoneNumber = '1765412398' WHERE Id = 3");
            migrationBuilder.Sql("UPDATE Users SET PhoneNumber = '1987456320' WHERE Id = 4");
            migrationBuilder.Sql("UPDATE Users SET PhoneNumber = '1875395584' WHERE Id = 5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
