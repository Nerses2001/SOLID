
namespace SOLID.ModelSrpSolution
{
    internal class DataManagerImentation : IDataManager
    {
        public void Receive()
        {
            Console.WriteLine("Data receved successfull");
        }

        public void Send(string message)
        {
            Console.WriteLine("Data sent succsed");
        }
    }
}
