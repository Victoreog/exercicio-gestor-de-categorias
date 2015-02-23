using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestorDeCategorias.Models.Entidades
{
    [Table("Campos")]
    public class Campo
    {
        public Campo()
        {
            this.Lista = new HashSet<ListaCampo>();
        }

        public int Id { get; set; }
        public int Ordem { get; set; }
        public int TipoCampoID { get; set; }
        public TipoCampo TipoCampo { get; set; }
        public int SubCategoriaID { get; set; }
        public SubCategoria SubCategoria { get; set; }
        public virtual ICollection<ListaCampo> Lista { get; set; }
    }
}