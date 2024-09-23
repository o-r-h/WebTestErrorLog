using ConsoleAppRefactorizaciones.Cadena;
using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;

namespace ConsoleAppRefactorizaciones.Handlers
{
	public class VerificarUsuarioHandler: HandlerBase
	{
        private readonly IVerificarUsuario verificarUsuario;

		public VerificarUsuarioHandler(IVerificarUsuario verificarUsuario)
		{
			this.verificarUsuario = verificarUsuario;
		}

		public override void Handle(ProcessRequest request)
        {
            Console.WriteLine("Procesando Verificar Usuario...");

            Response response =  verificarUsuario.VerificarDatoUsuario(request.RequestObtenerBase.Usuario, request.RequestObtenerBase.Token);
            request.IsVerificarUsuarioOk = response.Success; // todo Ok
            
            if (request.IsVerificarUsuarioOk)
            {
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("Error validando usuario. Terminando el procesamiento.");
                Console.WriteLine($"Response.Success: {response.Success}");
                Console.WriteLine($"Response.Message: {response.Message}");
            }
        }


    }
}
