using Maroc.Core.Entities;
using Maroc.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace Maroc.Infastructure
{
    public static class Seeder
    {
        public static void SeedData(ModelBuilder context)
        {

            var categories = new[]
                {
                    new Category { Id = Guid.NewGuid(), Name = "Cookware" },
                    new Category { Id = Guid.NewGuid(), Name = "Clothing" },
                    new Category { Id = Guid.NewGuid(),  Name = "Islam" },
                    new Category { Id = Guid.NewGuid(),  Name = "Accessories" },
                    new Category { Id = Guid.NewGuid(),  Name = "Music" },
                    new Category { Id = Guid.NewGuid(),  Name = "Garden" },
                    new Category { Id = Guid.NewGuid(),  Name = "Bags" },
                    new Category { Id = Guid.NewGuid(),  Name = "Personal Care" },
                    new Category { Id = Guid.NewGuid(),  Name = "Decoration" },
                    new Category { Id = Guid.NewGuid(),  Name = "Lamps" },
                    new Category { Id = Guid.NewGuid(),  Name = "Books" },
                    new Category { Id = Guid.NewGuid(),  Name = "Home" },
                    new Category { Id = Guid.NewGuid(),  Name = "Games" },
                    new Category { Id = Guid.NewGuid(),  Name = "Garden" },
                    new Category { Id = Guid.NewGuid(), Name = "Home" },
                    new Category { Id = Guid.NewGuid(),  Name = "Baby" },
                    new Category { Id = Guid.NewGuid(),  Name = "Handmade" },
                    new Category { Id = Guid.NewGuid(),  Name = "Jewelry" },
                    new Category { Id = Guid.NewGuid(),  Name = "Shoes" },
                    new Category { Id = Guid.NewGuid(), Name = "Luggage" },
                    new Category { Id = Guid.NewGuid(), Name = "Art" },
                    new Category { Id = Guid.NewGuid(), Name = "Antiques" },
                };

            var users = new[]
            {
                    new ApplicationUser { Id = Guid.NewGuid(), FirstName = "Anis" },
                    new ApplicationUser { Id = Guid.NewGuid(), FirstName = "Nouri" },

            };

            var products = new[]
            {
                new Product {Id = Guid.NewGuid(), Name = "Tajine", Price = 20, CategoryId = categories[0].Id,Description="blalalalala", StockQuantity = 5, ImageUrl = "" },
                new Product {Id = Guid.NewGuid(), Name = "Djellaba", Price = 50, CategoryId = categories[1].Id , Description ="dddd" , StockQuantity = 5, ImageUrl=""},
                new Product {Id = Guid.NewGuid(), Name = "Quran", Price = 10, CategoryId = categories[2].Id , Description= "ddd", StockQuantity = 5, ImageUrl = ""},
                new Product {Id = Guid.NewGuid(), Name = "Bag", Price = 30, CategoryId = categories[6].Id , Description = "dsdsds",StockQuantity = 5, ImageUrl = ""},

            };

            var inventories = new[]
            {
                new Inventory {Id = Guid.NewGuid(), ProductId = products[0].Id, CurrentStock = 5, RecordLevel = 1 },
                new Inventory {Id = Guid.NewGuid(), ProductId = products[1].Id, CurrentStock = 5, RecordLevel = 1 },
                new Inventory {Id = Guid.NewGuid(), ProductId = products[2].Id, CurrentStock = 5, RecordLevel = 1 },
                new Inventory {Id = Guid.NewGuid(), ProductId = products[3].Id, CurrentStock = 5, RecordLevel = 1 },
            };

            var orders = new[]
            {
                new Order {Id = Guid.NewGuid(), UserId = users[0].Id, OrderDate = DateTime.Now, Status = OrderStatus.Processing, TotalItems = 2 },
                new Order {Id = Guid.NewGuid(), UserId = users[1].Id, OrderDate = DateTime.Now, Status = OrderStatus.Pending, TotalItems = 3 },
            };

            var orderDetails = new[]
            {
                new OrderDetail {Id = Guid.NewGuid(), OrderId = orders[0].Id, ProductId = products[0].Id, Quantity = 2, Price = products[0].Price },
                new OrderDetail {Id = Guid.NewGuid(), OrderId = orders[1].Id, ProductId = products[1].Id, Quantity = 3, Price = products[1].Price },
            };

            var payments = new[]
            {
                new Payment {Id = Guid.NewGuid(), OrderId = orders[0].Id, PaymentDate = DateTime.Now, Amount = 40, PaymentMethod = PaymentMethod.PayPal },
                new Payment {Id = Guid.NewGuid(), OrderId = orders[1].Id, PaymentDate = DateTime.Now, Amount = 150 , PaymentMethod = PaymentMethod.BankContact},
            };

            var reviews = new[]
            {
                new Review {Id = Guid.NewGuid(), ProductId = products[0].Id, Rating = 4, Content = "Good product", Title = "d", UserId = users[0].Id },
                new Review {Id = Guid.NewGuid(), ProductId = products[1].Id, Rating = 3, Content = "Nice product", Title = "s", UserId = users[1].Id },
            };

            context.Entity<Category>().HasData(categories);
            context.Entity<ApplicationUser>().HasData(users);
            context.Entity<Product>().HasData(products);
            context.Entity<Inventory>().HasData(inventories);
            context.Entity<Order>().HasData(orders);
            context.Entity<OrderDetail>().HasData(orderDetails);
            context.Entity<Payment>().HasData(payments);
            context.Entity<Review>().HasData(reviews);



        }
    }
}
