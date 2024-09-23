using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;
using System.Collections.Generic;

namespace ConsoleAppRefactorizaciones.Cadena
{
    public class Processor
    {
        const string ProcesoGuardarFoto = "ProcesoGuardarFoto";
        const string ProcesoGuardarFotoReniec = "ProcesoGuardarFotoReniec";
        const string EjemploBasico = "EjemploBasico";


        private readonly Dictionary<string, IHandler> _handlerChains;

        public Processor(IVerificarUsuario verificarUsuario, IGuardarFoto guardarFoto, IDatosReniec datosReniec)
        {
            // Inicializar las diferentes cadenas de responsabilidad
            _handlerChains = new Dictionary<string, IHandler>
        {
            { ProcesoGuardarFoto, HandlerFactory.CadenaGuardarFoto(verificarUsuario, guardarFoto) },
            { ProcesoGuardarFotoReniec, HandlerFactory.CadenaGuardarFotoReniec(verificarUsuario, guardarFoto, datosReniec) },
            { EjemploBasico, HandlerFactory.CadenaAlfaBetaGamma() }
            
        };
        }

        public void Process(ProcessRequest request, string chainType)
        {
            if (_handlerChains.ContainsKey(chainType))
            {
                _handlerChains[chainType].Handle(request);
            }
            else
            {
                Console.WriteLine($"Tipo de cadena '{chainType}' no reconocido.");
            }
        }
    }

}
