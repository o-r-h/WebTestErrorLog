using ConsoleAppRefactorizaciones.Funciones;
using ConsoleAppRefactorizaciones.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Cadena
{
    //aqui creamos y reutilizamos los handlers
    public static class HandlerFactory
    {
        public static IHandler CadenaGuardarFoto(IVerificarUsuario verificarUsuario, IGuardarFoto guardarFoto)
        {
            var verificarUsuarioHandler = new VerificarUsuarioHandler(verificarUsuario);
            var guardarFotoHandler = new CargarFotoHandler(guardarFoto);
            verificarUsuarioHandler.SetNext(guardarFotoHandler);
            return verificarUsuarioHandler;
        }

        public static IHandler CadenaGuardarFotoReniec(IVerificarUsuario verificarUsuario, IGuardarFoto guardarFoto, IDatosReniec datosReniec)
        {
            var verificarUsuarioHandler = new VerificarUsuarioHandler(verificarUsuario);
            var obtenerDatosReniec = new ObtenerReniecHandler(datosReniec);
            var guardarFotoHandler = new CargarFotoHandler(guardarFoto);
            verificarUsuarioHandler.SetNext(obtenerDatosReniec).SetNext(guardarFotoHandler);
            return verificarUsuarioHandler;
        }


        public static IHandler CadenaAlfaBetaGamma()
        {
            var alfaHandler = new AlfaHandler();
            var betaHandler = new BetaHandler();
            var gammaHandler = new GammaHandler();

            alfaHandler.SetNext(betaHandler).SetNext(gammaHandler);
            return alfaHandler;
        }


    }
}
