using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class DoorControlClass
    {
        public IUserValidation UV { get; set; }
        public IDoor Door { get; set; }
        public IKodeGenerator KodeGenerator { get; set; }

        public DoorControlClass(IUserValidation uv, IDoor door, IKodeGenerator kodegenerator)
        {
            UV = uv;
            Door = door;
            KodeGenerator = kodegenerator;
        }
        public void RequestEntry(int status)
        {
            UV.ValidateEntryRequest(KodeGenerator.id);
            bool IDStatus = UV.ValidateEntryRequest(status);
            
            if( IDStatus== true)
            {
                Door.OpenDoor();
                Console.WriteLine("Door Open");
            }
            else
            {
                Door.CloseDoor();
                Console.WriteLine("Door closed");
            }
        }
    }
}
