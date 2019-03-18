using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentTest.Data.Entities
{
    public class Statstics
    {

        public Statstics()
        {
            TimeStamp = DateTime.Now;
        }
        public int Id { get; set; }
        public string UserEntry { get; set; }
        public string Result { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
