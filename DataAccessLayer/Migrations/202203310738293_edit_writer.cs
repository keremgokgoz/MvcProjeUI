﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_writer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 250));
            AddColumn("dbo.Writers", "WriterStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterStatus");
            DropColumn("dbo.Writers", "WriterImage");
            DropColumn("dbo.Writers", "WriterTitle");
        }
    }
}
