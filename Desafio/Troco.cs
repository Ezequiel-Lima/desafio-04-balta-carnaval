using System.Text;

namespace Desafio
{
    public class Troco
    {
        public Troco(double valorFinal, double pagamento)
        {
            Validar(valorFinal, pagamento);
            ValorFinal = valorFinal;
            Pagamento = pagamento;
        }

        public double ValorFinal { get; private set; }
        public double Pagamento { get; private set; }

        private double CalcularTroco()
        {
            return Pagamento - ValorFinal;
        }

        private void Validar(double valorFinal, double pagamento)
        {
            if (pagamento < valorFinal)
                throw new Exception("Valor invalido para realizar o pagamento");

            if (valorFinal < 0 || pagamento < 0)
                throw new Exception("Os valores devem ser positivos");           
        }

        private static readonly Dictionary<int, string> notas = new Dictionary<int, string>()
        {
            { 100, "nota de 100 reais" },
            { 50, "nota de 50 reais" },
            { 20, "nota de 20 reais" },
            { 10, "nota de 10 reais" },
            { 5, "nota de 5 reais" },
            { 2, "nota de 2 reais" },
            { 1, "moeda de 1 real" }
        };

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            double troco = CalcularTroco();
            stringBuilder.AppendLine($"Troco: R$ {troco.ToString("F2")}");

            foreach (int nota in notas.Keys)
            {
                int quantidadeNotas = (int)(troco / nota);
                if (quantidadeNotas > 0)
                {
                    troco = troco % nota;
                    stringBuilder.AppendLine($"{quantidadeNotas} {notas[nota]}");
                }                       
            }

            return stringBuilder.ToString();
        }
    }
}
