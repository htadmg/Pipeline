using System.Text;

namespace Pipeline.Duplo
{
    public class EtapaDuplaMotor : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Append("[MOTOR]");
            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;
            return entrada;
        }
    }
}