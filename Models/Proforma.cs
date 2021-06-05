using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace inicio.Models
{
    [Table("Proforma")]
    public class Proforma
    {
         

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id {get; set;}

        public String UserID {get; set;}

        public Producto Producto {get; set;}

        public int Cantidad{get; set;}
        

        public Decimal Precio { get; set; }
        public String Imagen { get; set; }


    }
}