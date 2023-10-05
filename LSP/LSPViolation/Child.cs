
using SOLID.LSP.LSPViolation;

namespace SOLID.LSP.LSPSolution
{
    internal class Child:Parent
    {
        public override void DoSomting()
        {
            throw new Exception("Run type Exaption");   
        }
    }
}
