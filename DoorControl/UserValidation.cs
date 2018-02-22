using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class UserValidation
    {
        private readonly KodeGenerator _kg;
        private readonly Door _door;
        public string ValidateEntryRequest(int id)
        {
            string dør = "Fail";
            id = _kg.Code();
            if(id == 2)
            {
                dør = "OK";
            }
            else
            {
                dør = "Fail";
            }
            return dør;
            
            
        }
    }
}
