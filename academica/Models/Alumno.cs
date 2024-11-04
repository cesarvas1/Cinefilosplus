using System.ComponentModel.DataAnnotations;

namespace academica.Models {
    public class Alumno {
        [Key]
        public int idAlumno { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Sinopsis { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
    }
}
