using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Handlers
{
    public class BetaHandler : HandlerBase
    {
        public override void Handle(ProcessRequest request)
        {
            Console.WriteLine("Procesando Beta...");
            // Lógica para procesar Beta
            request.IsBetaOk = true; // Simulación de procesamiento exitoso

            if (request.IsBetaOk)
            {
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("Error en Beta. Terminando el procesamiento.");
            }
        }
    }
}
