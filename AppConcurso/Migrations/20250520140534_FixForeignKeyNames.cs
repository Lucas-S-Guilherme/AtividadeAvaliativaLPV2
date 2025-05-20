using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppConcurso.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeyNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inscricao_candidato_candidato_id",
                table: "inscricao");

            migrationBuilder.DropForeignKey(
                name: "FK_inscricao_cargo_cargo_id",
                table: "inscricao");

            migrationBuilder.DropIndex(
                name: "IX_inscricao_candidato_id",
                table: "inscricao");

            migrationBuilder.DropIndex(
                name: "IX_inscricao_cargo_id",
                table: "inscricao");

            migrationBuilder.RenameColumn(
                name: "cargo_id",
                table: "inscricao",
                newName: "IdCargo");

            migrationBuilder.RenameColumn(
                name: "candidato_id",
                table: "inscricao",
                newName: "IdCandidato");

            migrationBuilder.AddColumn<int>(
                name: "CandidatoId",
                table: "inscricao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "inscricao",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_inscricao_CandidatoId",
                table: "inscricao",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_inscricao_CargoId",
                table: "inscricao",
                column: "CargoId");

            migrationBuilder.AddForeignKey(
                name: "FK_inscricao_candidato_CandidatoId",
                table: "inscricao",
                column: "CandidatoId",
                principalTable: "candidato",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_inscricao_cargo_CargoId",
                table: "inscricao",
                column: "CargoId",
                principalTable: "cargo",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inscricao_candidato_CandidatoId",
                table: "inscricao");

            migrationBuilder.DropForeignKey(
                name: "FK_inscricao_cargo_CargoId",
                table: "inscricao");

            migrationBuilder.DropIndex(
                name: "IX_inscricao_CandidatoId",
                table: "inscricao");

            migrationBuilder.DropIndex(
                name: "IX_inscricao_CargoId",
                table: "inscricao");

            migrationBuilder.DropColumn(
                name: "CandidatoId",
                table: "inscricao");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "inscricao");

            migrationBuilder.RenameColumn(
                name: "IdCargo",
                table: "inscricao",
                newName: "cargo_id");

            migrationBuilder.RenameColumn(
                name: "IdCandidato",
                table: "inscricao",
                newName: "candidato_id");

            migrationBuilder.CreateIndex(
                name: "IX_inscricao_candidato_id",
                table: "inscricao",
                column: "candidato_id");

            migrationBuilder.CreateIndex(
                name: "IX_inscricao_cargo_id",
                table: "inscricao",
                column: "cargo_id");

            migrationBuilder.AddForeignKey(
                name: "FK_inscricao_candidato_candidato_id",
                table: "inscricao",
                column: "candidato_id",
                principalTable: "candidato",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_inscricao_cargo_cargo_id",
                table: "inscricao",
                column: "cargo_id",
                principalTable: "cargo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
