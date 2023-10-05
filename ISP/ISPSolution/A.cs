namespace SOLID.ISP.ISPSolution
{
    internal class A
    {
        private I1 i1;
        public A(I1 i1)
        {
            this.i1 = i1;
        }

        public void CallGetName()
        {
            Console.WriteLine(i1.GetName());
        }
    }
}
