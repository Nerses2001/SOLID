

namespace SOLID.ISP.ISPViolation
{
    internal class ClassA
    {
        private I _i;

        public ClassA(I i)
        {
            this._i = i;
        }
        public void CallGetName()
        {
            Console.WriteLine(_i.GetName());
        }
    }
}
