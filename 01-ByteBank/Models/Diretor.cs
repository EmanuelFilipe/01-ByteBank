namespace ByteBank.Models
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base (5000, cpf)
        {
                
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
