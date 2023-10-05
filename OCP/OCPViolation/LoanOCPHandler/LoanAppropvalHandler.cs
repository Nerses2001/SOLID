namespace SOLID.OCP.SRPViolation.LoanOCPHandler
{
    internal class LoanAppropvalHandler
    {
        public void ApprovePersonalLoan(PersonalLoanValidator validator)
        {
            if (validator.IsValid())
            {
                // Process of the loan
            }
        }

        public void ApproveVehicleLoan(VehicleLoanValidator validator)
        {
            if (validator.IsValid())
            {
                // Process of the loan
            }
        }
    }
}
