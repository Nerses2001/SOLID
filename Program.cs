using SOLID.OCP.SrpSolution.ShapeOCPSolution;
using SOLID.OCP.SRPViolation.ShapeOCPViolation;
using SOLID.SRP.EmployeeArchitecure;
using SOLID.SRP.ModelSrpSolution;
using SOLID.SRP.ModelSRPViolation;

internal class Program
{
    private static void Main(string[] args)
    {
        //Didn't save SRP
        Console.WriteLine("Dont Saved SRP");
        IPhone phone = new Phone();
        phone.Dial("01234556789");
        phone.Disconnect();
        phone.Send("Messege");
        phone.Recieve();

        //Saveed SRP
        Console.WriteLine(new string('_', 100));
        Console.WriteLine("Saved SRP");
        PhoneSRP phoneSRP = new(new ConnectionManagerImplementation(), new DataManagerImentation());
        phone.Send("Message text");
        phone.Recieve();
        phone.Dial("0123456789");
        phoneSRP.Disconnect();

        Console.WriteLine(new string('_', 100));
        ClientModule.ClientModuleMain();

        // Didn't save OCP
        Console.WriteLine(new string('_', 100));
        Rectangle rect1 = new(10,5);
        Rectangle rect2 = new(20,37.3);
        AreaCalculator ac = new ();
        Console.WriteLine(ac.AreaCalc(rect1,rect2));

        // Saved OCP
        RectangleOCP rectOCP1 = new(10, 5);
        RectangleOCP rectOCP2 = new(20, 37.3);
        AreaCalculatorOCP acOCP = new();
        Console.WriteLine(acOCP.AreaCalc(rectOCP1, rectOCP2));
        Console.ReadKey();

    }
}