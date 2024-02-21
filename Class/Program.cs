using Class;

Student stu1 = new Student();

stu1.name = "Ilqar";
stu1.surname = "Shiriyev";
stu1.age = 23;
stu1.adress = "Bayil";

Student stu2 = new();

stu2.name = "Test";
stu2.surname = "Testov";
stu2.age = 22;
stu2.adress = "Baki";

string fullname = stu2.name + " " + stu2.surname;
//Console.WriteLine(fullname);

Student stu3 = new()
{
    name = "Test2",
    surname = "Testov2",
    age = 22,
    adress = "Nerimanov",
};

//Console.WriteLine(stu3.phone);

//Console.WriteLine(stu3.GetFullName());
//Console.WriteLine(stu2.GetFullName());

//Console.WriteLine(stu2.GetFullDatas());

Student[] students = { stu1, stu2, stu3 };

void ShowAll(Student[] datas)
{
    foreach (var item in datas)
    {
        Console.WriteLine(item.GetFullDatas());
    }
}

//ShowAll(students);


//Student GetByAge(Student [] datas,int age)
//{
//    Student foundStudent = new();
//    foreach (var data in datas)
//    {
//        if (data.age == age)
//        {
//            foundStudent = data;
//            break;
//        }
//    }
//    return foundStudent;
//}

//var result = GetByAge(students, 23);
//Console.WriteLine(result.GetFullDatas());

//Student GetBy(Student[] data,int age)
//{
//    var result = data.FirstOrDefault(m => m.age == age);
//    return result != null ? result : new Student();
//}

//var result = GetBy(students, 29);
//Console.WriteLine(result.GetFullDatas());

//int a = 7;
////Console.WriteLine(a==5 ? a : "deyil");
//var result = a == 7 ? a.ToString() : "deyil";
//Console.WriteLine(result);

//Student GetByAge(Student[] datas,int age)
//{
//    return datas.FirstOrDefault(m => m.age == age);
//}

//var result = GetByAge(students, 29);

//if (result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("Datas are not correct ");
//}

Book book1 = new("salam","sagol");

Console.WriteLine(book1.name+ " "+book1.author);

