namespace ConsoleAppRefactorizaciones.Funciones
{
	public interface IVerifyUser
	{
		Response VerifyUserData(string User, string token);
	}
}