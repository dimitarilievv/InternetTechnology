namespace Posledna.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athletes",
                c => new
                    {
                        AthleteId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Level = c.String(),
                        AthleteNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AthleteId);
            
            CreateTable(
                "dbo.TrainingPrograms",
                c => new
                    {
                        TrainingProgramId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        CoachId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrainingProgramId)
                .ForeignKey("dbo.Coaches", t => t.CoachId, cascadeDelete: true)
                .Index(t => t.CoachId);
            
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        CoachId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.CoachId);
            
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
            
            CreateTable(
                "dbo.TrainingProgramAthletes",
                c => new
                    {
                        TrainingProgram_TrainingProgramId = c.Int(nullable: false),
                        Athlete_AthleteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TrainingProgram_TrainingProgramId, t.Athlete_AthleteId })
                .ForeignKey("dbo.TrainingPrograms", t => t.TrainingProgram_TrainingProgramId, cascadeDelete: true)
                .ForeignKey("dbo.Athletes", t => t.Athlete_AthleteId, cascadeDelete: true)
                .Index(t => t.TrainingProgram_TrainingProgramId)
                .Index(t => t.Athlete_AthleteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.TrainingPrograms", "CoachId", "dbo.Coaches");
            DropForeignKey("dbo.TrainingProgramAthletes", "Athlete_AthleteId", "dbo.Athletes");
            DropForeignKey("dbo.TrainingProgramAthletes", "TrainingProgram_TrainingProgramId", "dbo.TrainingPrograms");
            DropIndex("dbo.TrainingProgramAthletes", new[] { "Athlete_AthleteId" });
            DropIndex("dbo.TrainingProgramAthletes", new[] { "TrainingProgram_TrainingProgramId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.TrainingPrograms", new[] { "CoachId" });
            DropTable("dbo.TrainingProgramAthletes");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Coaches");
            DropTable("dbo.TrainingPrograms");
            DropTable("dbo.Athletes");
        }
    }
}
