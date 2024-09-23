using ConsoleAppRefactorizaciones.EjemploBase;

namespace ConsoleAppRefactorizaciones.Chain
{
    public abstract class HandlerBase : IHandler
    {
       

        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void Handle(ProcessRequest request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }
    }

}
