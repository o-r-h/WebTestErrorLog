using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;
using System.Collections.Generic;

namespace ConsoleAppRefactorizaciones.Chain

{
    public class Processor
    {
        const string ProcessSavePic = "ProcessSavePic";
        const string ProcessSavePicReniec = "ProcessSavePicReniec";
        const string SampleBasic = "SampleBasic";


        private readonly Dictionary<string, IHandler> _handlerChains;

        public Processor(IVerifyUser verifyUser, ISavePic savePic, IDataReniec dataReniec)
        {
            // setup the different chains of responsabilities
            _handlerChains = new Dictionary<string, IHandler>
        {
            { ProcessSavePic, HandlerFactory.ChainSavePicture(verifyUser, savePic) },
            { ProcessSavePicReniec, HandlerFactory.ChainSavePictureReniec(verifyUser, savePic, dataReniec) },
            { SampleBasic, HandlerFactory.ChainAlfaBetaGamma() }
            
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
                Console.WriteLine($"Chain type '{chainType}' does not exists.");
            }
        }
    }

}
