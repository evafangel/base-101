using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    protected string GSM = "088-maikata-na-rosen";
    protected string ime = "Ivan Georgiev";

    public virtual void GetInfo()
    {
        Console.WriteLine("Ime: {0}", ime);
        Console.WriteLine("GSM: {0}", GSM);
    }
}
class Employee : Person      // Клас Employee наследяващ клас Person 
{
    public string id = "ABC567EFG";    
    public override void GetInfo()
    {
        // Извиква базовия клас GetInfo и неговият метод:
        base.GetInfo();
        Console.WriteLine("Employee ID: {0}", id);
    }
}

class TestClass
{
    static void Main()
    {
        Employee E = new Employee(); //Променлива Е , която в долния ред играе ролята на Employee и ползва метода GetInfo
        E.GetInfo(); 
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    }
   
}


/*
Изход в конзолата:

Ime: Ivan Georgiev
GSM: 088-maikata-na-rosen
Employee ID: ABC567EFG

*/
