using assi_2;
using System.Runtime.InteropServices;
//#region Q1
//person p5 = new person(3);
//internal struct person
//{
//    private int[] age;
//    private string[] name;
//    private int size;
//    public int Size { get; }

//    public person(int size)
//    {
//        Size = size;
//        age = new int[size];
//        name = new string[size];
//    }

//    public void addperson(int pos, int age1, string name1)
//    {
//        if (age is not null && name is not null)
//        {
//            if (pos <= Size)
//            {
//                age[pos - 1] = age1;
//                name[pos - 1] = name1;
//            }
//        }
//    }
//    public void disblay()
//    {
//        for (int i = 0; i < age.Length; i++)
//        {
//            Console.WriteLine($"age = {age[i]} name = {name[i]}");
//        }
//    }

//}
//----------------main---------------------
//p5.addperson(1, 50, "samy");
//p5.addperson(2, 25, "adel");
//p5.addperson(3, 30, "fady");
//p5.disblay();
//#endregion
#region q2

//internal struct person
//{
//    private int age;
//    private string name;

//    public int Age { set; get; }
//    public string Name { set; get; }

//}
//}

//-----------main-------------
//person[] persons = new person[3];
//persons[0].Name = Console.ReadLine();
//persons[0].Age = int.Parse(Console.ReadLine());
//persons[1].Name = Console.ReadLine();
//persons[1].Age = int.Parse(Console.ReadLine());
//persons[2].Name = Console.ReadLine();
//persons[2].Age = int.Parse(Console.ReadLine());
//person oldestperson =new person();
//oldestperson.Age = 0;
//int i = 0;

//while (i< persons.Length)
//{
//    if (persons[i].Age > oldestperson.Age)
//    {
//        oldestperson= persons[i]; 
//    }
//    i++;
//}
//Console.WriteLine($"age = {oldestperson.Age} ---- name = {oldestperson.Name}");

#endregion

#region q3
//internal class employees
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int salary { get; set; }
//    public hiredate hiredate { get; set; }
//    public security_level security_level { get; set; }
//    public gender gender;
//    public override string ToString()
//    {
//        return $"id = {ID} name = {Name} security = {security_level} gender = {gender} salary = {salary}:c";
//    }
//}
//internal class hiredate
//{

//    private int Month;
//    private int Year;
//    private int Day;

//    public hiredate()
//    {
//    }

//    public hiredate(int month, int year, int day)
//    {
//        this.Month = month;
//        this.Year = year;
//        this.Day = day;
//    }
//    public int year { set; get; }
//    public int month { set; get; }
//    public int day { set; get; }
//}
//internal enum gender
//{
//    Male = 1, Female = 2
//}
//internal enum security_level
//{
//    guest = 1, Developer = 2, secretary = 3, DBA = 4
//}
//----------------MAIN----------------------
//employees [] emp = new employees[3];
//emp[0].ID = 5;
//emp[0].Name = "fady";
//emp[0].salary = 500;
//emp[0].gender = gender.Male;
//emp[0].hiredate = new hiredate(5, 2005, 16);
//emp[1].ID = 6;
//emp[1].Name = "emad";
//emp[1].salary = 5000;
//emp[1].gender = gender.Male;
//emp[1].hiredate = new hiredate(5,2008, 6);
//emp[2].ID = 5;
//emp[2].Name = "adel";
//emp[2].salary = 5882;
//emp[2].gender = gender.Male;
//emp[2].hiredate = new hiredate(1, 2005, 1);
#endregion