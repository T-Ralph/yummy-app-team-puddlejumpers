﻿// <auto-generated />
using System;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20201129004756_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(10, 3)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int(10)");

                    b.Property<string>("UOMId")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UOMId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Chicken Breast",
                            Quantity = 3m,
                            RecipeId = -1,
                            UOMId = "lb"
                        },
                        new
                        {
                            Id = -2,
                            Name = "Hot Sauce",
                            Quantity = 1m,
                            RecipeId = -1,
                            UOMId = "cup"
                        },
                        new
                        {
                            Id = -3,
                            Name = "Poatato",
                            Quantity = 4m,
                            RecipeId = -1,
                            UOMId = "ea"
                        },
                        new
                        {
                            Id = -7,
                            Name = "Olive Oil",
                            Quantity = 6m,
                            RecipeId = -3,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -8,
                            Name = "Garlic cloves",
                            Quantity = 5m,
                            RecipeId = -3,
                            UOMId = "ea"
                        },
                        new
                        {
                            Id = -9,
                            Name = "Yellow onion",
                            Quantity = 2m,
                            RecipeId = -3,
                            UOMId = "ea"
                        },
                        new
                        {
                            Id = -10,
                            Name = "ghee",
                            Quantity = 0.5m,
                            RecipeId = -3,
                            UOMId = "cup"
                        },
                        new
                        {
                            Id = -11,
                            Name = "Tomato paste",
                            Quantity = 3m,
                            RecipeId = -3,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -12,
                            Name = "Tumeric",
                            Quantity = 3m,
                            RecipeId = -3,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -13,
                            Name = "Chili powder",
                            Quantity = 2m,
                            RecipeId = -3,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -14,
                            Name = "Garam masala",
                            Quantity = 2m,
                            RecipeId = -3,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -15,
                            Name = "Ground coriander",
                            Quantity = 2m,
                            RecipeId = -3,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -16,
                            Name = "Ground cumin",
                            Quantity = 2m,
                            RecipeId = -3,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -17,
                            Name = "Tomato puree",
                            Quantity = 3.5m,
                            RecipeId = -3,
                            UOMId = "cup"
                        },
                        new
                        {
                            Id = -18,
                            Name = "Chicken Breast",
                            Quantity = 4m,
                            RecipeId = -3,
                            UOMId = "ea"
                        },
                        new
                        {
                            Id = -19,
                            Name = "Heavy Cream",
                            Quantity = 2m,
                            RecipeId = -3,
                            UOMId = "cup"
                        },
                        new
                        {
                            Id = -20,
                            Name = "Unsalted butter",
                            Quantity = 8m,
                            RecipeId = -3,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -21,
                            Name = "Cooked Jasmine Rice",
                            Quantity = 5m,
                            RecipeId = -3,
                            UOMId = "cup"
                        },
                        new
                        {
                            Id = -22,
                            Name = "Black Beans",
                            Quantity = 15m,
                            RecipeId = -4,
                            UOMId = "oz"
                        },
                        new
                        {
                            Id = -23,
                            Name = "Shredded Monterey Jack Cheese",
                            Quantity = 0.5m,
                            RecipeId = -4,
                            UOMId = "cup"
                        },
                        new
                        {
                            Id = -24,
                            Name = "Salsa",
                            Quantity = 0.5m,
                            RecipeId = -4,
                            UOMId = "cup"
                        },
                        new
                        {
                            Id = -25,
                            Name = "Tortillas",
                            Quantity = 4m,
                            RecipeId = -4,
                            UOMId = "ea"
                        },
                        new
                        {
                            Id = -26,
                            Name = "Canola oil",
                            Quantity = 2m,
                            RecipeId = -4,
                            UOMId = "tsp"
                        },
                        new
                        {
                            Id = -27,
                            Name = "Avocado, diced",
                            Quantity = 1m,
                            RecipeId = -4,
                            UOMId = "ea"
                        },
                        new
                        {
                            Id = -28,
                            Name = "Orange juice concentrate",
                            Quantity = 2m,
                            RecipeId = -5,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -29,
                            Name = "Finely chopped chipotle peppers(See notes)",
                            Quantity = 1m,
                            RecipeId = -5,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -30,
                            Name = "Balsamic Vinegar",
                            Quantity = 1m,
                            RecipeId = -5,
                            UOMId = "tbsp"
                        },
                        new
                        {
                            Id = -31,
                            Name = "Unsulfured Molasses",
                            Quantity = 2m,
                            RecipeId = -5,
                            UOMId = "tsp"
                        },
                        new
                        {
                            Id = -32,
                            Name = "Dijon mustard",
                            Quantity = 1m,
                            RecipeId = -5,
                            UOMId = "tsp"
                        },
                        new
                        {
                            Id = -33,
                            Name = "Chicken Breast",
                            Quantity = 1m,
                            RecipeId = -5,
                            UOMId = "lb"
                        },
                        new
                        {
                            Id = -34,
                            Name = "Salt",
                            Quantity = 1m,
                            RecipeId = -5,
                            UOMId = "tsp"
                        });
                });

            modelBuilder.Entity("Api.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<int>("MealTimeId")
                        .HasColumnType("int(10)");

                    b.Property<int>("PlanId")
                        .HasColumnType("int(10)");

                    b.HasKey("Id");

                    b.HasIndex("MealTimeId");

                    b.HasIndex("PlanId");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            MealTimeId = -2,
                            PlanId = -1
                        },
                        new
                        {
                            Id = -2,
                            MealTimeId = -3,
                            PlanId = -1
                        });
                });

            modelBuilder.Entity("Api.Models.MealRecipe", b =>
                {
                    b.Property<int>("MealId")
                        .HasColumnType("int(10)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int(10)");

                    b.HasKey("MealId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("MealsRecipes");

                    b.HasData(
                        new
                        {
                            MealId = -1,
                            RecipeId = -1
                        },
                        new
                        {
                            MealId = -2,
                            RecipeId = -2
                        });
                });

            modelBuilder.Entity("Api.Models.MealTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("MealTime");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = -2,
                            Name = "Lunch"
                        },
                        new
                        {
                            Id = -3,
                            Name = "Dinner"
                        });
                });

            modelBuilder.Entity("Api.Models.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<DateTime>("Day")
                        .HasColumnType("date");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Plan");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Day = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            UserId = "-1"
                        });
                });

            modelBuilder.Entity("Api.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<int>("Calories")
                        .HasColumnType("int(10)");

                    b.Property<int>("Carbohydrates")
                        .HasColumnType("int(10)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int(10)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("date");

                    b.Property<int>("Fat")
                        .HasColumnType("int(10)");

                    b.Property<string>("Image")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)")
                        .HasDefaultValue("");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Notes")
                        .HasColumnType("varchar(5000)");

                    b.Property<decimal>("PrepTime")
                        .HasColumnType("decimal(10, 3)");

                    b.Property<int>("Protein")
                        .HasColumnType("int(10)");

                    b.Property<int>("Servings")
                        .HasColumnType("int(10)");

                    b.Property<string>("Tags")
                        .HasColumnType("json");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Calories = 860,
                            Carbohydrates = 100,
                            CategoryId = -1,
                            DateCreated = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            DateModified = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Fat = 30,
                            Image = "",
                            Instructions = @"* Cook Chicken
* Cook Potatoes
* Smother in Hot Sauce",
                            Name = "Chicken and Potatoes with Hot Sauce",
                            Notes = "* Marinate Chicken for at least 12 hours for maximum flavor",
                            PrepTime = 35m,
                            Protein = 70,
                            Servings = 2,
                            Tags = "[\"Spicy\"]"
                        },
                        new
                        {
                            Id = -2,
                            Calories = 770,
                            Carbohydrates = 115,
                            CategoryId = -2,
                            DateCreated = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            DateModified = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Fat = 10,
                            Image = "",
                            Instructions = @"* Cook Steak on BBQ
* Cook Potatoes to personal preference
* Serve and Enjoy!",
                            Name = "Steak and Sweet Potatoes",
                            Notes = @"* Marinate Steak for at least 12 hours for maximum flavor
* Can be cooked on the stovetop but is better when BBQ'd
* Potatoes can be diced, sliced, or baked. Personal preference.",
                            PrepTime = 25m,
                            Protein = 70,
                            Servings = 2,
                            Tags = "[\"BBQ\"]"
                        },
                        new
                        {
                            Id = -3,
                            Calories = 222,
                            Carbohydrates = 10,
                            CategoryId = -1,
                            DateCreated = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            DateModified = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Fat = 11,
                            Image = "",
                            Instructions = @"* 1. Place the olive oil, garlic, chilies, onion, and ginger in a blender and purée until smooth.
* 2. Heat ghee in a large dutch oven over medium-high. Add the onion purée and cook until the mixture darkens slightly and softens, about 15 minutes.
* 3. Add the tomato paste, turmeric, chili powder, garam masala, coriander, and cumin and cook for 5 minutes, or until dark and sticky.
* 4. Add in 1 1/2 cups water. Using a wooden spoon, scrape up any browned bits at the bottom of the pan.
* 5. Stir in the tomato puree and fenugreek leaves and increase the heat to high. Bring to a boil, then reduce the heat to maintain a simmer. Cover and cook, stirring occasionally, until thick, about 1 hour. Add the chicken and cook until the chicken is cooked through, about 15 minutes more.
* 6. Add the cream and butter and stir to combine. Season with salt and serve garnished with fresh cilantro with steamed Jasmine rice.",
                            Name = "Butter Chicken",
                            Notes = "* Delicious!",
                            PrepTime = 65m,
                            Protein = 20,
                            Servings = 8,
                            Tags = "[\"Chicken, Dinner, Easy\"]"
                        },
                        new
                        {
                            Id = -4,
                            Calories = 375,
                            Carbohydrates = 45,
                            CategoryId = -4,
                            DateCreated = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            DateModified = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Fat = 16,
                            Image = "",
                            Instructions = @"* 1. Combine beans, cheese and 1/4 cup salsa in a medium bowl.
* 2. Place tortillas on a work surface.
* 3. Spread 1/2 cup filling on half of each tortilla.
* 4. Fold tortillas in half, pressing gently to flatten.
* 5. Heat 1 teaspoon oil in a large nonstick skillet over medium heat.
* 6. Add 2 quesadillas and cook, turning once, until golden on both sides, 2 to 4 minutes total.
* 7. Transfer to a cutting board and tent with foil to keep warm. Repeat with the remaining 1 teaspoon oil and quesadillas.
* 8. Serve the quesadillas with avocado and the remaining salsa.",
                            Name = "Black Bean Quesadillas",
                            Notes = "Tip: Look for prepared fresh salsa in the supermarket refrigerator section near other dips and spreads.",
                            PrepTime = 25m,
                            Protein = 13,
                            Servings = 4,
                            Tags = "[\"Low calorie, High fiber, Vegetarian\"]"
                        },
                        new
                        {
                            Id = -5,
                            Calories = 148,
                            Carbohydrates = 6,
                            CategoryId = -1,
                            DateCreated = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            DateModified = new DateTime(2020, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Fat = 3,
                            Image = "",
                            Instructions = @"* 1. Preheat grill or broiler.
* 2. Whisk together orange-juice concentrate, chipotle pepper, vinegar, molasses and mustard in a small bowl.
* 3. Lightly oil the grill or broiler rack (see Tip).
* 4. Season chicken with salt and grill or broil for 2 minutes.
* 5. Turn, brush with the glaze and cook for 4 minutes, brushing occasionally with glaze.
* 6. Turn again, brush with the glaze, and cook until the center is no longer pink, 1 to 2 minutes longer.",
                            Name = "Chipotle and Orange grilled Chicken",
                            Notes = @"* Chipotle chiles in adobo sauce are smoked jalapeños packed in a flavorful sauce.
* Look for the small cans with the Mexican foods in large supermarkets.
* Once opened, they'll keep up to 2 weeks in the refrigerator or 6 months in the freezer.
* Tip: To oil a grill rack: Oil a folded paper towel, hold it with tongs and rub it over the rack. (Do not use cooking spray on a hot grill.)
* When grilling delicate foods like tofu and fish, it is helpful to spray the food with cooking spray.",
                            PrepTime = 45m,
                            Protein = 23,
                            Servings = 4,
                            Tags = "[\"Low calorie, Low fat, Low Sodium\"]"
                        });
                });

            modelBuilder.Entity("Api.Models.RecipeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RecipeCategories");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Chicken"
                        },
                        new
                        {
                            Id = -2,
                            Name = "Beef"
                        },
                        new
                        {
                            Id = -3,
                            Name = "Fish"
                        },
                        new
                        {
                            Id = -4,
                            Name = "Vegetarian"
                        },
                        new
                        {
                            Id = -5,
                            Name = "Vegan"
                        });
                });

            modelBuilder.Entity("Api.Models.UOM", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("UOM");

                    b.HasData(
                        new
                        {
                            Id = "g",
                            Name = "Gram"
                        },
                        new
                        {
                            Id = "oz",
                            Name = "Ounce"
                        },
                        new
                        {
                            Id = "ml",
                            Name = "Milliliter"
                        },
                        new
                        {
                            Id = "L",
                            Name = "Liter"
                        },
                        new
                        {
                            Id = "cup",
                            Name = "Cup"
                        },
                        new
                        {
                            Id = "tsp",
                            Name = "Teaspoon"
                        },
                        new
                        {
                            Id = "tbsp",
                            Name = "Tablespoon"
                        },
                        new
                        {
                            Id = "lb",
                            Name = "Pound"
                        },
                        new
                        {
                            Id = "kg",
                            Name = "Kilogram"
                        },
                        new
                        {
                            Id = "ea",
                            Name = "Each"
                        });
                });

            modelBuilder.Entity("Api.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "dc42cb55-4f73-418b-9dc5-3bb91e413700",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9c244e57-d31d-446d-b785-0402c6de6daf",
                            Email = "phprox123@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "TestAdminWarren",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b5e012d2-e9af-4428-8790-f741ff9e4e6d",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Api.Models.Ingredient", b =>
                {
                    b.HasOne("Api.Models.Recipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Models.UOM", "UOM")
                        .WithMany()
                        .HasForeignKey("UOMId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Api.Models.Meal", b =>
                {
                    b.HasOne("Api.Models.MealTime", "MealTime")
                        .WithMany()
                        .HasForeignKey("MealTimeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Api.Models.Plan", null)
                        .WithMany("Meals")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api.Models.MealRecipe", b =>
                {
                    b.HasOne("Api.Models.Meal", "Meal")
                        .WithMany("MealRecipes")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Models.Recipe", "Recipe")
                        .WithMany("MealRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api.Models.Recipe", b =>
                {
                    b.HasOne("Api.Models.RecipeCategory", "RecipeCategory")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Api.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
