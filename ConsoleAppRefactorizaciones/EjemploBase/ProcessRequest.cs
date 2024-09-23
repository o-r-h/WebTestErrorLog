using ConsoleAppRefactorizaciones.Clases;
using ConsoleAppRefactorizaciones.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.EjemploBase
{
    public class ProcessRequest
    {
        //clases involucradas en el request
        public Clases.Alfa Alfa { get; set; }
        public Clases.Beta Beta { get; set; }
        public Clases.Gamma Gamma { get; set; }
        public RequestObtenerBase RequestObtenerBase { get; set; }
        public VerificarUsuario verificarUsuario { get; set; }
        public RequestFoto foto { get; set; }
        public RequestConsultarReniec requestConsultarReniec { get; set; }

        //data para compartir entre procesos
        public Object DataReniecHandleResult { get; set; }

        //estados de los procesos
        public bool IsAlfaOk { get; set; }
        public bool IsBetaOk { get; set; }
        public bool IsGammaOk { get; set; }
        public bool IsVerificarUsuarioOk { get; set; }
        public bool IsGuardarFotoOk { get; set; }
        public bool IsObtenerDatoReniecOk { get; set; }

    }
}
