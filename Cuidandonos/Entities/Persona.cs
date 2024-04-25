using System.Collections.Generic;

namespace Entities
{
    public abstract class Persona
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }
        public TipoUsuario? TipoUsuario { get; set; }
        public bool EnViaje { get; internal set; }
        public ConfiguracionEmergencia ConfiguracionEmergencia { get; set; }
    }
}
