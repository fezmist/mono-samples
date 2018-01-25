using System;
using System.Collections.Generic;
using System.Linq;
using MonoSampleAspNetMVC.Model;
namespace MonoSampleAspNetMVC.Data
{
	public class UserRepository : IUserRepository
	{
		List<User> _Users = new List<User>();

		public UserRepository()
		{
			//populate dummy users
			if (_Users.Count <= 0)
			{
				_Users.Add(new User() { UserId = "User1", FirstName = "John", LastName = "Doe", EmailAddress = "john.doe@fake.com" });
				_Users.Add(new User() { UserId = "User2", FirstName = "Bill", LastName = "Bloggs", EmailAddress = "bill.bloggs@fake.com" });
				_Users.Add(new User() { UserId = "User3", FirstName = "Jill", LastName = "Doe", EmailAddress = "jill.doe@fake.com" });
				_Users.Add(new User() { UserId = "User4", FirstName = "Hillary", LastName = "Bloggs", EmailAddress = "hillary.bloggs@fake.com" });
			}
		}

		public List<User> GetAll()
		{
			return _Users;
		}

		public User GetById(string Id)
		{
			var user = _Users.Where(u => u.UserId.ToLower() == Id.ToLower()).SingleOrDefault();
			return user;
		}
	}
}
