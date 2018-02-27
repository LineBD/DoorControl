using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
   public interface IUserValidation
    {
        string dør { get; set; }
        string ValidateEntryRequest(int id);
    }
}
