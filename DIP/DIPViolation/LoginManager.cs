namespace SOLID.DIP.ISPViolation
{
    // High Lavel class 
    internal class LoginManager
    {
        SimpleLogin _simpleLogin = new SimpleLogin();
        public void Login(User user)
        {
            _simpleLogin.Authenticate(user);
        }
    }
}
