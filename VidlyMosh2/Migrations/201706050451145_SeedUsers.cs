namespace VidlyMosh2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'024ca3de-4cf5-456d-99f1-76be7302b13b', N'guest@vidly.com', 0, N'AISXt7L2oGPi8VpQS3/Xg6AaYIKH8YyQ2CErFnkzbpGgHJpJ4DzmfjQ21HATQ9aJxw==', N'c7d8a1f1-51c9-4eb6-b5e7-dfb27ecb3221', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f3c63b16-9a80-47a7-bf78-da6a26299731', N'admin@vidly.com', 0, N'AK5SZ1n3yJuTfzcHE+TzOizUuOK8DoYqpk6SXHZ8pIHfp7vXmfGTDkYLJa6Eq9M3mg==', N'36f44804-ed72-4922-8a8b-ae0a123853cb', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f9ad9246-800d-4046-a6f8-fee89233a392', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f3c63b16-9a80-47a7-bf78-da6a26299731', N'f9ad9246-800d-4046-a6f8-fee89233a392')

");
        }
        
        public override void Down()
        {
        }
    }
}
