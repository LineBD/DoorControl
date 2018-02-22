using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class KodeGenerator
    {
        public int code { get; set; }
        public int Code()
        {
            Random rnd = new Random();
            int code = rnd.Next(1, 4);
            return code;
        }
    }
}
