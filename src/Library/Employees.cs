using System;

namespace Employees {
    public class Employee {

        public string Name {get;}
        public double SalarioBase {get; set;}
        public Employee (String name, Double salarioBase) {
            this.Name = name;
            this.SalarioBase = salarioBase;
        }

        public virtual double CalculatePay(){

            return this.SalarioBase;
        }

    }
}