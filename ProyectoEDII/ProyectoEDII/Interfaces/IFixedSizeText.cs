using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEDII.Interfaces
{
	public interface IFixedSizeText
	{
		int FixedSize { get; }
		string ToFixedSizeString();
	}
}
