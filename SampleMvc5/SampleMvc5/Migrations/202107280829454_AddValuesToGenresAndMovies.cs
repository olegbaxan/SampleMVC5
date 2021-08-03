namespace SampleMvc5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesToGenresAndMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into [SampleDb].[dbo].[Genres] ([Name]) Values ('Drama') ");
            Sql("INSERT into [SampleDb].[dbo].[Genres] ([Name]) Values ('Action') ");
            Sql("INSERT into [SampleDb].[dbo].[Genres] ([Name]) Values ('Horror') ");
            Sql("INSERT into [SampleDb].[dbo].[Genres] ([Name]) Values ('Romance') ");
            Sql("INSERT into [SampleDb].[dbo].[Genres] ([Name]) Values ('Comedy') ");

            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Black Panther','2019-05-02','2018-05-02',10,1) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Citizen Kane','2020-09-09','1941-05-01',5,1) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Avengers: Endgame','2020-09-010','2019-04-26',15,2) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Mission: Impossible - Fallout','2020-04-05','2018-07-27',20,2) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Mission: Impossible - Fallout','2020-04-05','2018-07-27',20,2) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Us','2020-04-05','2019-07-27',10,3) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Get Out','2020-04-05','2017-07-27',10,3) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Twilight','2021-07-28','2008-04-07',100,4) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('Chernobyl: Abyss','2021-07-28','2021-07-27',90,4) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES(' Space Jam: A New Legacy','2021-07-28','2021-05-27',90,5) ");
            Sql("INSERT into [SampleDb].[dbo].[Movies] ([Name],[DateAdded],[ReleaseDate],[NumberInStock],[Genre_Id])VALUES('The Suicide Squad','2021-07-28','2021-03-20',90,5) ");

        }
        
        public override void Down()
        {
        }
    }
}
