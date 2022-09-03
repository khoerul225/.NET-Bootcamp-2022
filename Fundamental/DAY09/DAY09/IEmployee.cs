using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY09
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();

        ///Generic Show List
        public void Showlist<T> (ref List<T> list);  

        public Employee FindEmployeeById(List <Employee> list, int id);


        //methode return wirth generice datatype<T>
        public decimal GetTotalSalary<T> (ref List<T> list);  ///Generic Total

        public List<Employee> FindListRange (List<Employee> list,decimal startForm,decimal endTo);

        //Agregate Summary
        public Dictionary<Employee, int> GetEmployeeByRole (List<Employee> list);

    }
}
