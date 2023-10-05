
namespace SOLID.OCP.SrpSolution.ShapeOCPSolution
{
    internal class RectangleOCP : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public RectangleOCP(double widht, double heifht)
        {
            this.Width = widht;
            this.Height = heifht;
        }

        public override double Area()
        {
           return this.Width * this.Height;
        }
    }
}
