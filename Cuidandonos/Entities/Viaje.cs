using System;
using System.Collections.Generic;

namespace Entities
{
    public class Viaje
    {
        public Viaje()
        {
        }

        public Persona Solicitante { get; internal set; }
        public List<Persona> Cuidadores { get; internal set; }
        public Trayecto Trayecto { get; internal set; }
        public Guid Id { get; internal set; }
        public List<ViajeEventos> ViajeEventos { get; set; }
    }
}