using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCalculoIdade
{
    internal class CalculoIdade
    {
        private int anoNacimento;

        public int AnoNacimento
        {
            get { return this.anoNacimento; }
            set { this.anoNacimento = value; }
        }
        private string nome = "";
        
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private int CalcularIdade()
        {
            int anoHoje, resultado;
            DateTime data = DateTime.Now;
            anoHoje = data.Year;
            resultado = anoHoje - this.anoNacimento;
            return resultado;
        }
        public void ExibirDados()
        {
            Console.WriteLine("seu nome é: {0}", this.Nome);
            Console.WriteLine("ano de nacimento: {0}",this.AnoNacimento);
            Console.WriteLine("idade: {0}", CalcularIdade());
        }
    }
}
