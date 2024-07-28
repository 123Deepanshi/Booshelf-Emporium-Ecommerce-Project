using Microsoft.EntityFrameworkCore.Migrations;
using System.Runtime.InteropServices;

#nullable disable

namespace Ecomm_Book_1031.DataAccess.Migrations
{
    public partial class AddSPForCoverType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_Create_CoverType
                                 @name varchar(50)
	
                                 AS
	                             insert CoverTypes values(@name)");
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_Update_CoverType
                                 @id int,
                                 @name varchar(50)
	
                                 AS
	                             Update CoverTypes set name=@name where id=@id");
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_Delete_CoverType
                                 @id int
	
                                 AS
	                             Delete CoverTypes where id=@id");
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_Get_CoverTypes
                                 AS
	                             select * from CoverTypes");
            migrationBuilder.Sql(@"CREATE PROCEDURE SP_Get_CoverType
                                 @id int
	
                                 AS
	                             select * from CoverTypes where id=@id");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
