using ExtremeBicycle.Models;

namespace ExtremeBicycle.Controllers
{
    [Serializable]
    public static class SesionManager
    {
        private static bool _loggedIn = false;
    public static void LogIn() 
        {
            _loggedIn = true;
        }
        public static bool loggedIn()
        {
            return _loggedIn;
        }
    }
}
