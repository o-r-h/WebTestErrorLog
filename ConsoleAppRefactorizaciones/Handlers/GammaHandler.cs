using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using System;


namespace ConsoleAppRefactorizaciones.Handlers
{
    public class GammaHandler : HandlerBase
    {
        public override void Handle(ProcessRequest request)
        {
            Console.WriteLine("Processing Gamma...");
            request.IsGammaOk = true; // Succefull process

            if (request.IsGammaOk)
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
