namespace SOLID.SRP.ModelSrpSolution
{
    internal class PhoneSRP : IConnectionManager, IDataManager
    {
        private readonly IConnectionManager _connectionManager;
        private readonly IDataManager _dataManager;

        public PhoneSRP(IConnectionManager connectionManager, IDataManager dataManager)
        {
            _connectionManager = connectionManager;
            _dataManager = dataManager;
        }
        public void Dial(string phoneNumber)
        {
            _connectionManager.Dial(phoneNumber);
        }

        public void Disconnect()
        {
            _connectionManager.Disconnect();
        }

        public void Receive()
        {
            _dataManager.Receive();
        }

        public void Send(string message)
        {
            _dataManager.Send(message);
        }
    }
}
