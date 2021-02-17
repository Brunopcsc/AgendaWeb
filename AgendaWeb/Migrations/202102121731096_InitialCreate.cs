namespace AgendaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contatos",
                c => new
                    {
                        contato_id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 30),
                        telefone = c.String(nullable: false, maxLength: 20),
                        celular = c.String(maxLength: 20),
                        endereco = c.String(maxLength: 40),
                        bairro = c.String(maxLength: 30),
                        cidade = c.String(maxLength: 30),
                        estado = c.String(maxLength: 20),
                        cep = c.String(),
                    })
                .PrimaryKey(t => t.contato_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.contatos");
        }
    }
}
