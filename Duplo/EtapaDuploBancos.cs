using System.Text;

namespace Pipeline.Duplo
{
    public class EtapaDuplaBancos : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[BANCO]", 2);
            entrada.Insert(entrada.Length, "[BANCO]", 2);
            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;
            return entrada;
        }
    }
}