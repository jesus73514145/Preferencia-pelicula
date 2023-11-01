using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace preferencia_pelicula.Models {
    public class Pelicula {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int GeneroId { get; set; }
    }
}