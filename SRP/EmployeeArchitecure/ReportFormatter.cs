namespace SOLID.SRP.EmployeeArchitecure
{
    internal class ReportFormatter
    {
        protected string _formattedOutput;

        public ReportFormatter(object o, FormatType formatType)
        {
            _formattedOutput = string.Empty;
            switch (formatType)
            {
                case FormatType.XML:
                    _formattedOutput = ConvertObjectToXML(o);
                    break;
                case FormatType.CSV:
                    _formattedOutput = ConvertObjectToCSV(o);
                    break;

            }
        }
        private string ConvertObjectToXML(object obj)
        {
            return "Converted to XMl" + obj.ToString();
        }

        private string ConvertObjectToCSV(object obj)
        {
            return "Converted to CSV" + obj.ToString();
        }
    }
}
