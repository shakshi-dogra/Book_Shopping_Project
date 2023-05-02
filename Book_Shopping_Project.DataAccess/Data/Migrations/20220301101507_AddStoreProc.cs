﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_Shopping_Project.DataAccess.Migrations
{
    public partial class AddStoreProc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE GetAllCoverTypes
                                 AS
                                 select * from CoverTypes ");
            migrationBuilder.Sql(@"CREATE PROCEDURE GetCoverType
	                             @id int
                                 AS
                                 select * from CoverTypes where Id=@id");
            migrationBuilder.Sql(@"CREATE PROCEDURE CreateCoverType
	                             @name varchar(50)
                                 AS
                                 insert CoverTypes values(@name)");
            migrationBuilder.Sql(@"CREATE PROCEDURE UpdateCoverType
                                 @id int,
	                             @name varchar(50)
                                AS
                                update CoverTypes set name=@name where Id=@id");
            migrationBuilder.Sql(@"CREATE PROCEDURE DeletecoverType
                                 @id int
                                 AS
                                 delete from CoverTypes  where Id=@id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
