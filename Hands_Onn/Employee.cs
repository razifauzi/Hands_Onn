using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_Onn
{
    internal class Employee
    {

        int employeeID;
        string employeeName;

        public void SetEmployee(int pID, String pName)
        {
            employeeID = pID;
            employeeName = pName;
        }

        public int GetEmployeeID()
        {
           
            return employeeID;
        }
        public String GetEmployeeName()
        {

            return employeeName;
        }
    }
}
