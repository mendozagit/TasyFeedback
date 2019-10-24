using System;
using System.Collections.Generic;

namespace TasyFeedback.Models
{
    public partial class Error
    {
        public int ErrorId { get; set; }
        public string Perfil { get; set; }
        public string Funcion { get; set; }
        public string Img { get; set; }
        public string Descripcion { get; set; }
        public string Solucion { get; set; }
    }
}
