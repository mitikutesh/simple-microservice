using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageService.Migrations
{
    public partial class FileTagLinkAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImageFileId",
                table: "FileTags",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ImageTagId",
                table: "FileTags",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileTags_ImageFileId",
                table: "FileTags",
                column: "ImageFileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileTags_ImageTagId",
                table: "FileTags",
                column: "ImageTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileTags_ImageFiles_ImageFileId",
                table: "FileTags",
                column: "ImageFileId",
                principalTable: "ImageFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FileTags_ImageTags_ImageTagId",
                table: "FileTags",
                column: "ImageTagId",
                principalTable: "ImageTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileTags_ImageFiles_ImageFileId",
                table: "FileTags");

            migrationBuilder.DropForeignKey(
                name: "FK_FileTags_ImageTags_ImageTagId",
                table: "FileTags");

            migrationBuilder.DropIndex(
                name: "IX_FileTags_ImageFileId",
                table: "FileTags");

            migrationBuilder.DropIndex(
                name: "IX_FileTags_ImageTagId",
                table: "FileTags");

            migrationBuilder.DropColumn(
                name: "ImageFileId",
                table: "FileTags");

            migrationBuilder.DropColumn(
                name: "ImageTagId",
                table: "FileTags");
        }
    }
}
