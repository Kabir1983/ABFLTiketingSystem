using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMMON
{
    [Serializable]
    public class Error
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string PageName { get; set; }
        public string Trace { get; set; }
        public string Date { get; set; }
        public string Message { get; set; }
    }
}