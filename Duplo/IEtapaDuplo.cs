using System.Collections.Generic;
using Pipeline.Simples;

namespace Pipeline.Duplo
{
    public interface IEtapaDupla<T> : IEtapa<T>
    {
        IEtapaDupla<T> ProximaEtapa { get; set; }
    }
}