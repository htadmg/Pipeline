using System.Text;

namespace Pipeline.Duplo
{
    public class EtapaDuplaPortas : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[PORTA]", 2);
            entrada.Insert(entrada.Length, "[PORTA]", 2);
            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;
            int posPortasEsquerda = entrada.ToString().IndexOf("[PORTA]");
            entrada.Insert(posPortasEsquerda, "[MAÇANETA]", 2);
            int posPortasDireita = entrada.ToString().LastIndexOf("[PORTA]") + 7;
            entrada.Insert(posPortasDireita, "[MAÇANETA]", 2);
            return entrada;
        }
    }
}