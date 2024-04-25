using System;

namespace Entities
{
    class ViajeFinalizator
    {
        private readonly IPersonaNotificator personaNotificator;

        public ViajeFinalizator(IPersonaNotificator personaNotificator)
        {
            this.personaNotificator = personaNotificator;
        }


        public void FinalizarViaje(Viaje viaje)
        {
            foreach (var item in viaje.Cuidadores)
            {
                personaNotificator.NotificarFinalizacion(item);
            }

            viaje.Solicitante.EnViaje = false;
            //Persistir Solicitante

            //Eventos anteriores poner end date
            viaje.ViajeEventos.Add(new ViajeEventos() { MyProperty = ViajeState.Finalizado, Start = DateTime.Now, End = DateTime.Now});
            //Persistir Viaje
        }
    }
}
