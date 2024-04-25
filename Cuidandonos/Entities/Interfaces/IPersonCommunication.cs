namespace Entities
{
    public interface IPersonCommunication
    {
        bool GetBooleanResponse(Persona item, string v);
        void SendMessage(Persona item, string v);
    }
}