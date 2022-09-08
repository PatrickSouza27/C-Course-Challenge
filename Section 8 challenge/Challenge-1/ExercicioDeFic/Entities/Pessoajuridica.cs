namespace ExercicioDeFic.Entities
{
    internal class Pessoajuridica : Pessoa
    {
        public int NumeroFuncionario { get; set; }

        public Pessoajuridica(string nome, double anual, int numeroFuncionario):base(nome, anual)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        public override double CalcImposto()
        {
            if(NumeroFuncionario > 14)
            {
                return (Anual * 14 / 100);
            }
            else
            {
                return (Anual * 16 / 100);
            }
        }
    }
}
