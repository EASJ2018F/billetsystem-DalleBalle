using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetsystem
{
    public class Transporttype
    {
        public string Nummerplade;
        public DateTime Dato;

        public virtual int Pris()
        {
            return 240;
        }

        public virtual string Køretøj()
        {
            return "Køretøj";
        }
    }
}
