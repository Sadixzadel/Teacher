using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1;

class Teacher
{
    public string Name;
    public string Subject;
    public decimal Salary;
    public decimal additionalSalary;

    public Teacher(string name, string subject, decimal salary)
    {
        Name = name;
        Subject = subject;
        Salary = salary;
    }

    public void IncreaseSalary(decimal additionalSalary)
    {
        additionalSalary = 200;
        this.Salary += additionalSalary;
    }

    // public override string ToString()
    // {
    // Return his representation as String
    //   var builder = new StringBuilder();

    // builder.Append($"{Name , Salary , Salary} ");   //?

    //return builder.ToString();

    //}
}

