namespace Crud_operation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Age", c => c.Int(nullable: false));
        }
    }
}
