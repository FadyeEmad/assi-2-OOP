using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi_2
{
    internal class employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public hiredate hiredate { get; set; }
        public security_level security_level { get; set; }
       public  gender gender;
        public override string ToString()
        {
            return $"id = {ID} name = {Name} security = {security_level} gender = {gender} salary = {salary}:c";
        }
    }
}
