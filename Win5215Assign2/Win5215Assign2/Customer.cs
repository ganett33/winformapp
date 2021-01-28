using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win5215Assign2
{

    class Customer
    {
        public string FName { get; set; }  //Auto-implemented property
        public string LName { get; set; }  //Auto-implemented property
        public string Phone { get; set; }  //Auto-implemented property

        public Customer(string fn, string ln, string ph)  //Create construcor with 3 parameters
        {
            FName = fn;  //Aassigned variables
            LName = ln;
            Phone = ph;            
        }
        public string GetCustomer()  // String Method, display on listbox with format 
        {
            return $"{FName}\t{LName}\t{Phone}";
        }

    }
    
}
