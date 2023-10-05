
namespace SOLID.ModelSrpSolution
{
    internal class PhoneSRP : IConnectionManager, IDataManager
    {
        private readonly IConnectionManager _connectionManager;
        private readonly IDataManager _dataManager;

        public PhoneSRP(IConnectionManager connectionManager, IDataManager dataManager)
        {
            this._connectionManager = connectionManager;
            this._dataManager = dataManager;
        }
        public void Dial(string phoneNumber)
        {
            _connectionManager.Dial(phoneNumber);
        }

        public void Disconnect()
        {
            this._connectionManager.Disconnect();
        }

        public void Receive()
        {
            this._dataManager.Receive();
        }

        public void Send(string message)
        {
            this._dataManager.Send(message);
        }
    }
}
