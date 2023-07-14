using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name)
        {

        }
        public override void ChooseGesture()
        {
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            Random random = new Random();
            int randomIndex = random.Next(gestures.Count);
            string randomGesture = gestures[randomIndex];
            Console.WriteLine(randomGesture);
        }
    }
}