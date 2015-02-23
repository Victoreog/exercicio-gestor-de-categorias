using GestorDeCategorias.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GestorDeCategorias.Models
{
    public class DBaseContext:DbContext
    {
        DbSet<Categoria> Categorias { get; set; }
    }
}