namespace SOLID.SRP.ModelSrpSolution
{
    internal interface IDataManager
    {
        void Send(string message);
        void Receive();
    }
}
