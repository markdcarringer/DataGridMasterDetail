using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMasterDetail
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public List<Order> Orders { get; }

        public Employee(string firstName, string lastName, string title, string notes)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Notes = notes;
            Orders = new List<Order>();
        }
    }
}
