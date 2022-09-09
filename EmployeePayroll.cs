using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadExample
{
    public class EmployeePayroll
    {
        List<EmployeeDetails>listData=new List<EmployeeDetails>();  
        public void AddEmployeeToPayroll(List<EmployeeDetails> employeeDetails)
        {
            employeeDetails.ForEach(empData =>
            {
                Console.WriteLine("Emp being added" + empData.employeeName);
                this.AddEmployeePayroll(empData);
                Console.WriteLine("Employee Added : "+empData.employeeName);
            });
            Console.WriteLine(this.listData.ToString());
        }
         
        public void AddEmployeePayroll(EmployeeDetails employeeDetails)
        {
            listData.Add(employeeDetails);
        }


        public void AddEmployeeToPayRollWithThread(List<EmployeeDetails> listemployeedetails)
        {
            listemployeedetails.ForEach(employeedata =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added:" + employeedata.employeeName);
                    this.AddEmployeePayroll(employeedata);
                    Console.WriteLine("Employee  added:" + employeedata.employeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.listData.ToString());
        }
    }
}
