using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class DoorControlClass
    {
        private IDoor _door;
        //public IUserValidation UV { get; set; }
        //public IDoor Door { get; set; }
        //public IKodeGenerator KodeGenerator { get; set; }

        private enum DoorState
        {
            Closed,
            Opening,
            Closing,

        }

        private DoorState doorState;

        public DoorControlClass(Door door)
        {
            this._door = door;
            _door.CloseDoor();
            doorState = DoorState.Closed;
        }
        public void RequestEntry()
        {
            //UV.ValidateEntryRequest(KodeGenerator.id);
            //bool IDStatus = UV.ValidateEntryRequest(status);
            
            //if( IDStatus== true)
            //{
            //    Door.OpenDoor();
            //    Console.WriteLine("Door Open");
            //}
            //else
            //{
            //    Door.CloseDoor();
            //    Console.WriteLine("Door closed");
            //}
            switch (doorState)
            {
                case DoorState.Closed:
                 _door.OpenDoor();
                 doorState = DoorState.Opening;
                 break;

                case DoorState.Opening:
                    _door.CloseDoor();
                    doorState = DoorState.Closing;
                    break;

                case DoorState.Closing:
                    _door.CloseDoor();
                    doorState = DoorState.Closed;
                    break;

            }
        }
    }
}
