using System;
namespace ExercicioDeFic.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double anual, double gastoSaude): base(nome, anual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalcImposto()
        {
            if(Anual < 20000.0 && GastoSaude == 0)
            {
                return (Anual * 15 / 100);
            }else if(Anual >= 20000.0 && GastoSaude == 0)
            {
                return (Anual * 25 / 100);
            }
            else
            {
                return Math.Abs(Anual * 25 / 100) - (GastoSaude * 50 / 100);
            }
            
         
        }
    }
}
