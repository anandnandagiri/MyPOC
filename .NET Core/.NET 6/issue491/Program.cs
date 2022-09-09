// See https://aka.ms/new-console-template for more information
using issue491;

Console.WriteLine("Saving to database");


StudentContext cnt = new StudentContext();
Student st = new Student();
st.Name = "test";
st.Email = "test";
cnt.Students.Add(st);
cnt.SaveChanges();
Console.WriteLine("Student Saved to database");

foreach (var s in cnt.Students)
    Console.WriteLine($"{s.Name} {s.Email}");



