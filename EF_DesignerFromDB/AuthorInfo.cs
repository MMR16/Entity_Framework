using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DesignerFromDB
{
    public partial class author
    {
        public override string ToString()
        {
            return $"{au_id},,{au_fname},,{au_lname},,{phone},,{address},,{city},,{zip}";
        }
    }
}
