using System;

namespace Entities
{
    public interface IPersonaNotificator
    {
        bool SolicitarCuidadoViaje(Persona item);
        void HabilitarComienzoViaje();
        void NotificarDemora(Persona item, TimeSpan demora);
        void NotificarFinalizacion(Persona item);
    }
}