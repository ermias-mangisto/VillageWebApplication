namespace VillageWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Residents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Residents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FatherName = c.String(),
                        Gender = c.String(),
                        BornInVillage = c.Boolean(nullable: false),
                        Birth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Residents");
        }
    }
}
