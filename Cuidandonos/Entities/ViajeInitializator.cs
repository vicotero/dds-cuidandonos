using System;
using System.Collections.Generic;

namespace Entities
{
    class ViajeInitializator
    {
        private IPersonaNotificator _personaNotificator;
        private readonly IGenericRepository _genericRepository;

        public ViajeInitializator(IPersonaNotificator personaNotificator, IGenericRepository genericRepository)
        {
            _personaNotificator = personaNotificator;
            _genericRepository = genericRepository;
        }

        public void GenerarNuevoViaje(Persona solicitante, List<Persona> cuidadores, Trayecto trayecto) 
        {
            if (CheckIfSolicitanteEsCuidador(solicitante))
                throw new ParaBoludoQueHacesException();

            var confirmados = new List<Persona>();
            foreach (var item in cuidadores)
            {
                if (_personaNotificator.SolicitarCuidadoViaje(item))
                    confirmados.Add(item);
            }

            if (confirmados.Count == 0)
                throw NadieTeQuiereException();

            var viaje = new Viaje()
            { 
                Solicitante = solicitante,
                Cuidadores = confirmados,
                Trayecto = trayecto,
                Id = Guid.NewGuid(),
                ViajeEventos = new List<ViajeEventos>()
            };

            viaje.ViajeEventos.Add(new ViajeEventos() { MyProperty = ViajeState.SinConfirmar, Start = DateTime.UtcNow });
            //Persistir

            _personaNotificator.HabilitarComienzoViaje();
        }

        private bool CheckIfSolicitanteEsCuidador(Persona solicitante)
        {
            throw new NotImplementedException();
        }

        private Exception NadieTeQuiereException()
        {
            throw new NotImplementedException();
        }
    }
}
