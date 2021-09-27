using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO.Triangulo.Models
{
    public class Triangulos : AbsPropriedades
    {
        public Triangulos(double l1, double l2, double l3) : base(l1, l2, l3)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;

            verificar();
        }

        private void verificar()
        {

                if ((L1 == L2) && (L2 == L3))
                {
                    this.Resposta = "Triângulo Equilátero";
                }

                else if ((L1 == L2) || (L2 == L3) || (L1 == L3))
                {
                    this.Resposta = "Triângulo Isósceles";
                }
              
                else if ((L1 != L2) && (L2 != L3) && (L1 != L3))
            {
                this.Resposta = "Triangulo Escaleno";
            }

                else
            {
                this.Resposta = "Os valores digitados estão incorretos";
            }

        } 
    }
}

