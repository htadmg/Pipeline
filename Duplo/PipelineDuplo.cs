using System.Collections.Generic;

namespace Pipeline.Duplo
{
    public class PipelineDuplo<T>
    {
        private List<IEtapaDupla<T>> etapas = new List<IEtapaDupla<T>>();

        public PipelineDuplo<T> AdicionarEtapa(IEtapaDupla<T> etapa)
        {
            etapas.Add(etapa);
            return this;
        }

        public T Processar(T entrada)
        {
            for (int i = 0; i < etapas.Count - 1; i++)
            {
                etapas[i].ProximaEtapa = etapas[i + 1];
            }

            return etapas[0].Processar(entrada);
        }        
    }
}