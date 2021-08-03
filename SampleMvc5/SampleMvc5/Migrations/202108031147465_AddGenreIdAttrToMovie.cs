namespace SampleMvc5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreIdAttrToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreIden", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "GenreIden");
        }
    }
}
