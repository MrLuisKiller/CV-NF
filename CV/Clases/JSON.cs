using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Clases
{
    public class Estructura
    {
        public DPersonal Personal { get; set; }
        public List<DEducacion> Educacion { get; set; }
        public List<DExperiencia> Experiencia { get; set; }
        public Dictionary<String, List<String>> Habilidades { get; set; }
    }

    public class DPersonal
    {
        public Perfil Perfil { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public DateTime FNacimiento { get; set; }
        public String Resumen { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }
        public String Pagina { get; set; }
    }

    public class Perfil
    {
        public Byte[] Imagen { get; set; }
        public String Style { get; set; }
        public String Cap { get; set; }
    }

    public class DEducacion
    {
        public String Carrera { get; set; }
        public String Institucion { get; set; }
        public DateTime FInicio { get; set; }
        public DateTime FFinal { get; set; }
        public bool Estudio { get; set; }
        public String Descripcion { get; set; }
    }

    public class DExperiencia
    {
        public String Nombre { get; set; }
        public String Compania { get; set; }
        public String Direccion { get; set; }
        public String Pagina { get; set; }
        public DateTime FInicio { get; set; }
        public DateTime FFinal { get; set; }
        public bool Trabajo { get; set; }
        public String Descripcion { get; set; }
        public String Habiliddades { get; set; }
    }
}
