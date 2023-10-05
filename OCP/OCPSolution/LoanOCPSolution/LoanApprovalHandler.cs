namespace SOLID.OCP.SrpSolution.LoanOCPSolution
{
    internal class LoanApprovalHandler
    {
        public void ApproveLoan(IValidator validator)
        {
            if (validator.IsValid())
            {
                //process the loan
            }
        }
    }
}
