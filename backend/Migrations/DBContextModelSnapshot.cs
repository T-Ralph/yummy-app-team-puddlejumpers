﻿// <auto-generated />
using System;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = -4,
                            Name = "Striploin",
                            Quantity = 2m,
                            RecipeId = -2,
                            UOMId = "ea"
                        },
                        new
                        {
                            Id = -5,
                            Name = "Sweet Potato",
                            Quantity = 3m,
                            RecipeId = -2,
                            UOMId = "ea"
                        },
                        new
                        {
                            Id = -6,
                            Name = "Barbeque Sauce",
                            Quantity = 4m,
                            RecipeId = -2,
                            UOMId = "tbsp"
                        });
                });

            modelBuilder.Entity("Api.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("MealTimeId")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

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
                            MealTimeId = "-2",
                            PlanId = -1
                        },
                        new
                        {
                            Id = -2,
                            MealTimeId = "-3",
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
                    b.Property<string>("Id")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("MealTime");

                    b.HasData(
                        new
                        {
                            Id = "-1",
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = "-2",
                            Name = "Lunch"
                        },
                        new
                        {
                            Id = "-3",
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
                            Day = new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Local),
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
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Notes")
                        .HasColumnType("varchar(500)");

                    b.Property<decimal>("PrepTime")
                        .HasColumnType("decimal(10, 3)");

                    b.Property<int>("Protein")
                        .HasColumnType("int(10)");

                    b.Property<int>("Servings")
                        .HasColumnType("int(10)");

                    b.Property<string>("Tags")
                        .HasColumnType("json");

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
                            DateCreated = new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            DateModified = new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Fat = 30,
                            Instructions = @"* Cook Chicken
* Cook Potatoes
* Smother in Hot Sauce",
                            Name = "Chicken and Potatoes with Hot Sauce",
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
                            DateCreated = new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            DateModified = new DateTime(2020, 11, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Fat = 10,
                            Instructions = @"* Cook Chicken
* Cook Potatoes
* Smother in Hot Sauce",
                            Name = "Steak and Sweet Potatoes",
                            PrepTime = 25m,
                            Protein = 70,
                            Servings = 2,
                            Tags = "[\"BBQ\"]"
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
                            Id = "Cup",
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Email = "phprox123@gmail.com",
                            Name = "TestAdminWarren",
                            Password = "$uper$ecurePHPa$$w0rd",
                            PasswordSalt = "$alt33"
                        });
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
#pragma warning restore 612, 618
        }
    }
}
