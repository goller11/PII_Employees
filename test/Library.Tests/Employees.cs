using System;
using Xunit;
using Employees;

namespace Library.Tests
{
    public class EmployeesTests
    {
        [Fact]
        public void TestsCalculatePay()
        {
            double employee1BasePay = 1000;
            double employee1Bonus = 500;
            double employee1Salary = employee1BasePay + employee1Bonus;
            double employee2BasePay = 1200;
            SalesEmployee employee1 = new SalesEmployee("Alice", employee1BasePay, employee1Bonus);
            Employee employee2 = new Employee("Bob", employee2BasePay);
            Assert.Equal(employee1Salary, employee1.CalculatePay());
            Assert.Equal(employee2BasePay, employee2.CalculatePay());
        }
    }
}