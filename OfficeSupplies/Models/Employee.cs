using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeSupplies.Models
{
    class Employee
    {
		public int EmployeeId { get; set; }

		private string firstName;
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}
		private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string address;
		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		private string department;

		public string Department
		{
			get { return department; }
			set { department = value; }
		}

		private string userName;

		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		private string password;
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public bool Login(string userName, string password)
		{
			if (password == Password && UserName == UserName)
			{
				return true;
			}
			return false;
		}

		//private SecureString ConvertToSecureString(string password)
		//{
		//	if (password == null)
		//		throw new ArgumentNullException("password");

		//	var securePassword = new SecureString();

		//	foreach (char c in password)
		//		securePassword.AppendChar(c);

		//	securePassword.MakeReadOnly();
		//	return securePassword;
		//}
	}
}
