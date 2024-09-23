using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Clases
{
	public class RequestFoto
	{
		const int MaxSize = 9000000;
		
		public string Nombre { get; set; }
		public string Extension { get; set; }
		public int  LongitudByte { get; set; }
		public string MessageError { get; private set; }

		public bool IsValidFoto(){
			string[] Extensiones = new string[] { "jpg", "png", "bmp" };
			
			if (string.IsNullOrEmpty(Nombre)){
				MessageError = "Nombre no puede ser vacio";
				return false;
			}
			if (!Extensiones.Contains(Extension) )
			{
				MessageError = "Extension no valida";
				return false;
			}

			if (LongitudByte > int.MaxValue)
			{
				MessageError = $"Tamaño del archivo no debe ser mayor a { MaxSize}";
				return false;
			}

			return true;
		}
	}
}
