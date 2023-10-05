
namespace SOLID.ISP.ISPViolation
{
    internal class ClassB
    {
        private I _i;
        public ClassB(I i)
        {
            this._i = i;
        }

        public void CallGetDate()
        {
            _i.GetData();    
        }
    }
}
