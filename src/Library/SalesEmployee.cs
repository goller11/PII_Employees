using System;

namespace Employees {
    public class SalesEmployee : Employee 
    {

        public double Bono {get; set;}
        public SalesEmployee (string name, double SalarioBase, double Bono)
        : base(name, SalarioBase)
        {
            this.Bono = Bono;
        }

        public override Double CalculatePay(){

            return (this.SalarioBase + this.Bono);
        }
    }
}