using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class Door : IDoor
    {
        public string DoorState { get; set; }
        public void OpenDoor()
        {
            Console.WriteLine("Door is open");
        }

        public void CloseDoor()
        {
            Console.WriteLine("Door is closed");
        }
    }
}
