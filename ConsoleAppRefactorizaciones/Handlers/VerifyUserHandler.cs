using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;

namespace ConsoleAppRefactorizaciones.Handlers
{
	public class VerificarUserHandler: HandlerBase
	{
        private readonly IVerifyUser verifyUser;

		public VerificarUserHandler(IVerifyUser verifyUser)
		{
			this.verifyUser = verifyUser;
		}

		public override void Handle(ProcessRequest request)
        {
            Console.WriteLine("Process Verify User...");

            Response response =  verifyUser.VerifyUserData(request.RequestGetBase.User, request.RequestGetBase.Token);
            request.IsVerificarUserOk = response.Success; // todo Ok
            
            if (request.IsVerificarUserOk)
            {
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("Error user validation . Ending proces.");
                Console.WriteLine($"Response.Success: {response.Success}");
                Console.WriteLine($"Response.Message: {response.Message}");
            }
        }


    }
}
