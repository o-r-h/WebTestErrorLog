using ConsoleAppRefactorizaciones.EjemploBase;

namespace ConsoleAppRefactorizaciones.Chain
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(ProcessRequest request);
    }
}
