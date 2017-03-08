namespace Blockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeeduUers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a5c8cf8c-aa55-4ebe-bf20-49123f979587', N'admin@blockbuster.com', 0, N'AJMvDSi9mouIHzM93nAJ8n4giRySGqNSAbQhDZQuLrV08S4T22ig7xQbHSpW3z4wCA==', N'32bdda6d-5485-400e-ba91-a7f993ee9e9c', NULL, 0, 0, NULL, 1, 0, N'admin@blockbuster.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c1cd09c1-9c0e-4c44-9d52-4c0c6b382968', N'guest@blockbuster.com', 0, N'AFsWST7j30FH3XUsSo3ZFRabhYV0/ive3CuJ2Ijg4cJihPu/NJzRGp03NcyfSa/wrA==', N'3b9bac10-611a-4213-9ded-58d53056bb83', NULL, 0, 0, NULL, 1, 0, N'guest@blockbuster.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fb211a74-1f75-4b89-903f-90f701364dd7', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a5c8cf8c-aa55-4ebe-bf20-49123f979587', N'fb211a74-1f75-4b89-903f-90f701364dd7')

");
        }
        
        public override void Down()
        {
        }
    }
}
