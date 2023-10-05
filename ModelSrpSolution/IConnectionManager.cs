

namespace SOLID.ModelSrpSolution
{
    internal interface IConnectionManager
    {
        void Dial(string phoneNumber);
        void Disconnect();
    }
}
