namespace junio3_2.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using System.Xml.Serialization;

    
    public partial class Autor
    {
        public Autor()
        {
            Libro = new HashSet<Libro>();
        }


        public int IdAutor { get; set; }

        public string Nombre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Libro> Libro { get; set; }
    }
}
