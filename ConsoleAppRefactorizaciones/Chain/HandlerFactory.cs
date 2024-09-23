using ConsoleAppRefactorizaciones.Funciones;
using ConsoleAppRefactorizaciones.Handlers;


namespace ConsoleAppRefactorizaciones.Chain
{
    //Here we can create the differents handlers
    public static class HandlerFactory
    {
        public static IHandler ChainSavePicture(IVerifyUser verifyUser, ISavePic savePic)
        {
            var verificarUserHandler = new VerificarUserHandler(verifyUser);
            var savePicHandler = new SavePictureHandler(savePic);
            verificarUserHandler.SetNext(savePicHandler);
            return verificarUserHandler;
        }

        //note reniec is a "service to return data from user"
        public static IHandler ChainSavePictureReniec(IVerifyUser verifyUser, ISavePic savePic, IDataReniec dataReniec)
        {
            var verificarUserHandler = new VerificarUserHandler(verifyUser);
            var obtenerDatosReniec = new GetReniecHandler(dataReniec);
            var savePicHandler = new SavePictureHandler(savePic);
            verificarUserHandler.SetNext(obtenerDatosReniec).SetNext(savePicHandler);
            return verificarUserHandler;
        }


        public static IHandler ChainAlfaBetaGamma()
        {
            var alfaHandler = new AlfaHandler();
            var betaHandler = new BetaHandler();
            var gammaHandler = new GammaHandler();

            alfaHandler.SetNext(betaHandler).SetNext(gammaHandler);
            return alfaHandler;
        }


    }
}
