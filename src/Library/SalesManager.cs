using System;
using System.Collections.Generic;

namespace Employees {
    public class SalesManager : Employee {

        public double Percentage { get; set; }
        List<Employee> employeesQuantity;
        public double salarioManager;
        public SalesManager (string name, List<Employee> employeesQuantity, double salarioBase, double Percentage)
        : base (name, salarioBase) 
        {
            this.employeesQuantity = employeesQuantity;
            this.Percentage = Percentage;
        }

        public override double CalculatePay() {

            double salarioPorcentaje = 0;
            foreach (Employee empleados in employeesQuantity){

                salarioPorcentaje += this.Percentage*empleados.CalculatePay() ;
            }
            return salarioManager = this.SalarioBase + salarioPorcentaje;
        }
    }
}