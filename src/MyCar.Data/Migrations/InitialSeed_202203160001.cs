﻿//using FluentMigrator;
//using MyCar.Infrastructure.Entity;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyCar.Data.Migrations
//{
//    [Migration(202203160001)]
//    internal class InitialSeed_202203160001 : Migration
//    {
//        public override void Down()
//        {
//            Delete.FromTable("Advert")
//                .Row(new Advert
//                {
//                    Id = ""
//                });
//            Delete.FromTable("Companies")
//                .Row(new AdvertVisit
//                {
//                    Id = new Guid("67fbac34-1ee1-4697-b916-1748861dd275"),
//                    Address = "Test Address",
//                    Country = "USA",
//                    Name = "Test Name"
//                });
//        }
//        public override void Up()
//        {
//            Insert.IntoTable("Companies")
//                .Row(new Company
//                {
//                    Id = new Guid("67fbac34-1ee1-4697-b916-1748861dd275"),
//                    Address = "Test Address",
//                    Country = "USA",
//                    Name = "Test Name"
//                });
//            Insert.IntoTable("Employees")
//                .Row(new Employee
//                {
//                    Id = new Guid("59c0d403-71ce-4ac8-9c2c-b0e54e7c043b"),
//                    Age = 34,
//                    Name = "Test Employee",
//                    Position = "Test Position",
//                    CompanyId = new Guid("67fbac34-1ee1-4697-b916-1748861dd275")
//                });
//        }
//    }
//}