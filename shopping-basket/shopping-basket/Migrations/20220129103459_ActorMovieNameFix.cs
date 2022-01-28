using Microsoft.EntityFrameworkCore.Migrations;

namespace shopping_basket.Migrations
{
    public partial class ActorMovieNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_ActorID",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Movies_MovieID",
                table: "Actor_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies");

            migrationBuilder.RenameTable(
                name: "Actor_Movies",
                newName: "Actors_Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_Movies_MovieID",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "ActorID", "MovieID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorID",
                table: "Actors_Movies",
                column: "ActorID",
                principalTable: "Actors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieID",
                table: "Actors_Movies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorID",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieID",
                table: "Actors_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "Actor_Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieID",
                table: "Actor_Movies",
                newName: "IX_Actor_Movies_MovieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies",
                columns: new[] { "ActorID", "MovieID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_ActorID",
                table: "Actor_Movies",
                column: "ActorID",
                principalTable: "Actors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Movies_MovieID",
                table: "Actor_Movies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
