namespace SOLID.SRP.EmployeeArchitecure
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private string _department;
        private bool _working;
        public Employee(int id, string name, string department, bool woeking)
        {
            _id = id;
            _name = name;
            _department = department;
            _working = woeking;
        }

        public override string ToString()
        {
            return $"Employee{{id={_id}, name={_name}, department='{_department}', working={_working}}}";


        }

    }
}
