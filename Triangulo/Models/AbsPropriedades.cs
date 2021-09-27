using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO.Triangulo.Models

{
    public abstract class AbsPropriedades

    {
        public double L1;
        public double L2;
        public double L3;

        public string Lado1;
        public string Lado2;
        public string Lado3;

        public string Resposta { get; set; }
        public string Mensagem { get; set; }

        private double l1;
        private double l2;
        private double l3;

        
        private string resposta { get; set; }
        private string mensagem { get; set; }

        public AbsPropriedades(double l1, double l2, double l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            
        }

        public AbsPropriedades(string lado1, string lado2, string lado3)
        {
            
           
        }

      
    }
}
