using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloDatabase.Migrations {

  public partial class InitialMigration : Migration {

    protected override void Up( MigrationBuilder migrationBuilder ) {
      migrationBuilder.CreateTable(
          name: "Categories",
          columns: table => new
          {
            Id = table.Column<Guid>( nullable: false ),
            Name = table.Column<string>( nullable: true )
          },
          constraints: table =>
          {
            table.PrimaryKey( "PK_Categories", x => x.Id );
          } );

      migrationBuilder.CreateTable(
          name: "Movies",
          columns: table => new
          {
            Id = table.Column<Guid>( nullable: false ),
            CategoryId = table.Column<Guid>( nullable: true ),
            Director = table.Column<string>( nullable: true ),
            Length = table.Column<TimeSpan>( nullable: false ),
            Rating = table.Column<int>( nullable: false ),
            Title = table.Column<string>( nullable: true )
          },
          constraints: table =>
          {
            table.PrimaryKey( "PK_Movies", x => x.Id );
            table.ForeignKey(
                      name: "FK_Movies_Categories_CategoryId",
                      column: x => x.CategoryId,
                      principalTable: "Categories",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.Restrict );
          } );

      migrationBuilder.CreateIndex(
          name: "IX_Movies_CategoryId",
          table: "Movies",
          column: "CategoryId" );
    }

    protected override void Down( MigrationBuilder migrationBuilder ) {
      migrationBuilder.DropTable(
          name: "Movies" );

      migrationBuilder.DropTable(
          name: "Categories" );
    }

  }

}