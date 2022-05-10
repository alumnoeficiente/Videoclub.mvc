using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace videoclub_mvc.Migrations
{
    /// <inheritdoc />
    public partial class FillMembershipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) values (1,0,1,10)");
            migrationBuilder.Sql("Insert into MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) values (2,30,1,10)");
            migrationBuilder.Sql("Insert into MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) values (3,98,3,15)");
            migrationBuilder.Sql("Insert into MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) values (4,200,12,20)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete * From MembershipType");
        }
    }
}
