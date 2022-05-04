namespace ByteBank.Models
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        // dessa maneira obtem o dado que quer sem muito gasto de memória
        // virtual = permite que o metodo seja sobre escrito por uma classe filha
        public abstract double GetBonificacao();
        //{
        //    return Salario * 0.10;
        //}

        public abstract void AumentarSalario();
        //{
        //    //Salario += (Salario * 0.1);
        //    Salario *= 1.1;
        //}

    }
}
