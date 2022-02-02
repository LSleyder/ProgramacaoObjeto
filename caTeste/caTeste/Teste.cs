using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTeste
{
    internal class Teste
    {
        private int basis;
        private int altura;

        public void dadosRetângulo() 
        {
            Console.WriteLine("base = " + basis + " altura = " + altura);
            Console.ReadLine();
        }
        public void setBasis(int novoValor)
        {
            basis = novoValor;
        }
        public void setAltura(int novoValor)
        {
            altura = novoValor;
        }
    }
}
