using System.Text;

namespace Pipeline.Simples
{
    public class EtapaCarroceria : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[CARROCERIA]", 1);
            entrada.Insert(entrada.Length, "[CARROCERIA]", 1);
            return entrada;
        }
    }
}