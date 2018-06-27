namespace Memberships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrationmigr : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ItemType", new[] { "Item_Id1" });
            DropIndex("dbo.ItemType", new[] { "Item_Id2" });
            RenameColumn(table: "dbo.Part", name: "Item_Id1", newName: "Item_Id");
            RenameColumn(table: "dbo.Section", name: "Item_Id2", newName: "Item_Id");
            CreateIndex("dbo.Part", "Item_Id");
            CreateIndex("dbo.Section", "Item_Id");
            DropColumn("dbo.ItemType", "Item_Id1");
            DropColumn("dbo.ItemType", "Item_Id2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemType", "Item_Id2", c => c.Int());
            AddColumn("dbo.ItemType", "Item_Id1", c => c.Int());
            DropIndex("dbo.Section", new[] { "Item_Id" });
            DropIndex("dbo.Part", new[] { "Item_Id" });
            RenameColumn(table: "dbo.Section", name: "Item_Id", newName: "Item_Id2");
            RenameColumn(table: "dbo.Part", name: "Item_Id", newName: "Item_Id1");
            CreateIndex("dbo.ItemType", "Item_Id2");
            CreateIndex("dbo.ItemType", "Item_Id1");
        }
    }
}
