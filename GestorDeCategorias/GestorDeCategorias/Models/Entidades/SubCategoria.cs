using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace GestorDeCategorias.Models.Entidades
{
    public class SubCategoria
    {
        public SubCategoria()
        {
            this.Campos = new HashSet<Campo>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Slug { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
        public virtual ICollection<Campo> Campos { get; set; }
    }
}