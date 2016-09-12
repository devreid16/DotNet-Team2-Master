namespace ShoppingList_Team2_Master.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editEnumValues : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingListItemModels", "Contents", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingListItemModels", "Contents");
        }
    }
}
