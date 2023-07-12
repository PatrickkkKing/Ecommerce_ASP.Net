using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm_2012500811.Shared
{
	public class Varian
	{
		[Key]
		public int IdVarian{ get; set; }
		public string NamaVarian { get; set; } = string.Empty;	
	}
}
