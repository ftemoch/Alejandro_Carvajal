namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizacionClientes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Apellido", c => c.String());
            AddColumn("dbo.Clientes", "Salario", c => c.Single(nullable: false));
            AddColumn("dbo.Clientes", "EstaActivo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "EstaActivo");
            DropColumn("dbo.Clientes", "Salario");
            DropColumn("dbo.Clientes", "Apellido");
        }
    }
}
