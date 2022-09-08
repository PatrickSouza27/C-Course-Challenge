namespace ExercicioDeFic.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; } 
        public double Anual { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(string nome, double anual)
        {
            Nome = nome;
            Anual = anual;
        }

        public abstract double CalcImposto();

    }
}
