using System.Collections.Generic;

namespace Pipeline.Simples
{
    public interface IEtapa<T>
    {
        T Processar(T entrada); 
    }
}