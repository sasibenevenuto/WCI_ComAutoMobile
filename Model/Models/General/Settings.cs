using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models.General
{
    public class Settings
    {
        private string ConnectionStringName { get; set; }
        public string ConnectionString
        {
            get { return ConnectionStringName; }
            set { ConnectionStringName = MD5Encryption.Decode(value); }
        }
    }
}
