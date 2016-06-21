using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace WeirdSampleApp
{
	public class Person
	{
		public string DisplayName { get; set; }
	}

	public partial class ListPage : ContentPage
	{
		ObservableCollection<Person> persons = new ObservableCollection<Person>();

		public ListPage()
		{
			InitializeComponent();

			PersonListView.ItemsSource = persons;

			persons.Add(new Person { DisplayName = "Rob Finnerty" });
			persons.Add(new Person { DisplayName = "Bill Wrestler" });
			persons.Add(new Person { DisplayName = "Dr. Geri-Beth Hooper" });
			persons.Add(new Person { DisplayName = "Dr. Keith Joyce-Purdy" });
			persons.Add(new Person { DisplayName = "Sheri Spruce" });
			persons.Add(new Person { DisplayName = "Burt Indybrick" });
		}


	}
}

