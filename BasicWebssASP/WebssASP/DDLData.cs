using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebssASP
{
    public class DDLData
    {
        public int ValueID { get; set; }
        public string DisplayText { get; set; }

        public DDLData(int valueid,string displaytext)
        {
            ValueID = valueid;
            DisplayText = displaytext;

        }
        public DDLData()
        {
        }
    }
}