using FluentMigrator;


namespace MyCar.Data.Migrations
{
    [Migration(202203160001)]
    public class InitialTables_202203160001 : Migration
    {
        public override void Down()
        {
            Delete.Table("Advert");
            Delete.Table("AdvertVisit");
        }

        public override void Up()
        {
            Create.Table("Advert")
                .WithColumn("Id").AsInt32().NotNullable()
                .WithColumn("MemberId").AsInt32().NotNullable()
                .WithColumn("CityId").AsInt32().NotNullable()
                .WithColumn("CityName").AsString(300).NotNullable()
                .WithColumn("TownId").AsInt32().NotNullable()
                .WithColumn("TownName").AsString().NotNullable()
                .WithColumn("ModelId").AsInt32().NotNullable()
                .WithColumn("ModelName").AsString(50).NotNullable()
                .WithColumn("Year").AsString(5).NotNullable()
                .WithColumn("Price").AsString(50).NotNullable()
                .WithColumn("Title").AsString(50).NotNullable()
                .WithColumn("Date").AsDateTime().NotNullable()
                .WithColumn("CategoryId").AsInt32().NotNullable()
                .WithColumn("Category").AsString(350).NotNullable()
                .WithColumn("Km").AsString(20).NotNullable()
                .WithColumn("Color").AsString(50).NotNullable()
                .WithColumn("Gear").AsString(50).NotNullable()
                .WithColumn("Fuel").AsString(50).NotNullable()
                .WithColumn("FirstPhoto").AsString(250).NotNullable()
                .WithColumn("SecondPhoto").AsString(250).NotNullable()
                .WithColumn("UserInfo").AsString(50).NotNullable()
                .WithColumn("UserPhone").AsString(50).NotNullable()
                .WithColumn("Text").AsString(50).NotNullable();

            Create.Table("AdvertVisit")
                .WithColumn("AdvertId").AsString(50).NotNullable()
                .WithColumn("IpAddress").AsString(50).NotNullable()
                .WithColumn("VisitDate").AsDateTime().NotNullable();
        }
    }
}
