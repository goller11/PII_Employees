using System.Collections.Generic;
using Employees;
using Xunit;

namespace Library.Tests {
    public class EmployeesTests {
        [Fact]
        public void TestsCalculatePay () {
            double employee1BasePay = 1000;
            double employee1Bonus = 500;
            double employee1Salary = employee1BasePay + employee1Bonus;
            double employee2BasePay = 1200;
            SalesEmployee employee1 = new SalesEmployee ("Alice", employee1BasePay, employee1Bonus);
            Employee employee2 = new Employee ("Bob", employee2BasePay);
            Assert.Equal (employee1Salary, employee1.CalculatePay ());
            Assert.Equal (employee2BasePay, employee2.CalculatePay ());
        }

        [Fact]
        public void TestCalculatePayManager () {
            double employee1BasePay = 1000;
            double employee1Bonus = 500;
            double employee1Salary = employee1BasePay + employee1Bonus;
            double employee2BasePay = 1200;
            
            double employeeManager = 5405;
            double employeeMBS = 5000;

            SalesEmployee employee1 = new SalesEmployee ("Alice", employee1BasePay, employee1Bonus);
            Employee employee2 = new Employee ("Bob", employee2BasePay);
            
            List<Employee> employeesList = new List<Employee> ();
            employeesList.Add (employee1);
            employeesList.Add (employee2);

            SalesManager employeeMANAGER = new SalesManager ("Gonzalo", employeesList, employeeMBS, 0.15);
            Assert.Equal (employeeManager, employeeMANAGER.CalculatePay ());
        }
    }
}