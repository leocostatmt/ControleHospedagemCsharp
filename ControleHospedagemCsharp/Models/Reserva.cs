namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
///<summary>
///cadastro de hospede
///</summary>
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                
                throw new Exception("Capacidade do quarto é menor que a quantidade de hospedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            decimal valor = DiasReservados * Suite.ValorDiaria;

           
            if (DiasReservados >= 10)
            {
                ///<summary>
                ///Se o dias reservados forem maior ou igual á 10,
                ///adicionar desconto de 10% ao valor final 
                ///</summary> 
                valor *= 0.9M;
            }
             Console.WriteLine($"desconto de 10% acrescido ao valor final");
            return valor;
        }
    }
}