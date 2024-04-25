using System;

namespace Entities
{
    public interface IViajeWatcher
    {
        void Alertar(Viaje viaje, TimeSpan demora);
        void ContarTiempo(Viaje viaje, TimeSpan demora);
    }
}