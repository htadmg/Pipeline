using System;
using System.Text;
using Pipeline.Duplo;
using Pipeline.Simples;

namespace Pipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pipeline Simples para Montagem de Veículos");
            var montagemVeiculo = new Pipeline<StringBuilder>();
            montagemVeiculo.AdicionarEtapa(new EtapaChassi());
            montagemVeiculo.AdicionarEtapa(new EtapaMotor());
            montagemVeiculo.AdicionarEtapa(new EtapaBancos());
            montagemVeiculo.AdicionarEtapa(new EtapaCarroceria());
            montagemVeiculo.AdicionarEtapa(new EtapaPortas());
            montagemVeiculo.AdicionarEtapa(new EtapaPintura());

            for (int i = 0; i < 10; i++)
            {
                var veiculo = montagemVeiculo.Processar(new StringBuilder());
                Console.WriteLine($"Veículo {i + 1:D2}: {veiculo.ToString()}");
            }

            Console.WriteLine("Pipeline Duplo para Montagem de Veículos");
            var montagemVeiculo2 = new PipelineDuplo<StringBuilder>();
            montagemVeiculo2.AdicionarEtapa(new EtapaDuplaChassi());
            montagemVeiculo2.AdicionarEtapa(new EtapaDuplaMotor());
            montagemVeiculo2.AdicionarEtapa(new EtapaDuplaBancos());
            montagemVeiculo2.AdicionarEtapa(new EtapaDuplaCarroceria());
            montagemVeiculo2.AdicionarEtapa(new EtapaDuplaPortas());
            montagemVeiculo2.AdicionarEtapa(new EtapaDuplaPintura());

            for (int i = 0; i < 10; i++)
            {
                var veiculo = montagemVeiculo2.Processar(new StringBuilder());
                Console.WriteLine($"Veículo {i + 1:D2}: {veiculo.ToString()}");
            }
        }
    }
}
