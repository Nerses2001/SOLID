namespace SOLID.DIP.DIPSolution
{
    internal class SimpleLogin: IAuthenticator
    {
        //low Level class
        public bool Authenticate(User user)
        {
            // logic - databes
            return true;
        }
    }
}
