using ConsoleAppRefactorizaciones.EjemploBase;

namespace ConsoleAppRefactorizaciones.Cadena
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(ProcessRequest request);
    }
}
