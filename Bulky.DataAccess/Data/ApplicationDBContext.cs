using Bulky.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PartyDetail> PartyDetails { get; set; }
        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in the Sunset",
                    Author = "Julian Button",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Abby Muscles",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );

            modelBuilder.Entity<PartyDetail>().HasData(
                new PartyDetail
                {
                    PartyName = "Sweet Tooth Supply",
                    Address = "1234 Maple Street, Anytown, CA, 12345, USA",
                    GSTNumber = "27ABACB5678H1Z5"
                },
                new PartyDetail
                {
                    PartyName = "The Bread Basket",
                    Address = "5678 Oak Avenue, Springfield, NY, 54321, USA",
                    GSTNumber = "36AAAC0001AB1Z5"
                }
                );
            modelBuilder.Entity<Bill>().HasData(
                new Bill
                {
                    BillNo = "B001",
                    SNO = {1,2,3},
                    Particulars={ "Cake","Apple Pie", "Cola" },
                    HSNCode={ "21436587", "26843715", "43219876" },
                    Quantity = {2,1,1},
                    Rate= {20,50,40},
                    Amount = {40,50,40},
                    PartyName = "The Bread Basket"
                },
                new Bill
                {
                    BillNo = "B002",
                    SNO = { 1, 2 },
                    Particulars = { "Cake", "Apple Pie" },
                    HSNCode = { "21436587", "26843715" },
                    Quantity = { 2, 1 },
                    Rate = { 20, 50 },
                    Amount = { 40, 50 },
                    PartyName = "Sweet Tooth Supply"
                },
                new Bill
                {
                    BillNo = "B003",
                    SNO = { 1, 2, 3, 4 },
                    Particulars = { "Cake", "Apple Pie", "Cola" , "ICe Cream"},
                    HSNCode = { "21436587", "26843715", "43219876", "94712586" },
                    Quantity = { 2, 1, 1, 2 },
                    Rate = { 20, 50, 40, 15},
                    Amount = { 40, 50, 40, 30 },
                    PartyName = "Sweet Tooth Supply"
                },
                new Bill
                {
                    BillNo = "B004",
                    SNO = { 1 },
                    Particulars = { "Cake" },
                    HSNCode = { "21436587" },
                    Quantity = { 2},
                    Rate = { 20 },
                    Amount = { 40 },
                    PartyName = "The Bread Basket"

                }
                );
        }
    }
}
