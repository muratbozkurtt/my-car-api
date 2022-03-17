using FluentMigrator;
using MyCar.Data.Entity;
using System;

namespace MyCar.Data.Migrations
{
    [Migration(202203160002)]
    public class InitialSeed_202203160002 : Migration
    {
        public override void Down()
        {
            Delete.FromTable("Advert")
               .Row(new Advert
               {
                   Id = 15763767,
                   MemberId = 6434119,
                   CityId = 59,
                   CityName = "Tekirdağ",
                   TownId = 795,
                   TownName = "Süleymanpaşa",
                   ModelId = 8980,
                   ModelName = "Doblo 1.9 D SX Manuel",
                   Year = 2003,
                   Price = 49000,
                   Title = "Sahibinden",
                   Date = DateTime.Now.AddYears(-1),
                   CategoryId = 18603,
                   Category = "minivan-van_panelvan/fiat-doblo-combi-1-9-d-sx",
                   Km = 18900,
                   Color = "Gri",
                   Gear = "Düz",
                   Fuel = "Dizel",
                   FirstPhoto = "https://arbstorage.mncdn.com/ilanfotograflari/2020/10/20/15763767/b8f7c9a5-24d1-418a-957c-75a927bef5f4_image_for_silan_15763767_{0}.jpg",
                   SecondPhoto = "https://arbstorage.mncdn.com/ilanfotograflari/2020/10/20/15763767/b8f7c9a5-24d1-418a-957c-75a927bef5f4_image_for_silan_15763767_{0}.jpg",
                   UserInfo = "Stephan Brock",
                   UserPhone = "9031728330",
                   Text = "Lorem ipsum 1"
               })
              .Row(new Advert
              {
                  Id = 16030353,
                  MemberId = 6528389,
                  CityId = 28,
                  CityName = "Giresun",
                  TownId = 358,
                  TownName = "Merkez",
                  ModelId = 8735,
                  ModelName = "Tiguan 1.4 TSI 4x2 Sport&Style Manuel",
                  Year = 2011,
                  Price = 188500,
                  Title = "Sahibinden",
                  Date = DateTime.Now.AddYears(-3),
                  CategoryId = 13011,
                  Category = "arazi-suv-pick-up/volkswagen-tiguan-1-4-tsi-sport-style",
                  Km = 38100,
                  Color = "Siyah",
                  Gear = "Düz",
                  Fuel = "Benzin",
                  FirstPhoto = "https://arbstorage.mncdn.com/ilanfotograflari/2020/11/21/16030353/3c720f6d-5108-40d2-8d72-ebb027d23fca_image_for_silan_16030353_{0}.jpg",
                  SecondPhoto = "https://arbstorage.mncdn.com/ilanfotograflari/2020/11/21/16030353/3c720f6d-5108-40d2-8d72-ebb027d23fca_image_for_silan_16030353_{0}.jpg",
                  UserInfo = "Raquel Hill",
                  UserPhone = "9032199860",
                  Text = "Lorem ipsum 2"
              });


            Delete.FromTable("AdvertVisit")
                 .Row(new AdvertVisit
                 {
                     AdvertId = 15763767,
                     IpAddress = "127.0.0.1",
                     VisitDate = DateTime.Now.AddYears(-2)
                 })
                 .Row(new AdvertVisit
                 {
                     AdvertId = 15763767,
                     IpAddress = "127.0.0.2",
                     VisitDate = DateTime.Now.AddYears(-3)
                 });
        }

        public override void Up()
        {
            Insert.IntoTable("Advert")
              .Row(new Advert
              {
                  Id = 15763767,
                  MemberId = 6434119,
                  CityId = 59,
                  CityName = "Tekirdağ",
                  TownId = 795,
                  TownName = "Süleymanpaşa",
                  ModelId = 8980,
                  ModelName = "Doblo 1.9 D SX Manuel",
                  Year = 2003,
                  Price = 49000,
                  Title = "Sahibinden",
                  Date = DateTime.Now.AddYears(-1),
                  CategoryId = 18603,
                  Category = "minivan-van_panelvan/fiat-doblo-combi-1-9-d-sx",
                  Km = 18900,
                  Color = "Gri",
                  Gear = "Düz",
                  Fuel = "Dizel",
                  FirstPhoto = "https://arbstorage.mncdn.com/ilanfotograflari/2020/10/20/15763767/b8f7c9a5-24d1-418a-957c-75a927bef5f4_image_for_silan_15763767_{0}.jpg",
                  SecondPhoto = "https://arbstorage.mncdn.com/ilanfotograflari/2020/10/20/15763767/b8f7c9a5-24d1-418a-957c-75a927bef5f4_image_for_silan_15763767_{0}.jpg",
                  UserInfo = "Stephan Brock",
                  UserPhone = "9031728330",
                  Text = "Lorem ipsum 1"
              })
              .Row(new Advert
              {
                  Id = 16030353,
                  MemberId = 6528389,
                  CityId = 28,
                  CityName = "Giresun",
                  TownId = 358,
                  TownName = "Merkez",
                  ModelId = 8735,
                  ModelName = "Tiguan 1.4 TSI 4x2 Sport&Style Manuel",
                  Year = 2011,
                  Price = 188500,
                  Title = "Sahibinden",
                  Date = DateTime.Now.AddYears(-3),
                  CategoryId = 13011,
                  Category = "arazi-suv-pick-up/volkswagen-tiguan-1-4-tsi-sport-style",
                  Km = 38100,
                  Color = "Siyah",
                  Gear = "Düz",
                  Fuel = "Benzin",
                  FirstPhoto = "https://arbstorage.mncdn.com/ilanfotograflari/2020/11/21/16030353/3c720f6d-5108-40d2-8d72-ebb027d23fca_image_for_silan_16030353_{0}.jpg",
                  SecondPhoto = "https://arbstorage.mncdn.com/ilanfotograflari/2020/11/21/16030353/3c720f6d-5108-40d2-8d72-ebb027d23fca_image_for_silan_16030353_{0}.jpg",
                  UserInfo = "Raquel Hill",
                  UserPhone = "9032199860",
                  Text = "Lorem ipsum 2"
              });



            Insert.IntoTable("AdvertVisit")
                 .Row(new AdvertVisit
                 {
                     AdvertId = 15763767,
                     IpAddress = "127.0.0.1",
                     VisitDate = DateTime.Now.AddYears(-2)
                 })
                 .Row(new AdvertVisit
                 {
                     AdvertId = 15763767,
                     IpAddress = "127.0.0.2",
                     VisitDate = DateTime.Now.AddYears(-3)
                 });
        }
    }
}
