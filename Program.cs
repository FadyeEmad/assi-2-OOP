//using DEMO_OOP2;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DEMO_OOP2
//{
//    internal struct employees
//    {
//        //    #region atributes
//        //    private int id;
//        //    private string name;
//        //    private decimal empsalary;
//        //    #endregion
//        //    #region constructor
//        //    public employees(int Id, string Name, decimal salary)
//        //    {
//        //        id = Id;
//        //        name = Name;
//        //        Salary = salary;
//        //    }
//        //    #endregion
//        //    #region methods
//        //    public override string ToString()
//        //    {
//        //        return $" id = {id} \n name = {name} \n salary = {empsalary:c}";
//        //    }
//        //    #endregion

//        //    public string getname()
//        //    {
//        //        return name ;
//        //    }

//        //    public void setname(string Name)
//        //    { 
//        //        name = Name;
//        //    }

//        //    public int age
//        //    {
//        //        get; , set;
//        //    }
//        //    public decimal Salary
//        //    {
//        //        set
//        //        {
//        //            empsalary = value;
//        //        }
//        //        get
//        //        {
//        //            return Salary;
//        //        }
//        //    }
//        // }

//    }
//}

namespace oop00
{
    internal class prog
    {
        static void Main(string[] args)
        {
            // //employees employee = new employees(20,"fady", 1500);
            // employees employee = new employees(Salary: 533, Name: "fares ", Id: 66);
            // Console.WriteLine(employee.ToString());
            //employee.setname("fady");
            // Console.WriteLine(employee.getname());


            phonebook note = new phonebook(5);
            note.addperson(0, 01, "fady");
            note.addperson(1, 02, "fares");
            note.addperson(2, 03, "ahmed");
            Console.WriteLine(note.getnumber("ahmed"));
        }
    }




    internal struct phonebook
    {
        #region atribute
        private int[] num;
        private string[] name;
        private int size;
        #endregion
        public int Size { get; }
        public phonebook(int size)
        {
            Size = size;
            num = new int[size];
            name = new string[size];
        }
        public void addperson(int position, int number, string name1)
        {
            if (num is not null && name is not null)
            {
                if (position < Size)
                {
                    num[position] = number;
                    name[position] = name1;
                }
            }
        }
        public int getnumber(string name2)
        {
            int i = 0;
            while (i < name.Length)
            {
                if (name[i] == name2)
                {
                    return num[i];

                }
                else
                {
                    i++;
                }
            }
            return -1;

        }
    }

}