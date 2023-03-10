using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeCollections.Model;

namespace TimeCollections.Controller
{
	//in this class we creates a list of timeregistrations.
	//at some point later in the project, the idea is to make an API andthrough thart call a database. 
	//but for now the code is hardcoded.
	internal class TimeRegistrationController
	{
		
		List<TimeRegistration> timeRegistrations = new List<TimeRegistration>()
		{
			new TimeRegistration("project1", "Hans Hansen ApS", "JSH", "Programmering", "PIM Project"),
			new TimeRegistration("project2", "Malermester Søren & Søn AS", "JSH", "Konsulenttimer", "Kontogrupper"),
			new TimeRegistration("project3", "Elektrikeren ApS", "JSH", "Konsulenttimer", "Business Robot"),
			new TimeRegistration("project4", "VVSkovs ApS", "JSH", "Konsulenttimer", "Finansbudget"),
			new TimeRegistration("project5", "Marius M AS", "JSH", "Programmering", "Open Economy"),
			new TimeRegistration("project6", "LEMASH ApS", "JSH", "Programmering", "API"),
			new TimeRegistration("project7", "Lolland-Falsters Bryghus AS", "JSH", "Konsulenttimer", "PowerBI")
		};

		public List<TimeRegistration> GetTimeRegistrations()
		{
			return timeRegistrations;
		}
	}
}
