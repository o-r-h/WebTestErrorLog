using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones
{
	
		public abstract class ReqBase
		{
			const string Format = "yyyy-MM-dd";
			public string FechaInicio { get; set; }
			public string FechaFin { get; set; }

			public bool IsValid { get; private set; } = false;
			public string MessageError { get; private set; } = "";
			public int ErrorCodeResponse { get; private set; } = 0;

			private DateTime? fechaIniDateTime;
			private DateTime? fechaFinDateTime;

			public bool EvaluarFechas()
			{
				IsValid = true;
				MessageError = string.Empty;

			if (!TryParseDate(FechaInicio, out fechaIniDateTime, "Fecha inicial"))
				return false;

			if (!TryParseDate(FechaFin, out fechaFinDateTime, "Fecha final"))
				return false;

			if (fechaIniDateTime > fechaFinDateTime)
			{
				IsValid = false;
				MessageError = "La fecha final debe ser mayor que la fecha inicial.";
				ErrorCodeResponse = 400;
				return false;
			}

			return true;
		}

		private bool TryParseDate(string dateString, out DateTime? parsedDate, string fieldName)
		{
			if (DateTime.TryParseExact(dateString, Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
			{
				parsedDate = result;
				return true;
			}
			else
			{
				IsValid = false;
				MessageError = $"{fieldName} no es una fecha válida. Use el formato {Format}.";
				ErrorCodeResponse = 400;
				parsedDate = null;
				return false;
			}
		}


		public DateTime? GetFechaIniDateTime()
		{
			return fechaIniDateTime;
		}

		public DateTime? GetFechaFinDateTime()
		{
			return fechaFinDateTime;
		}

	}
	}

