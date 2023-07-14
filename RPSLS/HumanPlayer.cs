using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override void ChooseGesture()
        {
            {
                Console.WriteLine($"{name} choose one:\n" +
                    $"\"rock\", \"paper\", \"scissors\", \"lizard\", \"Spock\n");
                chosenGesture = Console.ReadLine();
            }
        }
    }
    
}
