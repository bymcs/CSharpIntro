using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class House
    {

        public House() { 
        
        }
        public int Id { get; set; }
        public string City { get; set; }

        private string Country { get; set; }

        protected string Name { get; set; }
    }


    public class HouseText : House
    {
        public HouseText()
        {
            
        }
    }
}

