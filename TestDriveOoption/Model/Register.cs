using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDriveOoption.Model
{
    public class Register
    {
        //Message id
        public int Id { get; set; }

        //Mesage text
        public string Name{get; set; }

        //Message sender
        public string Mobile { get; set; }

        //Message time
        public DateTime date { get; set; }
    }
}
