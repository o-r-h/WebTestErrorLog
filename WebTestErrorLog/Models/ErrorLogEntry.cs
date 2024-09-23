using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTestErrorLog.Models
{
	public class ErrorLogEntry
	{
        public int Id { get; set; }
        public DateTime ErrorDateTime { get; set; }
        public string ClassName { get; set; }
        public string RouteName { get; set; }
        public string MethodName { get; set; }
        public string ErrorMessage { get; set; }
        public string InnerErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string Token { get; set; }
        public string Usuario { get; set; }

    }
}