using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using System;


namespace ConsoleAppRefactorizaciones.Handlers
{
    public class AlfaHandler : HandlerBase
    {
        public override void Handle(ProcessRequest request)
        {
            Console.WriteLine("Processing Alfa...");
            request.IsAlfaOk = true; // successfull result

            if (request.IsAlfaOk)
            {
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("Error. Finishing process.");
            }
        }
    }
}
