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
                if (true)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new Exception("A capacidade da suíte é menor que o número de hospedes informado!");
                }
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
            decimal ValorDiaria = Suite.ValorDiaria;
            decimal valor = DiasReservados * ValorDiaria;

            if (DiasReservados > 10)
            {

                valor = valor - (valor * 10) / 100;
                return valor;
            }
            else
            {
                return valor;
            }
        }
    }
}