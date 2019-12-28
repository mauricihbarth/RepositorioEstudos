using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ListEmployes {
    class Employe {        
            public int Id { get; set ; }
            public string Name { get; set; }
            public double Salary { get; set; }

        public void IncrementarSalario(double porcentagem) {
            Salary += Salary * porcentagem / 100.0;
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }



}
