using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageService.BusinessLogic.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageTags_ImageFiles_ImageFileId",
                        column: x => x.ImageFileId,
                        principalTable: "ImageFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageTags_ImageFileId",
                table: "ImageTags",
                column: "ImageFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageTags");

            migrationBuilder.DropTable(
                name: "ImageFiles");
        }
    }
}
