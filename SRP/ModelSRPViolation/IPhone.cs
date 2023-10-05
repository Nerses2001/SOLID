namespace SOLID.SRP.ModelSRPViolation
{
    internal interface IPhone
    {
        void Dial(string phoneNumber);
        void Disconnect();

        void Send(string message);
        void Recieve();
    }
}
