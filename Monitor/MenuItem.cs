using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Monitor
{
    class MenuItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Action Run { get; set; }

        
    }
}
