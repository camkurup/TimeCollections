using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCollections.Model
{
	class TimeRegistration
	{
		private string project;
		private string customer;
		private string employee;
		private string activity;
		private string text = "";
		private string time = "00:00:00";
		
		public string Project { get { return project; } set { project = value; } }
		public string Customer { get { return customer; } set { customer = value; } }
		public string Employee { get { return employee; } set { employee = value; } }
		public string Activity { get { return activity; } set { activity = value; } }
		public string Text { get { return text; } set { text = value; } }
		public string Time { get { return time; } set { time = value; } }

		public TimeRegistration(string _project, string _customer, string _employee, string _activity, string _text)
		{
			this.project = _project;
			this.customer = _customer;
			this.employee = _employee;
			this.activity = _activity;
			this.text = _text;
		}

		public TimeRegistration() { }

	}
}
