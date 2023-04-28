using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPersonajesDDB.Models {
    public class Personaje {


        public int IdPesonaje { get; set; }


        public string Nombre { get; set; }


        public string Imagen { get; set; }

        public int IdSerie { get; set; }
    }
}
