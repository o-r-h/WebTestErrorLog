using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using WebTestErrorLog.Models;

namespace WebTestErrorLog.LogErrores
{
	public static class ErrorLogger
	{

     
        public static  List<ErrorLogEntry> errorLogs;
        private static int currentId = 1;

        


        public static int LogError(Exception ex, string usuario, string servicio, string token, string routeName,  string fromClassName, [CallerMemberName] string caller = "")
        {
            string className = fromClassName; //typeof(ErrorLogger).; //new StackFrame(1).GetMethod().DeclaringType.Name;
            string cccc = new StackFrame(1).GetMethod().Attributes.ToString();
            string methodName = caller; // new StackFrame(1).GetMethod().Name;
            string errorMessage = ex.Message;
            string innerErrorMessage = ex.InnerException?.Message ??"";

            var errorLog = new ErrorLogEntry
            {
                Id = currentId,
                ErrorDateTime = DateTime.Now,
                ClassName = className,
                MethodName = methodName,
                ErrorMessage = errorMessage,
                InnerErrorMessage = innerErrorMessage,
                Usuario = usuario,
                StackTrace = ex.StackTrace,
                Token = token,
                RouteName = routeName,
            };

            Debug.Print("----------------------------------");
            Debug.Print(errorLog.Id.ToString());
            Debug.Print(errorLog.ClassName);
            Debug.Print(errorLog.MethodName);
            Debug.Print(errorLog.ErrorDateTime.ToString());
            Debug.Print(errorLog.ErrorMessage);
            Debug.Print(errorLog.InnerErrorMessage);
            Debug.Print("----------------------------------");
            currentId++;
            return errorLog.Id;
        }


        public static ErrorLogEntry GetErrorLog(int id)
        {
            lock (errorLogs)
            {
                return errorLogs.Where(x=>x.ErrorId == id).FirstOrDefault();
            }
        }


        public static List<ErrorLogEntry> GetErrorLogFullEntries() {

            return errorLogs.ToList();


        }

    }
}


