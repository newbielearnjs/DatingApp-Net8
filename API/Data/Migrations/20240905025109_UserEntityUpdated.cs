﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserEntityUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "USerName",
                table: "AppUsers",
                newName: "UserName");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "AppUsers",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "AppUsers",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AppUsers",
                newName: "USerName");
        }
    }
}
