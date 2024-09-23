using System.Linq;

namespace ConsoleAppRefactorizaciones.Clases
{
	public class RequestPic

	{
		const int MaxSize = 9000000;
		
		public string Name { get; set; }
		public string Extension { get; set; }
		public int  SizeByte { get; set; }
		public string MessageError { get; private set; }

		public bool IsValidFoto(){
			string[] Extensiones = new string[] { "jpg", "png", "bmp" };
			
			if (string.IsNullOrEmpty(Name)){
				MessageError = "Null name is not allowed";
				return false;
			}
			if (!Extensiones.Contains(Extension) )
			{
				MessageError = "type file not valid";
				return false;
			}

			if (SizeByte > int.MaxValue)
			{
				MessageError = $"Size can't be greater than { MaxSize}";
				return false;
			}

			return true;
		}
	}
}
