using System;

namespace Entities
{
    //Usar strategy para IPersonCommunication, por ej para llamar, mandar popup, sms, etc
    class PersonaNotificator : IPersonaNotificator
    {
        private readonly IPersonCommunication personCommunication;

        public PersonaNotificator(IPersonCommunication personCommunication)
        {
            this.personCommunication = personCommunication;
        }
        public void HabilitarComienzoViaje()
        {
            throw new NotImplementedException();
        }

        public void NotificarDemora(Persona item, TimeSpan demora)
        {
            if (item.EnViaje)
                return;
        }

        public void NotificarFinalizacion(Persona item)
        {
            personCommunication.SendMessage(item, "Viaje finalizado, arigatou gozaimasu");
        }

        public bool SolicitarCuidadoViaje(Persona item)
        {
            if (item.EnViaje)
                return false;

            return personCommunication.GetBooleanResponse(item, "Juanito se quiere comunicar con usted, quiere ser el cuidador?");
        }
    }
}
