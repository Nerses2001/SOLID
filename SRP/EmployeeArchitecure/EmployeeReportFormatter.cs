namespace SOLID.SRP.EmployeeArchitecure
{
    internal class EmployeeReportFormatter : ReportFormatter
    {
        public EmployeeReportFormatter(object o, FormatType formatType) : base(o, formatType) { }

        public string GetFormattedEmployee()
        {
            return _formattedOutput;
        }
    }
}
