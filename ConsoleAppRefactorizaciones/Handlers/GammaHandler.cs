using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using System;


namespace ConsoleAppRefactorizaciones.Handlers
{
    public class GammaHandler : HandlerBase
    {
        public override void Handle(ProcessRequest request)
        {
            Console.WriteLine("Procesando Gamma...");
            // Lógica para procesar Gamma
            request.IsGammaOk = true; // Simulación de procesamiento exitoso

            if (request.IsGammaOk)
            {
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("Error en Gamma. Terminando el procesamiento.");
            }
        }
    }
}
