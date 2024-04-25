namespace Entities
{
    public class ConfiguracionEmergencia
    {
        public bool LlamarCana { get; set; }
        public bool EnviarMensaje { get; set; }
        public bool Llamarme { get; set; }
        public int? MinutosAEsperar { get; set; }
    }
}