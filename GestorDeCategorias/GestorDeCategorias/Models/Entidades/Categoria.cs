using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorDeCategorias.Models.Entidades
{
    public class Categoria
    {
        public Categoria()
        {
            this.SubCategorias = new HashSet<SubCategoria>();
        }

        public int Id { get; set; }
        public string Descrição { get; set; }
        public string Slug { get; set; }
        public virtual ICollection<SubCategoria> SubCategorias { get; set; }
    }
}