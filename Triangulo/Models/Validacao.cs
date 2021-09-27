using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO.Triangulo.Models
{
    public class Validacao : AbsPropriedades
    {
        public Validacao(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;

            validar();
        }

        private void validar()
        {
            try
            {
                this.L1 = Convert.ToDouble(this.Lado1);
                this.L2 = Convert.ToDouble(this.Lado2);
                this.L3 = Convert.ToDouble(this.Lado3);
                Resposta = "OK";
            }
            catch 
            {

                Resposta = "verifique se os valores estão corretos";
      
            }
        }
    }
}
