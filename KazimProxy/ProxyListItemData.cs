using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazimProxy
{
    [Serializable()]
    public class ProxyListItemData
    {
        public Guid id { get; set; }

        public string ServerName { get; set; }
        public string IPAddress { get; set; }
        public int PortNumber { get; set; }
        public bool isActive { get; set; }
        public bool useSocks { get; set; }

        [NonSerialized]
        public decimal Runtime = 0;

        [NonSerialized]
        public bool isRunning = false;

        public ProxyListItemData()
        {
            id = Guid.NewGuid();
        }
    }
}
