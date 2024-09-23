namespace ConsoleAppRefactorizaciones.Funciones
{
	public interface IVerificarUsuario
	{
		Response VerificarDatoUsuario(string usuario, string token);
	}
}