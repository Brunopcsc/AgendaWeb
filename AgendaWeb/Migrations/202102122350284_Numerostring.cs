namespace AgendaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Numerostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.contatos", "Numero", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.contatos", "Numero", c => c.Int(nullable: false));
        }
    }
}
