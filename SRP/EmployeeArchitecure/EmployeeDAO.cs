namespace SOLID.SRP.EmployeeArchitecure
{
    internal class EmployeeDAO
    {
        public void SaveEmployee(Employee employee)
        {
            Console.WriteLine($"{0} saved!!!", employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            Console.WriteLine($"{0} Deleted", employee);
        }


    }
}
