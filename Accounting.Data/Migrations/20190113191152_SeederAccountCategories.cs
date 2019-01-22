using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Data.Migrations
{
    public partial class SeederAccountCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name" },
                values: new object[] { 1, "1000", 0, 0, "Assets" });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name" },
                values: new object[] { 2, "2000", 0, 0, "Liabilities" });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name" },
                values: new object[] { 3, "3000", 0, 0, "Equities" });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name" },
                values: new object[] { 4, "4000", 0, 0, "Income Statements" });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 11, "1100", 0, 0, "Current Assets", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 34, "3600", 0, 0, "Drawings", 3 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 33, "3500", 0, 0, "Member Contribution", 3 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 32, "3400", 0, 0, "Partner Capital", 3 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 31, "3300", 0, 0, "Paid in Capital", 3 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 30, "3200", 0, 0, "Preferred Stock", 3 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 29, "3100", 0, 0, "Common Stock", 3 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 28, "2900", 0, 0, "Other Liabilities", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 27, "2800", 0, 0, "Intercompany Payables", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 26, "2700", 0, 0, "Long-Term Debt", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 25, "2600", 0, 0, "Deferred Taxes", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 24, "2500", 0, 0, "Accrued Taxes", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 23, "2400", 0, 0, "Other Expenses", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 22, "2300", 0, 0, "Accrued Expenses", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 21, "2200", 0, 0, "Expenses", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 20, "2100", 0, 0, "Payables", 2 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 19, "1900", 0, 0, "Other Assets", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 18, "1800", 0, 0, "Intercompany Receivables", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 17, "1700", 0, 0, "Non-Current Receivables", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 16, "1600", 0, 0, "Depreciations & Amortizations", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 15, "1500", 0, 0, "Fixed Assets", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 14, "1400", 0, 0, "Prepaid Expenses", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 13, "1300", 0, 0, "Inventories", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 12, "1200", 0, 0, "Receivables", 1 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 35, "3800", 0, 0, "Current Earnings", 3 });

            migrationBuilder.InsertData(
                table: "AccountCategories",
                columns: new[] { "Id", "Code", "CreatedBy", "ModifiedBy", "Name", "TypeId" },
                values: new object[] { 36, "3900", 0, 0, "Retained Earnings", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AccountCategories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
