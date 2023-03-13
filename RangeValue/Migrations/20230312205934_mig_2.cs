using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RangeValue.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "score",
                table: "Results",
                newName: "C1");

            migrationBuilder.RenameColumn(
                name: "secondOperand",
                table: "RangeControls",
                newName: "SecondOperand");

            migrationBuilder.RenameColumn(
                name: "secondNumber",
                table: "RangeControls",
                newName: "SecondNumber");

            migrationBuilder.RenameColumn(
                name: "firstOperand",
                table: "RangeControls",
                newName: "FirstOperand");

            migrationBuilder.RenameColumn(
                name: "firstNumber",
                table: "RangeControls",
                newName: "FirstNumber");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "RangeControls",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "RangeControls");

            migrationBuilder.RenameColumn(
                name: "C1",
                table: "Results",
                newName: "score");

            migrationBuilder.RenameColumn(
                name: "SecondOperand",
                table: "RangeControls",
                newName: "secondOperand");

            migrationBuilder.RenameColumn(
                name: "SecondNumber",
                table: "RangeControls",
                newName: "secondNumber");

            migrationBuilder.RenameColumn(
                name: "FirstOperand",
                table: "RangeControls",
                newName: "firstOperand");

            migrationBuilder.RenameColumn(
                name: "FirstNumber",
                table: "RangeControls",
                newName: "firstNumber");
        }
    }
}
