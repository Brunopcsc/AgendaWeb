namespace AgendaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nae : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contatos", "email", c => c.String(maxLength: 30));
            AddColumn("dbo.contatos", "numero", c => c.Int(nullable: false));
            AddColumn("dbo.contatos", "telefoneRes", c => c.String());
            AddColumn("dbo.contatos", "telefoneCom", c => c.String());
            AddColumn("dbo.contatos", "outroNum", c => c.String());
            AddColumn("dbo.contatos", "telefone0800", c => c.String());
            AddColumn("dbo.contatos", "informacoes", c => c.String());
            AlterColumn("dbo.contatos", "celular", c => c.String());
            DropColumn("dbo.contatos", "telefone");
            DropColumn("dbo.contatos", "estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.contatos", "estado", c => c.String(maxLength: 20));
            AddColumn("dbo.contatos", "telefone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.contatos", "celular", c => c.String(maxLength: 20));
            DropColumn("dbo.contatos", "informacoes");
            DropColumn("dbo.contatos", "telefone0800");
            DropColumn("dbo.contatos", "outroNum");
            DropColumn("dbo.contatos", "telefoneCom");
            DropColumn("dbo.contatos", "telefoneRes");
            DropColumn("dbo.contatos", "numero");
            DropColumn("dbo.contatos", "email");
        }
    }
}
