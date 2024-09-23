using ConsoleAppRefactorizaciones.Clases;
using ConsoleAppRefactorizaciones.ExampleBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;


namespace ConsoleAppRefactorizaciones.EjemploBase
{
    public class ProcessRequest
    {
        //clases involucradas en el request
        public ClassesExample.Alfa Alfa { get; set; }
        public ClassesExample.Beta Beta { get; set; }
        public ClassesExample.Gamma Gamma { get; set; }
        public RequestGetBase RequestGetBase { get; set; }
        public VerifyUser verifyUser { get; set; }
        public RequestPic pic { get; set; }
        public RequestDataReniec RequestDataReniec { get; set; }

        //data para compartir entre procesos
        public Object DataReniecHandleResult { get; set; }

        //estados de los procesos
        public bool IsAlfaOk { get; set; }
        public bool IsBetaOk { get; set; }
        public bool IsGammaOk { get; set; }
        public bool IsVerificarUserOk { get; set; }
        public bool IsGuardarFotoOk { get; set; }
        public bool IsObtenerDatoReniecOk { get; set; }

    }
}
