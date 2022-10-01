using Homework1;

string name;
string subject;
decimal salary;


Console.Write("Enter teacher's name: ");
name = Convert.ToString(Console.ReadLine());

Console.Write("Enter teacher's subject: ");
subject = Convert.ToString(Console.ReadLine());

Console.Write("Enter teacher's salary: ");
salary = Convert.ToDecimal(Console.ReadLine());


var teacher = new Teacher(name, subject, salary);


//var newSalary = teacher.IncreaseSalary();  //?
//teacher.Salary = newSalary;               //?




Console.WriteLine($"Name: {name}  Subject: {subject}   Salary: {salary}");
