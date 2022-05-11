using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPracticeMay2022
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
    public class EmployeeDataAccesss : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hardcoded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
    public class DataAccessFactorys
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccesss();
        }
    }
    public class EmployeeBusinessLogics
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogics()
        {
            _EmployeeDataAccess = DataAccessFactorys.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
   //Now, the EmployeeBusinessLogic and EmployeeDataAccess classes are loosely 
   //coupled classes because EmployeeBusinessLogic does not depend on concrete
   //EmployeeDataAccess class, instead, it includes a reference of IEmployeeDataAccess
   //interface. So now, we can easily use another class that
   
}
