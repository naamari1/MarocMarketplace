﻿// <auto-generated />
using System;
using Maroc.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Maroc.Infastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Maroc.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5af3834c-d02d-44a0-84cd-e97e97334db6"),
                            FirstName = "Anis"
                        },
                        new
                        {
                            Id = new Guid("c22bb1fa-fa61-4ef3-a37e-f09b119db5ae"),
                            FirstName = "Nouri"
                        });
                });

            modelBuilder.Entity("Maroc.Core.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a073be93-6967-44d8-a996-c59744b08317"),
                            Name = "Cookware"
                        },
                        new
                        {
                            Id = new Guid("6dcac4ff-8b23-4264-af27-1c3621ede620"),
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = new Guid("70ff1a49-b23b-4846-88fb-0b148b868c5c"),
                            Name = "Islam"
                        },
                        new
                        {
                            Id = new Guid("859e8fba-2671-43e3-ba07-628dce1a5fee"),
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = new Guid("c57bce6f-c3c7-4c16-87f8-d201e8d78bc6"),
                            Name = "Music"
                        },
                        new
                        {
                            Id = new Guid("e10ed622-437e-42c5-807c-a500f16627d3"),
                            Name = "Garden"
                        },
                        new
                        {
                            Id = new Guid("8f2070bf-09c4-4c8a-bbb6-656227e29c32"),
                            Name = "Bags"
                        },
                        new
                        {
                            Id = new Guid("aca908b1-a425-45c8-8621-5094cbbd0275"),
                            Name = "Personal Care"
                        },
                        new
                        {
                            Id = new Guid("09aec814-d61a-49c5-9825-0c6d5db827da"),
                            Name = "Decoration"
                        },
                        new
                        {
                            Id = new Guid("735c11f0-e003-46ac-8ac1-6a849716fc07"),
                            Name = "Lamps"
                        },
                        new
                        {
                            Id = new Guid("f9aaa1f3-e477-495e-b2cc-1c8cec8fbad4"),
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("219d12ff-5173-4cb7-9d08-c8d0bc050d6d"),
                            Name = "Home"
                        },
                        new
                        {
                            Id = new Guid("4a8bbfac-9a39-4fac-ba7a-ecc73405d6db"),
                            Name = "Games"
                        },
                        new
                        {
                            Id = new Guid("ce98178d-90db-4fe8-8b7d-3766f9dca364"),
                            Name = "Garden"
                        },
                        new
                        {
                            Id = new Guid("877191a7-5acd-4560-b327-1baab8dd450b"),
                            Name = "Home"
                        },
                        new
                        {
                            Id = new Guid("7e7c0e3a-d97b-4ebe-9f92-844550f1570b"),
                            Name = "Baby"
                        },
                        new
                        {
                            Id = new Guid("f53257ef-2537-45d8-bb6a-3c2b66c0e6bf"),
                            Name = "Handmade"
                        },
                        new
                        {
                            Id = new Guid("1a8f927b-b978-4d50-ac93-422dc26ae038"),
                            Name = "Jewelry"
                        },
                        new
                        {
                            Id = new Guid("84641041-2a1a-4988-93fa-716720338521"),
                            Name = "Shoes"
                        },
                        new
                        {
                            Id = new Guid("ed0b858d-6b97-4f32-8b5f-4c2a4ffb3ba3"),
                            Name = "Luggage"
                        },
                        new
                        {
                            Id = new Guid("562bbed0-2966-4929-9eaa-310b1e640438"),
                            Name = "Art"
                        },
                        new
                        {
                            Id = new Guid("d8e0908b-d5de-4945-994b-c4ccf2227d19"),
                            Name = "Antiques"
                        });
                });

            modelBuilder.Entity("Maroc.Core.Entities.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrentStock")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RecordLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fc747ad7-9ecb-49e8-9c03-af88fddcd7f7"),
                            CurrentStock = 5,
                            ProductId = new Guid("7f9985dc-3998-44e7-b1ec-17f9383d5e2a"),
                            RecordLevel = 1
                        },
                        new
                        {
                            Id = new Guid("0c821682-b640-4ab1-a7cb-04f7b22ed442"),
                            CurrentStock = 5,
                            ProductId = new Guid("8ae70984-8d34-4268-b05f-3a54cc7ba1d1"),
                            RecordLevel = 1
                        },
                        new
                        {
                            Id = new Guid("846824a0-f750-4985-a860-d72b45c5d4b2"),
                            CurrentStock = 5,
                            ProductId = new Guid("b40f6183-ce18-4905-af02-7b7b4e6d474f"),
                            RecordLevel = 1
                        },
                        new
                        {
                            Id = new Guid("e1f3f6af-b1e9-48f5-a3a7-472d8994b151"),
                            CurrentStock = 5,
                            ProductId = new Guid("445c1f8a-54a0-4588-a628-8c7a7cb61abc"),
                            RecordLevel = 1
                        });
                });

            modelBuilder.Entity("Maroc.Core.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalItems")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3a5ab519-d155-442c-843e-1751a0428af2"),
                            OrderDate = new DateTime(2024, 9, 1, 16, 22, 49, 684, DateTimeKind.Local).AddTicks(4080),
                            Status = "Processing",
                            TotalItems = 2,
                            UserId = new Guid("5af3834c-d02d-44a0-84cd-e97e97334db6")
                        },
                        new
                        {
                            Id = new Guid("04a385f9-933a-4cc5-9e0f-71d088cab374"),
                            OrderDate = new DateTime(2024, 9, 1, 16, 22, 49, 684, DateTimeKind.Local).AddTicks(4120),
                            Status = "Pending",
                            TotalItems = 3,
                            UserId = new Guid("c22bb1fa-fa61-4ef3-a37e-f09b119db5ae")
                        });
                });

            modelBuilder.Entity("Maroc.Core.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("67b63ab4-714e-420f-b9b7-8a53d6084c54"),
                            OrderId = new Guid("3a5ab519-d155-442c-843e-1751a0428af2"),
                            Price = 20m,
                            ProductId = new Guid("7f9985dc-3998-44e7-b1ec-17f9383d5e2a"),
                            Quantity = 2
                        },
                        new
                        {
                            Id = new Guid("a3072fe5-808f-4312-8746-0c493be7b094"),
                            OrderId = new Guid("04a385f9-933a-4cc5-9e0f-71d088cab374"),
                            Price = 50m,
                            ProductId = new Guid("8ae70984-8d34-4268-b05f-3a54cc7ba1d1"),
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("Maroc.Core.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2e192ba3-fa58-402e-bed5-ed1791944fa5"),
                            Amount = 40m,
                            OrderId = new Guid("3a5ab519-d155-442c-843e-1751a0428af2"),
                            PaymentDate = new DateTime(2024, 9, 1, 16, 22, 49, 684, DateTimeKind.Local).AddTicks(4130),
                            PaymentMethod = "PayPal"
                        },
                        new
                        {
                            Id = new Guid("ecd8c4df-d1ad-4bdc-a3f5-bf0e59d151c6"),
                            Amount = 150m,
                            OrderId = new Guid("04a385f9-933a-4cc5-9e0f-71d088cab374"),
                            PaymentDate = new DateTime(2024, 9, 1, 16, 22, 49, 684, DateTimeKind.Local).AddTicks(4134),
                            PaymentMethod = "BankContact"
                        });
                });

            modelBuilder.Entity("Maroc.Core.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f9985dc-3998-44e7-b1ec-17f9383d5e2a"),
                            CategoryId = new Guid("a073be93-6967-44d8-a996-c59744b08317"),
                            Description = "blalalalala",
                            ImageUrl = "",
                            Name = "Tajine",
                            Price = 20m,
                            StockQuantity = 5
                        },
                        new
                        {
                            Id = new Guid("8ae70984-8d34-4268-b05f-3a54cc7ba1d1"),
                            CategoryId = new Guid("6dcac4ff-8b23-4264-af27-1c3621ede620"),
                            Description = "dddd",
                            ImageUrl = "",
                            Name = "Djellaba",
                            Price = 50m,
                            StockQuantity = 5
                        },
                        new
                        {
                            Id = new Guid("b40f6183-ce18-4905-af02-7b7b4e6d474f"),
                            CategoryId = new Guid("70ff1a49-b23b-4846-88fb-0b148b868c5c"),
                            Description = "ddd",
                            ImageUrl = "",
                            Name = "Quran",
                            Price = 10m,
                            StockQuantity = 5
                        },
                        new
                        {
                            Id = new Guid("445c1f8a-54a0-4588-a628-8c7a7cb61abc"),
                            CategoryId = new Guid("8f2070bf-09c4-4c8a-bbb6-656227e29c32"),
                            Description = "dsdsds",
                            ImageUrl = "",
                            Name = "Bag",
                            Price = 30m,
                            StockQuantity = 5
                        });
                });

            modelBuilder.Entity("Maroc.Core.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3eed2bba-a366-4d29-9a1e-5cda79dcd28b"),
                            Content = "Good product",
                            ProductId = new Guid("7f9985dc-3998-44e7-b1ec-17f9383d5e2a"),
                            Rating = 4,
                            Title = "d",
                            UserId = new Guid("5af3834c-d02d-44a0-84cd-e97e97334db6")
                        },
                        new
                        {
                            Id = new Guid("e883df4b-18ee-40f0-9bd3-cfad907a67cc"),
                            Content = "Nice product",
                            ProductId = new Guid("8ae70984-8d34-4268-b05f-3a54cc7ba1d1"),
                            Rating = 3,
                            Title = "s",
                            UserId = new Guid("c22bb1fa-fa61-4ef3-a37e-f09b119db5ae")
                        });
                });

            modelBuilder.Entity("Maroc.Core.Entities.Inventory", b =>
                {
                    b.HasOne("Maroc.Core.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Maroc.Core.Entities.Order", b =>
                {
                    b.HasOne("Maroc.Core.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Maroc.Core.Entities.OrderDetail", b =>
                {
                    b.HasOne("Maroc.Core.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maroc.Core.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Maroc.Core.Entities.Payment", b =>
                {
                    b.HasOne("Maroc.Core.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Maroc.Core.Entities.Product", b =>
                {
                    b.HasOne("Maroc.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Maroc.Core.Entities.Review", b =>
                {
                    b.HasOne("Maroc.Core.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maroc.Core.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
