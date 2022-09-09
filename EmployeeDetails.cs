using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadExample
{
    public class EmployeeDetails
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string phoneNumber { get; set; }

        public EmployeeDetails(int employeeId, string employeeName, string phoneNumber)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.phoneNumber = phoneNumber;
        }

    }
}
