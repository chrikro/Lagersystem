namespace Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newfieldProductImageUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductImageUrl");
        }
    }
}
