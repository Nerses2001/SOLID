namespace SOLID.ISP.ISPSolution
{
    internal class B
    {
        private I2 _i2;
        public B(I2 i2)
        {
            this._i2 = i2;
        }

        public void CallGetName()
        {
            Console.WriteLine(_i2.GetDete());
        }
    }
}
