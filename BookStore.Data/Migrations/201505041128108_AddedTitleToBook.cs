namespace BookStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTitleToBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Title");
        }
    }
}
