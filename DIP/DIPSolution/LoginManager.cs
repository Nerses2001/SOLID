namespace SOLID.DIP.DIPSolution
{
    internal class LoginManager
    {
        IAuthenticator _simpleLogin;
        public LoginManager(IAuthenticator authenticator)
        {
            this._simpleLogin = authenticator;
        }
        public void Login(User user)
        {
            _simpleLogin.Authenticate(user);
        }
    }
}

