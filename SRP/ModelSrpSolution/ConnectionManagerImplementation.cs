namespace SOLID.SRP.ModelSrpSolution
{
    internal class ConnectionManagerImplementation : IConnectionManager
    {
        public void Dial(string phoneNumber)
        {
            Console.WriteLine("Connected established");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected");
        }

    }
}
