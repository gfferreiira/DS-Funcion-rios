using System;
using aula3Colecao.Models.Enuns;
using aula3Colecao.Models;

namespace aula3Colecao
{


   
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }
        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10 / 100);
        }

        public decimal CalcularDescontoVT(decimal Percentual)
        {
            decimal desconto = this.Salario * Percentual / 100;
            return desconto;
        }

        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia =
                string.Format("Periodo de experiência: {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
                return periodoExperiencia;
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }

        public bool ValidarCpf()
            {
                if (ContarCaracteres(Cpf) == 11)
                

                    return true;
                else
                    return false;
            }
            
    }
    
}