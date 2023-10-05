using SOLID.EmplyeeArchitecure;
using SOLID.ModelSrpSolution;
using SOLID.ModelSRPViolation;

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
    }
}