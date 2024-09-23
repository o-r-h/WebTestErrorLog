using ConsoleAppRefactorizaciones.Clases;

namespace ConsoleAppRefactorizaciones.Funciones
{
	public interface IGuardarFoto
	{
		Response GuardarFotoVisita(RequestFoto foto);
	}
}