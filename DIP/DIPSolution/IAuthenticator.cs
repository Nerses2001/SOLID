namespace SOLID.DIP.DIPSolution
{
    internal interface IAuthenticator
    {
        bool Authenticate(User user);
    }
}
