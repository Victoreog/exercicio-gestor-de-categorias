using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestorDeCategorias.Models.Entidades
{
    [Table("TipoCampo")]
    public class TipoCampo
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
    }
}