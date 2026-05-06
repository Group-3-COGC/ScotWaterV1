using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//holds the current business data while the user moves between forms
//this avoids passing lots of duplicate variables between forms
namespace ScotWaterV1
{
    //the current session data
    public class Business
    {
        public static Business CurrentBusiness = new Business();
    }
}
