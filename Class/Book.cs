using System;
namespace Class
{
	public class Book
	{
		public string name;
		public string author;

		public Book(string name,string author)
		{
			this.name = name;
			this.author = author;
		}
		public Book()
		{
			Console.WriteLine("Welcome baku");
		}
		public Book(string name)
		{
			Console.WriteLine("Salam");
		}
	}
}

