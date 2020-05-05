using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEDII.Interfaces
{
	public interface ICreateFixedSizeText<T> where T : IFixedSizeText
	{
		T Create(string FixedSizeText);
		T CreateNull();
	}
}
