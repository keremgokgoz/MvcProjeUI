namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
            AddColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterEmail", c => c.String(maxLength: 200));
            DropColumn("dbo.Writers", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "Password", c => c.String(maxLength: 20));
            AlterColumn("dbo.Writers", "WriterEmail", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterAbout");
            DropColumn("dbo.Writers", "WriterPassword");
        }
    }
}
