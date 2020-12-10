using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.General
{
    public class BaseModel
    {
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifieldDate { get; set; }
        public virtual int UserID { get; set; }
        public virtual int UserIDLastUpdate { get; set; }
    }
}
