using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RadarLiterario.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "sinopse",
                table: "Livros",
                type: "tinytext",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "tinytext",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ImagemCapa",
                table: "Livros",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Dados",
                table: "Arquivos",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Arquivos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Arquivos_LivroId",
                table: "Arquivos",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arquivos_Livros_LivroId",
                table: "Arquivos",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arquivos_Livros_LivroId",
                table: "Arquivos");

            migrationBuilder.DropIndex(
                name: "IX_Arquivos_LivroId",
                table: "Arquivos");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Arquivos");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(767)");

            migrationBuilder.AlterColumn<string>(
                name: "sinopse",
                table: "Livros",
                type: "tinytext",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ImagemCapa",
                table: "Livros",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Dados",
                table: "Arquivos",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);
        }
    }
}
