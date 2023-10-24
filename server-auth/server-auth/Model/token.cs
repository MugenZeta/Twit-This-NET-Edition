using System.Timers;
using Timer = System.Timers.Timer;

namespace Model
{

    public class token
    {
        private bool isActive = false;
        private Timer tokenStaleTimer;
    }
}