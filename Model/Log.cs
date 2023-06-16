using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinStoreWF.Model
{
    internal class Log
    {
        public int Id { get; set; }
        public DateTime LogDateTime { get; set; }
        public string Description { get; set; }

        public Log()
        {
            Id = 0;
            LogDateTime = DateTime.MinValue;
            Description = string.Empty;
        }
        public Log(DateTime dateTime, string descriprion)
        {            
            LogDateTime = dateTime;
            Description = descriprion;
        }

        public override string ToString()
        {
            return $"{LogDateTime} - {Description}";
        }
    }
}
