namespace SOLID.ModelSRPViolation
{
    internal class Phone : IPhone
    {
        public void Dial(string phoneNumber)
        {
            Console.WriteLine("Connected established");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected");
        }

        public void Recieve()
        {
            Console.WriteLine("Data receved successfull");
        }

        public void Send(string message)
        {
            Console.WriteLine("Data sent succsed");
        }
    }
}
