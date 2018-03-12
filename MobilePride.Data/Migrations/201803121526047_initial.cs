namespace MobilePride.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.County",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        KeyID = c.Long(nullable: false, identity: true),
                        CountyName = c.String(maxLength: 200),
                        Lat = c.String(),
                        Lng = c.String(),
                        Status = c.Boolean(),
                        CreatedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.State",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        KeyID = c.Long(nullable: false),
                        CountryId = c.Single(nullable: false),
                        StateName = c.String(),
                        StateCode = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(nullable: false),
                        County_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.County", t => t.County_ID)
                .Index(t => t.County_ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        KeyID = c.Long(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        KeyID = c.Long(nullable: false),
                        UserId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        KeyID = c.Long(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 200),
                        HashedPassword = c.String(nullable: false, maxLength: 200),
                        Salt = c.String(nullable: false, maxLength: 200),
                        Token = c.String(),
                        TokenExpiryDate = c.DateTime(),
                        IsLocked = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ForgotPasswordLog",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        KeyID = c.Long(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Guid = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.NotificationMessage",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        KeyID = c.Long(nullable: false),
                        NotificationTypeId = c.Guid(),
                        FromUserId = c.Guid(),
                        ToUserId = c.Guid(),
                        PostMessageId = c.Guid(),
                        PostLikeMapperId = c.Guid(),
                        PostCommentMapperId = c.Guid(),
                        IsRead = c.Boolean(),
                        MessageFormatEng = c.String(),
                        MessageFormatJpn = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(nullable: false),
                        User_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.FromUserId)
                .ForeignKey("dbo.NotificationType", t => t.NotificationTypeId)
                .ForeignKey("dbo.User", t => t.ToUserId)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.NotificationTypeId)
                .Index(t => t.FromUserId)
                .Index(t => t.ToUserId)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.NotificationType",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        KeyID = c.Long(nullable: false),
                        NotificationTypeName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NotificationPreference",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        KeyID = c.Long(nullable: false),
                        UserId = c.Guid(nullable: false),
                        NotificationTypeId = c.Guid(nullable: false),
                        IsNotifiedByEmail = c.Boolean(nullable: false),
                        IsNotifiedByPushNotification = c.Boolean(nullable: false),
                        IsNotifiedBySMS = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.NotificationType", t => t.NotificationTypeId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.NotificationTypeId);
            
            CreateTable(
                "dbo.UserDetail",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        KeyID = c.Long(nullable: false),
                        UserId = c.Guid(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        CompanyName = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        Zipcode = c.String(),
                        CityId = c.Int(),
                        StateId = c.Int(),
                        CountryId = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        CreatedDateUnix = c.Long(),
                        ModifiedDateUnix = c.Long(),
                        CreatedBy = c.Guid(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.UserDetail", "UserId", "dbo.User");
            DropForeignKey("dbo.NotificationPreference", "UserId", "dbo.User");
            DropForeignKey("dbo.NotificationPreference", "NotificationTypeId", "dbo.NotificationType");
            DropForeignKey("dbo.NotificationMessage", "User_ID", "dbo.User");
            DropForeignKey("dbo.NotificationMessage", "ToUserId", "dbo.User");
            DropForeignKey("dbo.NotificationMessage", "NotificationTypeId", "dbo.NotificationType");
            DropForeignKey("dbo.NotificationMessage", "FromUserId", "dbo.User");
            DropForeignKey("dbo.ForgotPasswordLog", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.State", "County_ID", "dbo.County");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.UserDetail", new[] { "UserId" });
            DropIndex("dbo.NotificationPreference", new[] { "NotificationTypeId" });
            DropIndex("dbo.NotificationPreference", new[] { "UserId" });
            DropIndex("dbo.NotificationMessage", new[] { "User_ID" });
            DropIndex("dbo.NotificationMessage", new[] { "ToUserId" });
            DropIndex("dbo.NotificationMessage", new[] { "FromUserId" });
            DropIndex("dbo.NotificationMessage", new[] { "NotificationTypeId" });
            DropIndex("dbo.ForgotPasswordLog", new[] { "UserId" });
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.State", new[] { "County_ID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UserDetail");
            DropTable("dbo.NotificationPreference");
            DropTable("dbo.NotificationType");
            DropTable("dbo.NotificationMessage");
            DropTable("dbo.ForgotPasswordLog");
            DropTable("dbo.User");
            DropTable("dbo.UserRole");
            DropTable("dbo.Role");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.State");
            DropTable("dbo.County");
        }
    }
}
