namespace SOLID.OCP.SrpSolution.ShapeOCPSolution
{
    internal class AreaCalculatorOCP
    {
        public double AreaCalc(params Shape[] shapes) 
        {
            double totalArea = 0;
            foreach (Shape s in shapes)
            {
                totalArea += s.Area();
            }
            return totalArea;
        }
    }
}
