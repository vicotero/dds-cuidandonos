using System;

namespace Entities
{
    class ViajeWatcher : IViajeWatcher
    {
        public void ContarTiempo(Viaje viaje, TimeSpan demora)
        {
            //Levantar evento
        }

        public void Alertar(Viaje viaje, TimeSpan demora)
        {
            var conf = viaje.Solicitante.ConfiguracionEmergencia;


        }
    }
}
