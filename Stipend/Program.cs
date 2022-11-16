//doing area

//show you how we will call a different UI  from the main method and literally 
//have like 6 lines of code to run an entire program in the main method

using Stipend;

var student = new Student("173427", "Mathew", "Desjardins");

Console.WriteLine(student);


Console.WriteLine(student.Purchase(5));
Console.WriteLine(student);
Console.WriteLine(student.Purchase(10.00));
Console.WriteLine(student);
Console.WriteLine(student.Purchase(15.00));
Console.WriteLine(student);

