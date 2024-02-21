namespace Class
{
	class Student
	{
		public string name;
		public string surname;
		public int age;
		public string adress;
		public string phone="12312312";

		public string GetFullName()
		{
			return name + " " + surname;
		}

		public string GetFullDatas()
		{
			string fullData = $"Name: {name} Surname: {surname} Age: {age} Adress:{adress} Phone:{phone}";
			return fullData;
		}
	}
}

