using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class DoorControlClass
    {
        private readonly UserValidation _uv;
        private readonly Door _door;
        public void RequestEntry(string status)
        {
            status = _uv.ValidateEntryRequest();
            
            if(status == "OK")
            {
                _door.OpenDoor();
            }
            else
            {
                _door.CloseDoor();
            }
        }
    }
}
