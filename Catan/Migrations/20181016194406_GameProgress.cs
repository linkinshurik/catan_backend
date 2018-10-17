using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Catan.Migrations
{
    public partial class GameProgress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameLogs",
                columns: table => new
                {
                    Game = table.Column<Guid>(nullable: false),
                    CurrentTurn = table.Column<Guid>(nullable: false),
                    Rubber = table.Column<int>(nullable: false),
                    User1_Raws = table.Column<List<int>>(nullable: true),
                    User2_Raws = table.Column<List<int>>(nullable: true),
                    User3_Raws = table.Column<List<int>>(nullable: true),
                    User4_Raws = table.Column<List<int>>(nullable: true),
                    User1_Develops = table.Column<List<int>>(nullable: true),
                    User2_Develops = table.Column<List<int>>(nullable: true),
                    User3_Develops = table.Column<List<int>>(nullable: true),
                    User4_Develops = table.Column<List<int>>(nullable: true),
                    User1_Villages = table.Column<List<int>>(nullable: true),
                    User2_Villages = table.Column<List<int>>(nullable: true),
                    User3_Villages = table.Column<List<int>>(nullable: true),
                    User4_Villages = table.Column<List<int>>(nullable: true),
                    User1_Towns = table.Column<List<int>>(nullable: true),
                    User2_Towns = table.Column<List<int>>(nullable: true),
                    User3_Towns = table.Column<List<int>>(nullable: true),
                    User4_Towns = table.Column<List<int>>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLogs", x => x.Game);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    User1 = table.Column<Guid>(nullable: false),
                    User2 = table.Column<Guid>(nullable: false),
                    User3 = table.Column<Guid>(nullable: false),
                    User4 = table.Column<Guid>(nullable: false),
                    Admin = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lands",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Geks = table.Column<List<int>>(nullable: true),
                    GeksToken = table.Column<List<int>>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Token = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Road",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false),
                    GameStatusGame = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Road", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Road_GameLogs_GameStatusGame",
                        column: x => x.GameStatusGame,
                        principalTable: "GameLogs",
                        principalColumn: "Game",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Road_GameStatusGame",
                table: "Road",
                column: "GameStatusGame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Lands");

            migrationBuilder.DropTable(
                name: "Road");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GameLogs");
        }
    }
}
