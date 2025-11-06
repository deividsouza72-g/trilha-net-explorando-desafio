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

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Opção inválida. Quantidade de hóspedes excede a capacidade da Suite");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;

            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            Console.WriteLine($"Valor da diária: {Suite.ValorDiaria}");
            decimal valorTotal = Suite.ValorDiaria * DiasReservados;

            decimal valor = valorTotal;

            // Desconto de 10% acima de 10 diárias
            if (DiasReservados >= 10)
            {
                Console.WriteLine($"Quantidade de dias reservados: {DiasReservados}");
                Console.WriteLine("Desconto de 10% no valor total");
                valor = valorTotal - (valorTotal * 0.1M);
            }

            return valor;
        }
    }
}