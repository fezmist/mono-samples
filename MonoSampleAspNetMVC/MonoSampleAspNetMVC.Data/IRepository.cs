using System;
using System.Collections.Generic;

namespace MonoSampleAspNetMVC.Data
{
	public interface IRepository<T> where T: new()
	{
		List<T> GetAll();
		T GetById(string Id);

	}

}
