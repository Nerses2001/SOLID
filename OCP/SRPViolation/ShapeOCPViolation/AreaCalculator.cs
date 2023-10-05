
namespace SOLID.OCP.SRPViolation.ShapeOCPViolation
{
    internal class AreaCalculator
    {
        /*       public double AreaCalc(params Rectangle[] rectangles)
               {
                   double area = 0;
                   foreach (var s in rectangles)
                   {
                       area += s.Width * s.Height;
                   }
                   return area;
               }
        */

        public double AreaCalc(params Object[] shapes)
        {
            double area = 0;
            foreach (var s in shapes)
            {
                if (s is Rectangle rect)
                {
                    area += rect.Width * rect.Height;
                }
                else
                {
                    Circle circle = (Circle)s;
                    area += Math.Pow(circle.Radius, 2) * Math.PI;
                }
            }
            return area;
        }
    }
}
