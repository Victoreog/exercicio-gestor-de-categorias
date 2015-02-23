namespace GestorDeCategorias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descrição = c.String(),
                        Slug = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Slug = c.String(),
                        CategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaID, cascadeDelete: true)
                .Index(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Campos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ordem = c.Int(nullable: false),
                        TipoCampoID = c.Int(nullable: false),
                        SubCategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubCategorias", t => t.SubCategoriaID, cascadeDelete: true)
                .ForeignKey("dbo.TipoCampo", t => t.TipoCampoID, cascadeDelete: true)
                .Index(t => t.TipoCampoID)
                .Index(t => t.SubCategoriaID);
            
            CreateTable(
                "dbo.ListaCampo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CampoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campos", t => t.CampoID, cascadeDelete: true)
                .Index(t => t.CampoID);
            
            CreateTable(
                "dbo.TipoCampo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategorias", "CategoriaID", "dbo.Categorias");
            DropForeignKey("dbo.Campos", "TipoCampoID", "dbo.TipoCampo");
            DropForeignKey("dbo.Campos", "SubCategoriaID", "dbo.SubCategorias");
            DropForeignKey("dbo.ListaCampo", "CampoID", "dbo.Campos");
            DropIndex("dbo.ListaCampo", new[] { "CampoID" });
            DropIndex("dbo.Campos", new[] { "SubCategoriaID" });
            DropIndex("dbo.Campos", new[] { "TipoCampoID" });
            DropIndex("dbo.SubCategorias", new[] { "CategoriaID" });
            DropTable("dbo.TipoCampo");
            DropTable("dbo.ListaCampo");
            DropTable("dbo.Campos");
            DropTable("dbo.SubCategorias");
            DropTable("dbo.Categorias");
        }
    }
}
