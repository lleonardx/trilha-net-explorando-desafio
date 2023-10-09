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
            // * Implementado
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {   // * Implementado
                throw new Exception ("A quantidade de hóspedes excede a capacidade máxima da suite.");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           // * Implementado
            if(Hospedes != null)  
            {
                return Hospedes.Count();
            }
            else
            {
                return 0;
            }
            
        }

        public decimal CalcularValorDiaria()
        {
            // * Implementado
            // Cálculo: DiasReservados X Suite.ValorDiaria

            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = 0.10M;

            if(DiasReservados >= 10)
            {
                return valor *= desconto; //Aplica os 10% de desconto
            }

            return valor;
        }
    }
}