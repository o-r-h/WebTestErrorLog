using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebTestErrorLog.LogErrores;
using WebTestErrorLog.Models;

namespace WebTestErrorLog.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		public IEnumerable<ErrorLogEntry> Get()
		{
			return ErrorLogger.errorLogs;
			//return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		public string Get(int id)
		{
			try
			{
				if (id == 10) {
					throw new InvalidOperationException("Forced exception for testing purposes.");
				}
				return "value";
			}
			catch (Exception ex)
			{
			
				int errorId = ErrorLogger.LogError(ex, this.GetType().FullName);
				var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent($"Ocurrio un problema: {errorId}", System.Text.Encoding.UTF8, "text/plain"),
					StatusCode = HttpStatusCode.NotFound
				};

				throw new HttpResponseException(response);
			}
			
		}

		// POST api/values
		public void Post([FromBody] string value)
		{

		}

		// PUT api/values/5
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
