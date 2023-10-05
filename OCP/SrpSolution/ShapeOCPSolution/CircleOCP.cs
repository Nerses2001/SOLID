

namespace SOLID.OCP.SrpSolution.ShapeOCPSolution
{
    internal class CircleOCP : Shape
    {
        public double Radius { get; set; }
        public CircleOCP(double radius)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(this.Radius, 2) * Math.PI;
        }
    }
}
