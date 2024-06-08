using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeepFoodDiary.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100000, 1"),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AdminName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10000, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "5000, 1"),
                    MealName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "50000, 1"),
                    UserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carbonhydrate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Measurement = table.Column<float>(type: "real", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PortionType = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    TotalCalorie = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFoodMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakenCalorie = table.Column<int>(type: "int", nullable: false),
                    MealEateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoodMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFoodMeals_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoodMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoodMeals_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminName", "CreatedDate", "DeletedDate", "ModifiedDate", "Password", "Status" },
                values: new object[] { 100000, "fooddiary", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(3994), null, null, "123456", 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 10000, "Vegetable", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4161), null, null, 1 },
                    { 10001, "Fruits", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4165), null, null, 1 },
                    { 10002, "DairyProducts", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4166), null, null, 1 },
                    { 10003, "MeatProducts", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4167), null, null, 1 },
                    { 10004, "FishandSeafood", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4167), null, null, 1 },
                    { 10005, "Legumes", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4168), null, null, 1 },
                    { 10006, "Grains", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4169), null, null, 1 },
                    { 10007, "SugarsAndSweets", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4170), null, null, 1 },
                    { 10008, "Beverages", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4171), null, null, 1 },
                    { 10009, "Soups ", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4171), null, null, 1 },
                    { 10010, "BakeryProducts", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4172), null, null, 1 },
                    { 10011, "SpicesAndSauces", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4173), null, null, 1 },
                    { 10012, "Snack", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4174), null, null, 1 },
                    { 10013, "AlcoholicBeverages", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4174), null, null, 1 },
                    { 10014, "Salad", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4175), null, null, 1 },
                    { 10015, "Main Food", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4176), null, null, 1 },
                    { 10016, "For Breakfast", new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4176), null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "MealName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 5000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4806), null, "Breakfast", null, 0 },
                    { 5001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4811), null, "Dinner", null, 0 },
                    { 5002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4812), null, "Lunch", null, 0 },
                    { 5003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4813), null, "Snack", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "ModifiedDate", "Password", "SecurityCode", "Status", "UserName", "UserPicture" },
                values: new object[,]
                {
                    { 50000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4974), null, null, "123.MErve**", "070424", 1, "mervesratekcan@gmail.com", null },
                    { 50001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4977), null, null, "123.KErem**", "070794", 1, "alikeremkaya@gmail.com", null },
                    { 50002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4978), null, null, "123.MUsa**", "112233", 1, "musayasirkece@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calorie", "Carbonhydrate", "CategoryId", "CreatedDate", "DeletedDate", "Fat", "FoodName", "Measurement", "ModifiedDate", "Picture", "PortionType", "Protein", "Status" },
                values: new object[,]
                {
                    { 1, 34.0, "6.6", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4256), null, "0.4", "Broccoli ", 100f, null, null, 9, "2.8", 0 },
                    { 2, 25.0, "5  ", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4260), null, "0.3 ", "Cauliflower  ", 100f, null, null, 9, "1.9", 0 },
                    { 3, 41.0, "9.6", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4262), null, "0.2", "Carrot", 100f, null, null, 9, "0.9", 0 },
                    { 4, 23.0, "3.6 ", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4263), null, "0.4", "Spinach  ", 100f, null, null, 9, "2.9", 0 },
                    { 5, 17.0, "3.1 ", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4265), null, "0.3  ", "Zucchini  ", 100f, null, null, 9, "1.2", 0 },
                    { 6, 25.0, "6", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4270), null, "0.2", "Eggplant  ", 100f, null, null, 9, "1", 0 },
                    { 7, 18.0, "3.9", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4272), null, "0.2 ", "Tomato", 100f, null, null, 9, "0.9", 0 },
                    { 8, 40.0, "9.3", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4274), null, "0.1", "Onion", 100f, null, null, 9, "1.1", 0 },
                    { 9, 22.0, "3.3", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4275), null, "0.3", "Mushroom", 100f, null, null, 9, "3.1", 0 },
                    { 10, 25.0, "5.8", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4276), null, "0.1", "Cabbage", 100f, null, null, 9, "1.3", 0 },
                    { 11, 43.0, "8.9 ", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4277), null, "0.3", "Brussels Sprouts ", 100f, null, null, 9, "3.4", 0 },
                    { 12, 31.0, "6", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4279), null, "0.3", "Red Bell Pepper ", 100f, null, null, 9, "1", 0 },
                    { 13, 20.0, "4.6", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4281), null, "0.2", "Green Bell Pepper ", 100f, null, null, 9, "0.9", 0 },
                    { 14, 20.0, "3.9", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4282), null, "0.1", "Asparagus", 100f, null, null, 9, "2.2", 0 },
                    { 15, 61.0, "14.2", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4283), null, "0.3", "Leeks", 100f, null, null, 9, "1.5", 0 },
                    { 16, 16.0, "3", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4285), null, "0.2", "Celery", 100f, null, null, 9, "0.7", 0 },
                    { 17, 86.0, "20.1", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4286), null, "0.1", "Potatoes", 100f, null, null, 9, "1.6", 0 },
                    { 18, 47.0, "10.5", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4287), null, "0.2", "Artichokes", 100f, null, null, 9, "3.3", 0 },
                    { 19, 45.0, "11.7", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4288), null, "0.1", "Butternut Squash", 100f, null, null, 9, "1", 0 },
                    { 20, 81.0, "14.5", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4289), null, "0.4", "Peas", 100f, null, null, 9, "5.4", 0 },
                    { 21, 33.0, "7.5", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4291), null, "0.2", "Okra", 100f, null, null, 9, "1.9", 0 },
                    { 22, 16.0, "3.4", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4293), null, "0.1", "Radishes", 100f, null, null, 9, "0.7", 0 },
                    { 23, 149.0, "33", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4294), null, "0.5", "Garlic", 100f, null, null, 9, "6.4", 0 },
                    { 24, 28.0, "6.4", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4295), null, "0.1", "Turnips", 100f, null, null, 9, "0.9", 0 },
                    { 25, 43.0, "10", 10000, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4297), null, "0.2", "Beetroot ", 100f, null, null, 9, "1.6", 0 },
                    { 26, 52.0, "14g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4298), null, "0.2g", "Apple", 1f, null, null, 4, "0.3g", 0 },
                    { 27, 89.0, "23g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4299), null, "0.3g", "Banana", 1f, null, null, 4, "1.1g", 0 },
                    { 28, 50.0, "12g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4300), null, "0.3g", "Cherries", 100f, null, null, 9, "1g", 0 },
                    { 29, 30.0, "8g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4302), null, "0.2g", "Watermelon", 100f, null, null, 9, "0.6g", 0 },
                    { 30, 60.0, "15g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4303), null, "0.4g", "Mango", 100f, null, null, 9, "0.8g", 0 },
                    { 31, 57.0, "14g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4304), null, "0.3g", "Blueberries", 100f, null, null, 9, "0.7g", 0 },
                    { 32, 160.0, "9g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4305), null, "15g", "Avocado", 100f, null, null, 9, "2g", 0 },
                    { 33, 39.0, "10g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4307), null, "0.3g", "Peach", 1f, null, null, 4, "0.9g", 0 },
                    { 34, 32.0, "8g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4308), null, "0.3g", "Strawberries", 100f, null, null, 9, "0.7g", 0 },
                    { 35, 50.0, "13g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4309), null, "0.1g", "Pineapple", 100f, null, null, 9, "0.5g", 0 },
                    { 36, 34.0, "8.2g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4310), null, "0.2g", "Cantaloupe", 100f, null, null, 9, "0.8g", 0 },
                    { 37, 36.0, "9g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4312), null, "0.1g", "Honeydew Melon", 100f, null, null, 9, "0.5g", 0 },
                    { 38, 61.0, "14.7g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4314), null, "0.5g", "Kiwi", 1f, null, null, 4, "1.1g", 0 },
                    { 39, 60.0, "13g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4315), null, "0.2g", "Dragon Fruit", 100f, null, null, 9, "1.2g", 0 },
                    { 40, 66.0, "16.5g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4316), null, "0.4g", "Lychee", 100f, null, null, 9, "0.8g", 0 },
                    { 41, 43.0, "10g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4317), null, "0.5g", "Blackberries", 100f, null, null, 9, "1.4g", 0 },
                    { 42, 52.0, "12g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4318), null, "0.7g", "Raspberries", 100f, null, null, 9, "1.2g", 0 },
                    { 43, 83.0, "19g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4320), null, "1.2g", "Pomegranate", 100f, null, null, 9, "1.7g", 0 },
                    { 44, 97.0, "23g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4321), null, "0.7g", "Passion Fruit", 1f, null, null, 4, "2.2g", 0 },
                    { 45, 73.0, "18g", 10001, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4326), null, "0.6g", "Mangosteen", 100f, null, null, 9, "0.5g", 0 },
                    { 46, 150.0, "12g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4327), null, "8g", "Whole Milk", 240f, null, null, 2, "8g", 0 },
                    { 47, 154.0, "17g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4328), null, "3.5g", "Plain Yogurt", 245f, null, null, 8, "13g", 0 },
                    { 48, 113.0, "0.4g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4330), null, "9g", "Cheddar Cheese", 28f, null, null, 3, "7g", 0 },
                    { 49, 102.0, "0.01g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4331), null, "11.5g", "Butter", 14f, null, null, 1, "0.1g", 0 },
                    { 50, 207.0, "24g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4332), null, "11g", "Ice Cream", 100f, null, null, 6, "3.5g", 0 },
                    { 51, 85.0, "1g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4334), null, "6g", "Mozzarella Cheese", 30f, null, null, 3, "6g", 0 },
                    { 52, 98.0, "3.4g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4336), null, "4.3g", "Cottage Cheese", 100f, null, null, 9, "11g", 0 },
                    { 53, 264.0, "4g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4337), null, "21g", "Feta Cheese", 100f, null, null, 9, "14g", 0 },
                    { 54, 83.0, "12g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4338), null, "0.2g", "Skim Milk", 240f, null, null, 2, "8g", 0 },
                    { 55, 30.0, "1g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4339), null, "2.5g", "Almond Milk", 240f, null, null, 2, "1g", 0 },
                    { 56, 59.0, "3.6g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4341), null, "0.4g", "Greek Yogurt", 100f, null, null, 9, "10g", 0 },
                    { 57, 55.0, "7g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4342), null, "2g", "Kefir", 240f, null, null, 2, "3g", 0 },
                    { 58, 102.0, "18g", 10002, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4343), null, "1.5g", "Flavored Yogurt (Strawberry)", 150f, null, null, 8, "4g", 0 },
                    { 59, 271.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4344), null, "18g", "Beef Steak", 100f, null, null, 9, "26g", 0 },
                    { 60, 165.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4345), null, "3.6g", "Chicken Breast", 100f, null, null, 9, "31g", 0 },
                    { 61, 231.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4347), null, "13g", "Pork Chop", 100f, null, null, 9, "29g", 0 },
                    { 62, 135.0, "3.8g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4348), null, "1.7g", "Turkey Slices", 100f, null, null, 9, "29g", 0 },
                    { 63, 336.0, "2.4g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4349), null, "26g", "Salami", 50f, null, null, 3, "22g", 0 },
                    { 64, 541.0, "1.4g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4350), null, "42g", "Bacon", 100f, null, null, 9, "37g", 0 },
                    { 65, 291.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4356), null, "21g", "Lamb Leg", 100f, null, null, 9, "25g", 0 },
                    { 66, 337.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4358), null, "25g", "Duck Breast", 100f, null, null, 9, "27g", 0 },
                    { 67, 271.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4359), null, "19g", "Ribeye Steak", 100f, null, null, 9, "24g", 0 },
                    { 68, 250.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4360), null, "15g", "Sirloin Steak", 100f, null, null, 9, "26g", 0 },
                    { 69, 215.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4361), null, "11g", "Ground Beef (85% lean)", 100f, null, null, 9, "26g", 0 },
                    { 70, 209.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4363), null, "11g", "Chicken Thighs", 100f, null, null, 9, "26g", 0 },
                    { 71, 172.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4364), null, "5.7g", "Chicken Drumsticks", 100f, null, null, 9, "28g", 0 },
                    { 72, 203.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4365), null, "8.1g", "Chicken Wings", 100f, null, null, 9, "30g", 0 },
                    { 73, 158.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4366), null, "3.2g", "Venison (Deer Meat)", 100f, null, null, 9, "30g", 0 },
                    { 74, 135.0, "0g", 10003, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4368), null, "0.7g", "Roast Turkey Breast", 100f, null, null, 9, "30g", 0 },
                    { 75, 208.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4369), null, "13g", "Salmon Fillet", 100f, null, null, 9, "20g", 0 },
                    { 76, 184.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4371), null, "8g", "Tuna Steak", 100f, null, null, 9, "25g", 0 },
                    { 77, 99.0, "0.2g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4372), null, "0.3g", "Shrimp", 100f, null, null, 9, "24g", 0 },
                    { 78, 111.0, "5g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4373), null, "0.5g", "Scallops", 100f, null, null, 9, "21g", 0 },
                    { 79, 89.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4374), null, "0.6g", "Lobster", 100f, null, null, 9, "19g", 0 },
                    { 80, 97.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4377), null, "1g", "Crab Meat", 100f, null, null, 9, "21g", 0 },
                    { 81, 82.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4378), null, "0.7g", "Cod Fillet", 100f, null, null, 9, "18g", 0 },
                    { 82, 172.0, "7g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4379), null, "4g", "Mussels", 100f, null, null, 9, "24g", 0 },
                    { 83, 208.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4381), null, "11g", "Sardines", 100f, null, null, 9, "25g", 0 },
                    { 84, 90.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4382), null, "0.7g", "Haddock", 100f, null, null, 9, "20g", 0 },
                    { 85, 140.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4387), null, "3g", "Halibut", 100f, null, null, 9, "27g", 0 },
                    { 86, 68.0, "4g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4388), null, "2g", "Oysters", 100f, null, null, 9, "7g", 0 },
                    { 87, 164.0, "4g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4389), null, "2g", "Octopus", 100f, null, null, 9, "30g", 0 },
                    { 88, 148.0, "5g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4391), null, "2g", "Clams", 100f, null, null, 9, "26g", 0 },
                    { 89, 210.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4392), null, "10g", "Anchovies", 50f, null, null, 9, "29g", 0 },
                    { 90, 86.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4393), null, "1g", "Flounder", 100f, null, null, 9, "18g", 0 },
                    { 91, 97.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4394), null, "2g", "Sea Bass", 100f, null, null, 9, "20g", 0 },
                    { 92, 119.0, "0g", 10004, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4396), null, "5g", "Rainbow Trout", 100f, null, null, 9, "20g", 0 },
                    { 93, 116.0, "20g", 10005, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4397), null, "0.4g", "Lentils", 100f, null, null, 9, "9g", 0 },
                    { 94, 164.0, "27g", 10005, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4399), null, "2.6g", "Chickpeas", 100f, null, null, 9, "9g", 0 },
                    { 95, 132.0, "24g", 10005, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4400), null, "0.5g", "Black Beans", 100f, null, null, 9, "9g", 0 },
                    { 96, 127.0, "22g", 10005, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4402), null, "0.5g", "Kidney Beans", 100f, null, null, 9, "9g", 0 },
                    { 97, 81.0, "14g", 10005, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4403), null, "0.4g", "Green Peas", 100f, null, null, 9, "5g", 0 },
                    { 98, 173.0, "10g", 10005, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4404), null, "9g", "Soybeans", 100f, null, null, 9, "17g", 0 },
                    { 99, 140.0, "26g", 10005, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4406), null, "0.6g", "Navy Beans", 100f, null, null, 9, "8g", 0 },
                    { 100, 143.0, "27g", 10005, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4407), null, "0.6g", "Pinto Beans", 100f, null, null, 9, "9g", 0 },
                    { 101, 112.0, "23.5g", 10006, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4408), null, "0.8g", "Brown Rice", 100f, null, null, 9, "2.6g", 0 },
                    { 102, 130.0, "28.6g", 10006, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4409), null, "0.3g", "White Rice", 100f, null, null, 9, "2.7g", 0 },
                    { 103, 120.0, "21.3g", 10006, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4411), null, "1.9g", "Quinoa", 100f, null, null, 9, "4.4g", 0 },
                    { 104, 389.0, "66.3g", 10006, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4412), null, "6.9g", "Oats", 100f, null, null, 9, "16.9g", 0 },
                    { 105, 354.0, "73.5g", 10006, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4413), null, "2.3g", "Barley", 100f, null, null, 9, "12.5g", 0 },
                    { 106, 86.0, "18.7g", 10006, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4414), null, "1.2g", "Corn", 100f, null, null, 9, "3.2g", 0 },
                    { 107, 343.0, "71.5g", 10006, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4416), null, "3.4g", "Buckwheat", 100f, null, null, 9, "13.3g", 0 },
                    { 108, 378.0, "72.9g", 10006, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4418), null, "4.3g", "Millet", 100f, null, null, 9, "11g", 0 },
                    { 109, 546.0, "61.7g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4419), null, "31g", "Chocolate Bar", 100f, null, null, 9, "4.9g", 0 },
                    { 110, 325.0, "77g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4421), null, "0.2g", "Gummy Bears", 100f, null, null, 9, "6.9g", 0 },
                    { 111, 394.0, "98g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4422), null, "0g", "Hard Candy", 100f, null, null, 9, "0g", 0 },
                    { 112, 305.0, "46.3g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4423), null, "12.1g", "Cupcake", 1f, null, null, 4, "2.7g", 0 },
                    { 113, 452.0, "51g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4424), null, "25g", "Donut", 1f, null, null, 4, "4.9g", 0 },
                    { 114, 376.0, "94g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4426), null, "0g", "Jelly Beans", 100f, null, null, 9, "0g", 0 },
                    { 115, 382.0, "78g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4427), null, "8.3g", "Caramel", 100f, null, null, 9, "4.2g", 0 },
                    { 116, 334.0, "56g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4428), null, "11g", "Baklava", 1f, null, null, 3, "5g", 0 },
                    { 117, 402.0, "48g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4433), null, "20g", "Künefe", 100f, null, null, 7, "9g", 0 },
                    { 118, 89.0, "22g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4434), null, "0g", "Lokum", 1f, null, null, 4, "0.2g", 0 },
                    { 119, 112.0, "18.4g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4435), null, "3.8g", "Şekerpare", 1f, null, null, 4, "1.9g", 0 },
                    { 120, 535.0, "59.4g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4436), null, "29.7g", "Milk Chocolate", 100f, null, null, 9, "7.6g", 0 },
                    { 121, 546.0, "61.7g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4438), null, "31g", "Dark Chocolate", 100f, null, null, 9, "4.9g", 0 },
                    { 122, 539.0, "59g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4439), null, "30g", "White Chocolate", 100f, null, null, 9, "6g", 0 },
                    { 123, 240.0, "24g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4441), null, "15g", "Tiramisu", 1f, null, null, 3, "4g", 0 },
                    { 124, 321.0, "25g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4447), null, "23g", "Cheesecake", 1f, null, null, 3, "6g", 0 },
                    { 125, 70.0, "9g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4449), null, "3.2g", "Macaron", 1f, null, null, 4, "1.2g", 0 },
                    { 126, 233.0, "24g", 10007, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4450), null, "13g", "Cannoli", 1f, null, null, 4, "4g", 0 },
                    { 127, 2.0, "0g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4451), null, "0g", "Coffee, black", 240f, null, null, 2, "0.3g", 0 },
                    { 128, 2.0, "0.3g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4452), null, "0g", "Tea, brewed", 240f, null, null, 2, "0g", 0 },
                    { 129, 150.0, "39g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4454), null, "0g", "Soda", 355f, null, null, 2, "0g", 0 },
                    { 130, 112.0, "26g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4455), null, "0.5g", "Orange Juice", 240f, null, null, 2, "1.7g", 0 },
                    { 131, 146.0, "11g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4456), null, "8g", "Milk, whole", 240f, null, null, 2, "7.9g", 0 },
                    { 132, 20.0, "3g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4457), null, "0.2g", "Espresso", 30f, null, null, 2, "0.2g", 0 },
                    { 133, 74.0, "6g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4459), null, "4g", "Cappuccino", 150f, null, null, 2, "4g", 0 },
                    { 134, 135.0, "12g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4460), null, "7g", "Latte Macchiato", 240f, null, null, 2, "8g", 0 },
                    { 135, 50.0, "12g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4461), null, "0.1g", "Iced Coffee", 240f, null, null, 2, "0.3g", 0 },
                    { 136, 0.0, "0g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4463), null, "0g", "Green Tea", 240f, null, null, 2, "0g", 0 },
                    { 137, 2.0, "0.3g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4465), null, "0g", "Black Tea", 240f, null, null, 2, "0g", 0 },
                    { 138, 2.0, "0.5g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4466), null, "0g", "Herbal Tea", 240f, null, null, 2, "0g", 0 },
                    { 139, 120.0, "22g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4467), null, "2.5g", "Chai Latte", 240f, null, null, 2, "4g", 0 },
                    { 140, 0.0, "0g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4469), null, "0g", "Mineral Water", 330f, null, null, 2, "0g", 0 },
                    { 141, 10.0, "2g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4470), null, "0g", "Flavored Sparkling Water, Lemon", 330f, null, null, 2, "0g", 0 },
                    { 142, 10.0, "2g", 10008, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4471), null, "0g", "Flavored Sparkling Water, Lime", 330f, null, null, 2, "0g", 0 },
                    { 143, 75.0, "8.5g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4472), null, "2.5g", "Chicken Noodle Soup", 240f, null, null, 6, "4.5g", 0 },
                    { 144, 85.0, "18.6g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4474), null, "0.4g", "Tomato Soup", 240f, null, null, 6, "1.5g", 0 },
                    { 145, 160.0, "15g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4475), null, "7g", "Beef Stew", 240f, null, null, 6, "11g", 0 },
                    { 146, 90.0, "17g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4476), null, "1g", "Minestrone", 240f, null, null, 6, "3g", 0 },
                    { 147, 201.0, "21g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4477), null, "8g", "Clam Chowder", 240f, null, null, 6, "16g", 0 },
                    { 148, 180.0, "30g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4479), null, "1g", "Lentil Soup", 240f, null, null, 6, "12g", 0 },
                    { 149, 206.0, "16.5g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4480), null, "12.5g", "Broccoli Cheese Soup", 240f, null, null, 6, "10g", 0 },
                    { 150, 224.0, "17g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4481), null, "14g", "French Onion Soup", 240f, null, null, 6, "8g", 0 },
                    { 151, 180.0, "20g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4482), null, "7g", "Mercimek Soup", 240f, null, null, 6, "9g", 0 },
                    { 152, 165.0, "25g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4485), null, "5g", "Ezogelin Soup", 240f, null, null, 6, "5g", 0 },
                    { 153, 90.0, "3g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4486), null, "4g", "İşkembe Soup", 240f, null, null, 6, "12g", 0 },
                    { 154, 140.0, "18g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4487), null, "6g", "Yayla Soup", 240f, null, null, 6, "6g", 0 },
                    { 155, 150.0, "25g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4488), null, "3g", "Tarhana Soup", 240f, null, null, 6, "5g", 0 },
                    { 156, 75.0, "8g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4490), null, "2g", "Tavuk Suyu Soup", 240f, null, null, 6, "6g", 0 },
                    { 157, 200.0, "0g", 10009, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4491), null, "15g", "Paça Soup", 240f, null, null, 6, "14g", 0 },
                    { 158, 100.0, "20g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4492), null, "2g", "Whole Wheat Bread", 1f, null, null, 3, "4g", 0 },
                    { 159, 175.0, "36g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4493), null, "1g", "Baguette", 58f, null, null, 3, "6g", 0 },
                    { 160, 235.0, "26g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4495), null, "12g", "Croissant", 1f, null, null, 4, "5g", 0 },
                    { 161, 303.0, "41g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4496), null, "13g", "Cinnamon Roll", 1f, null, null, 4, "5g", 0 },
                    { 162, 170.0, "33g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4497), null, "1g", "Sourdough Bread", 2f, null, null, 3, "6g", 0 },
                    { 163, 377.0, "51g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4498), null, "17g", "Muffin", 1f, null, null, 4, "5g", 0 },
                    { 164, 165.0, "33g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4504), null, "0.7g", "Pita Bread", 1f, null, null, 4, "5.5g", 0 },
                    { 165, 83.0, "15.5g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4505), null, "0.8g", "Rye Bread", 1f, null, null, 3, "2.7g", 0 },
                    { 166, 300.0, "52g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4512), null, "8g", "Brioche", 1f, null, null, 4, "6g", 0 },
                    { 167, 142.0, "27g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4513), null, "2.3g", "Focaccia", 1f, null, null, 3, "2.7g", 0 },
                    { 168, 180.0, "27g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4515), null, "7g", "Garlic Bread", 1f, null, null, 3, "5g", 0 },
                    { 169, 120.0, "20g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4516), null, "3.5g", "Crackers", 30f, null, null, 9, "2g", 0 },
                    { 170, 108.0, "22.5g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4517), null, "0.8g", "Pretzels", 1f, null, null, 4, "2.8g", 0 },
                    { 171, 79.0, "14.2g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4519), null, "0.8g", "Melba Toast", 4f, null, null, 3, "2.6g", 0 },
                    { 172, 410.0, "45g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4520), null, "23g", "Croissant, Almond", 1f, null, null, 4, "10g", 0 },
                    { 173, 290.0, "55g", 10010, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4521), null, "3.6g", "Simit", 1f, null, null, 4, "10g", 0 },
                    { 174, 255.0, "64g", 10011, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4522), null, "3.3g", "Black Pepper", 100f, null, null, 9, "10g", 0 },
                    { 175, 312.0, "67.1g", 10011, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4524), null, "3.3g", "Turmeric", 100f, null, null, 9, "9.7g", 0 },
                    { 176, 112.0, "27g", 10011, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4525), null, "0.1g", "Ketchup", 100f, null, null, 9, "1.2g", 0 },
                    { 177, 680.0, "2g", 10011, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4526), null, "75g", "Mayonnaise", 100f, null, null, 9, "1g", 0 },
                    { 178, 247.0, "81g", 10011, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4527), null, "1.2g", "Cinnamon", 100f, null, null, 9, "4g", 0 },
                    { 179, 53.0, "4.9g", 10011, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4529), null, "0.6g", "Soy Sauce", 100f, null, null, 10, "4.9g", 0 },
                    { 180, 30.0, "7g", 10011, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4531), null, "0.2g", "Hot Sauce", 100f, null, null, 10, "1g", 0 },
                    { 181, 325.0, "58g", 10011, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4532), null, "14g", "Curry Powder", 100f, null, null, 9, "14g", 0 },
                    { 182, 547.0, "51.4g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4533), null, "36.4g", "Potato Chips", 100f, null, null, 9, "6.6g", 0 },
                    { 183, 607.0, "20g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4535), null, "54g", "Mixed Nuts", 100f, null, null, 9, "17g", 0 },
                    { 184, 387.0, "78g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4536), null, "4.5g", "Popcorn, Air-popped", 100f, null, null, 9, "13g", 0 },
                    { 185, 462.0, "56g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4537), null, "26g", "Trail Mix", 100f, null, null, 9, "13g", 0 },
                    { 186, 325.0, "76g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4539), null, "0g", "Fruit Snacks", 100f, null, null, 9, "0g", 0 },
                    { 187, 471.0, "64g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4540), null, "21g", "Granola Bar", 1f, null, null, 4, "10g", 0 },
                    { 188, 387.0, "81.3g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4541), null, "3.3g", "Rice Cake", 100f, null, null, 9, "8.4g", 0 },
                    { 189, 472.0, "62.5g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4542), null, "25g", "Vegetable Chips", 100f, null, null, 9, "2.5g", 0 },
                    { 190, 536.0, "50g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4544), null, "34g", "Cheese Puffs", 100f, null, null, 9, "7.6g", 0 },
                    { 191, 410.0, "11g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4545), null, "27g", "Beef Jerky", 100f, null, null, 9, "33g", 0 },
                    { 192, 614.0, "20g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4547), null, "56g", "Almond Butter", 100f, null, null, 9, "21g", 0 },
                    { 193, 515.0, "59g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4548), null, "30g", "Peanut Butter Cups", 1f, null, null, 4, "10g", 0 },
                    { 194, 584.0, "20g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4549), null, "51g", "Sunflower Seeds", 100f, null, null, 9, "20g", 0 },
                    { 195, 177.0, "14g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4551), null, "10g", "Hummus", 100f, null, null, 9, "8g", 0 },
                    { 196, 320.0, "70g", 10012, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4553), null, "7.5g", "Yogurt-Covered Raisins", 100f, null, null, 9, "2.8g", 0 },
                    { 197, 103.0, "6g", 10013, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4554), null, "0g", "Light Beer", 355f, null, null, 2, "1g", 0 },
                    { 198, 125.0, "3.8g", 10013, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4555), null, "0g", "Red Wine", 150f, null, null, 2, "0.1g", 0 },
                    { 199, 231.0, "0g", 10013, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4556), null, "0g", "Vodka", 100f, null, null, 2, "0g", 0 },
                    { 200, 70.0, "0g", 10013, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4558), null, "0g", "Whiskey", 45f, null, null, 2, "0g", 0 },
                    { 201, 263.0, "0g", 10013, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4559), null, "0g", "Gin", 100f, null, null, 2, "0g", 0 },
                    { 202, 87.0, "1.4g", 10013, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4560), null, "0g", "Champagne", 150f, null, null, 2, "0.3g", 0 },
                    { 203, 168.0, "11g", 10013, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4566), null, "0g", "Margarita", 120f, null, null, 2, "0g", 0 },
                    { 204, 231.0, "0g", 10013, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4568), null, "0g", "Rum", 100f, null, null, 2, "0g", 0 },
                    { 205, 180.0, "10g", 10014, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4569), null, "14g", "Caesar Salad", 100f, null, null, 7, "7g", 0 },
                    { 206, 106.0, "4.3g", 10014, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4570), null, "8.4g", "Greek Salad", 100f, null, null, 7, "2.9g", 0 },
                    { 207, 200.0, "5g", 10014, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4571), null, "16g", "Caprese Salad", 100f, null, null, 7, "8g", 0 },
                    { 208, 160.0, "15g", 10014, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4573), null, "10g", "Waldorf Salad", 100f, null, null, 7, "2g", 0 },
                    { 209, 233.0, "9g", 10014, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4575), null, "16g", "Cobb Salad", 100f, null, null, 7, "13g", 0 },
                    { 210, 105.0, "3g", 10014, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4576), null, "7g", "Nicoise Salad", 100f, null, null, 7, "7g", 0 },
                    { 211, 120.0, "20g", 10014, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4578), null, "3.5g", "Quinoa Salad", 100f, null, null, 7, "4g", 0 },
                    { 212, 290.0, "22g", 10014, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4579), null, "12g", "Southwest Chicken Salad", 100f, null, null, 7, "24g", 0 },
                    { 213, 250.0, "5g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4580), null, "15g", "Turkish Kebab", 1f, null, null, 7, "22g", 0 },
                    { 214, 270.0, "34g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4581), null, "10g", "Italian Pizza Margherita", 1f, null, null, 3, "11g", 0 },
                    { 215, 200.0, "42g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4583), null, "1g", "Japanese Sushi Roll", 8f, null, null, 4, "6g", 0 },
                    { 216, 260.0, "10g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4584), null, "14g", "Indian Chicken Curry", 100f, null, null, 7, "25g", 0 },
                    { 217, 156.0, "12g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4585), null, "8g", "Mexican Tacos", 1f, null, null, 4, "9g", 0 },
                    { 218, 90.0, "20g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4587), null, "0.4g", "French Ratatouille", 100f, null, null, 7, "1.2g", 0 },
                    { 219, 295.0, "30g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4588), null, "11g", "American Burger", 1f, null, null, 4, "17g", 0 },
                    { 220, 150.0, "18g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4589), null, "7g", "Greek Moussaka", 100f, null, null, 7, "8g", 0 },
                    { 221, 238.0, "38.3g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4590), null, "7.3g", "Chinese Fried Rice", 100f, null, null, 7, "5.6g", 0 },
                    { 222, 200.0, "10g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4592), null, "14g", "Turkish Menemen", 100f, null, null, 7, "12g", 0 },
                    { 223, 280.0, "31g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4598), null, "7g", "Spanish Paella", 100f, null, null, 7, "22g", 0 },
                    { 224, 310.0, "30g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4600), null, "9g", "Moroccan Tagine", 100f, null, null, 7, "35g", 0 },
                    { 225, 330.0, "18g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4601), null, "18g", "German Schnitzel", 100f, null, null, 7, "25g", 0 },
                    { 226, 150.0, "20g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4602), null, "8g", "Turkish İmam Bayıldı", 1f, null, null, 4, "3g", 0 },
                    { 227, 450.0, "40g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4604), null, "15g", "Vietnamese Pho", 1f, null, null, 6, "30g", 0 },
                    { 228, 280.0, "31g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4605), null, "13g", "Italian Lasagna", 100f, null, null, 7, "17g", 0 },
                    { 229, 560.0, "84g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4606), null, "18g", "Korean Bibimbap", 1f, null, null, 6, "22g", 0 },
                    { 230, 240.0, "10g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4607), null, "10g", "Ethiopian Doro Wat", 1f, null, null, 7, "28g", 0 },
                    { 231, 340.0, "30g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4609), null, "15g", "Brazilian Feijoada", 100f, null, null, 7, "25g", 0 },
                    { 232, 550.0, "40g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4610), null, "30g", "Classic Breakfast Burger", 1f, null, null, 4, "28g", 0 },
                    { 233, 600.0, "40g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4611), null, "35g", "Egg and Bacon Breakfast Burger", 1f, null, null, 4, "35g", 0 },
                    { 234, 500.0, "45g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4612), null, "25g", "Avocado and Turkey Breakfast Burger", 1f, null, null, 4, "30g", 0 },
                    { 235, 400.0, "50g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4614), null, "18g", "Vegetarian Breakfast Burger", 1f, null, null, 4, "18g", 0 },
                    { 236, 650.0, "40g", 10015, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4615), null, "40g", "Spicy Chorizo Breakfast Burger", 1f, null, null, 4, "32g", 0 },
                    { 237, 102.0, "19g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4616), null, "1.7g", "Porridge", 100f, null, null, 9, "2.5g", 0 },
                    { 238, 471.0, "64g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4619), null, "21g", "Granola", 100f, null, null, 9, "10g", 0 },
                    { 239, 155.0, "1.1g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4620), null, "11g", "Boiled Eggs", 2f, null, null, 4, "13g", 0 },
                    { 240, 149.0, "22g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4621), null, "4.5g", "French Toast", 1f, null, null, 3, "5g", 0 },
                    { 241, 149.0, "0.7g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4623), null, "8.3g", "Turkey Sausage", 1f, null, null, 4, "17g", 0 },
                    { 242, 115.0, "6g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4624), null, "10.7g", "Olive", 10f, null, null, 4, "0.8g", 0 },
                    { 243, 304.0, "82.4g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4630), null, "0g", "Honey", 100f, null, null, 9, "0.3g", 0 },
                    { 244, 205.0, "30g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4631), null, "7g", "Whole Wheat Waffles", 1f, null, null, 4, "6g", 0 },
                    { 245, 357.0, "84g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4632), null, "0.4g", "Cornflakes", 100f, null, null, 9, "7.5g", 0 },
                    { 246, 217.0, "24g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4634), null, "9g", "Breakfast Burrito", 1f, null, null, 4, "12g", 0 },
                    { 247, 289.0, "34g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4635), null, "13g", "Gözleme", 1f, null, null, 4, "9g", 0 },
                    { 248, 275.0, "25g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4636), null, "16g", "Börek", 1f, null, null, 3, "8g", 0 },
                    { 249, 250.0, "50g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4638), null, "1.5g", "Bagels", 1f, null, null, 4, "10g", 0 },
                    { 250, 209.0, "26g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4639), null, "7g", "Ricotta Pancakes", 3f, null, null, 4, "11g", 0 },
                    { 251, 289.0, "66g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4640), null, "4g", "Fruit Muesli", 100f, null, null, 9, "6g", 0 },
                    { 252, 143.0, "0.7g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4641), null, "9.5g", "Poached Eggs", 2f, null, null, 4, "12g", 0 },
                    { 253, 97.0, "10g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4643), null, "1g", "Cottage Cheese with Pineapple", 100f, null, null, 9, "11g", 0 },
                    { 254, 134.0, "13g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4644), null, "8g", "Chia Seed Pudding", 100f, null, null, 9, "4g", 0 },
                    { 255, 360.0, "29g", 10016, new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4645), null, "19g", "English Muffin with Egg and Cheese", 1f, null, null, 4, "19g", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "FullName", "Gender", "Height", "ModifiedDate", "Status", "TotalCalorie", "UserId", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(1993, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4874), null, "Merve Esra Tekcan", true, 170, null, 1, 1543f, 50000, 68 },
                    { 2, new DateTime(1994, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4880), null, "Ali Kerem Kaya", false, 175, null, 1, 2400f, 50001, 76 },
                    { 3, new DateTime(1995, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 3, 6, 32, 618, DateTimeKind.Local).AddTicks(4882), null, "Musa Yasir Keçe", false, 180, null, 1, 2700f, 50002, 74 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodName",
                table: "Foods",
                column: "FoodName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserId",
                table: "UserDetails",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodMeals_FoodID",
                table: "UserFoodMeals",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodMeals_MealId",
                table: "UserFoodMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodMeals_UserID",
                table: "UserFoodMeals",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "UserFoodMeals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
