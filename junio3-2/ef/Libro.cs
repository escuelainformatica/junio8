namespace junio3_2.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Libro")]
    public partial class Libro
    {
        [Key]
        public int IdLibro { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? IdAutor { get; set; }

        public virtual Autor Autor { get; set; }
    }
}
