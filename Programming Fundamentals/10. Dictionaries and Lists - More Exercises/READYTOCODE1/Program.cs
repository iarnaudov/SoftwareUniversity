using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string email { get; set; }

    public override string ToString()
    {
      //  return base.ToString();
      return Name +" "+ Age +" "+ email;
    }
}
class Program
{
    static void Main()
    {
        var students = new Student[]
        {
            new Student() {Name = "Pesho", Age = 20, email = "mary@abv.bg" },
            new Student() {Name = "Mimi", Age = 22, email = "mary@abv.bg" },
            new Student() {Name = "Koki", Age = 23, email = "mary@abv.bg" }
        };

        //List<string> studentsForPrint = students.OrderBy(s => s.Age).Select(s => s.Name + " " + s.Age).ToList();
        //Console.WriteLine(string.Join("\r\n", studentsForPrint));
        Console.WriteLine(string.Join(", ",students.OrderBy(s=>s.Name).Select(s => s.Name + " " + s.Age)));
    }
}

