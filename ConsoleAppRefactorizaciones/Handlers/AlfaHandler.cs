using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Handlers
{
    public class AlfaHandler : HandlerBase
    {
        public override void Handle(ProcessRequest request)
        {
            Console.WriteLine("Procesando Alfa...");
            // Lógica para procesar Alfa
            request.IsAlfaOk = true; // Simulación de procesamiento exitoso

            if (request.IsAlfaOk)
            {
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("Error en Alfa. Terminando el procesamiento.");
            }
        }
    }
}
