using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO.Triangulo.Models;

namespace Trabalho_POO.Triangulo
{
    public class Controle : Triangulo.Models.AbsPropriedades
    {
        public Controle(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;

            this.verificar();
        }

        private void verificar()
        {

            AbsPropriedades Validacao = new Validacao(this.Lado1, this.Lado2, this.Lado3);
          
            this.L1 = Validacao.L1;
            this.L2 = Validacao.L2;
            this.L3 = Validacao.L3;


            if (Validacao.Resposta == "OK")
            {
                AbsPropriedades VericaModeloTriangulo = new Triangulos(this.L1, this.L2, this.L3);
                this.Resposta = VericaModeloTriangulo.Resposta;
            }
            else
            {
                this.Resposta = Validacao.Resposta;
            }
        }
    }
}
