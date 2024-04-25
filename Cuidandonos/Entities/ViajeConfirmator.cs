using System;

namespace Entities
{
    public class ViajeConfirmator
    {
        private readonly IDemoraCalculator demoraCalculator;
        private readonly IPersonaNotificator personaNotificator;
        private readonly IViajeWatcher taskRunner;

        public ViajeConfirmator(IDemoraCalculator demoraCalculator, IPersonaNotificator personaNotificator, IViajeWatcher taskRunner)
        {
            this.demoraCalculator = demoraCalculator;
            this.personaNotificator = personaNotificator;
            this.taskRunner = taskRunner;
        }

        public void ComenzarViaje(Viaje viaje) 
        {
            var demora = demoraCalculator.CalcularDemora(viaje);
            foreach (var item in viaje.Cuidadores)
            {
                personaNotificator.NotificarDemora(item, demora);
            }

            viaje.Solicitante.EnViaje = true;
            //Persistir Solicitante

            viaje.ViajeEventos.Add(new ViajeEventos() { MyProperty = ViajeState.Comenzado, Start = DateTime.Now });
            //Persistir Viaje


            taskRunner.ContarTiempo(viaje, demora);
        }
    }
}
