namespace SOLID.SRP.EmployeeArchitecure
{
    internal static class ClientModule
    {
        public static void HireNewEmployee(Employee employee)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.SaveEmployee(employee);
        }

        public static void terminateEmployee(Employee employee)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.DeleteEmployee(employee);
        }
        public static void PrintEmployeeReport(Employee employee, FormatType formatType)
        {
            EmployeeReportFormatter formatter = new(employee, formatType);
            Console.WriteLine(formatter.GetFormattedEmployee());
        }
        public static void ClientModuleMain()
        {
            Employee el = new(1, "Employee1", "Surgery", true);
            HireNewEmployee(el);
            PrintEmployeeReport(el, FormatType.CSV);

        }
    }
}
