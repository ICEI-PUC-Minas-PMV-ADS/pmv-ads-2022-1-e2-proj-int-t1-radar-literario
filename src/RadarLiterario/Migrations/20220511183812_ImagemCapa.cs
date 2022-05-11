using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RadarLiterario.Migrations
{
    public partial class ImagemCapa : Migration
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
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "ImagemCapa",
                table: "Livros",
                type: "longtext",
                nullable: false);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Dados",
                table: "Arquivos",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemCapa",
                table: "Livros");

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
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 255);

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
