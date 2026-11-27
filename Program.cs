StudentService studentService = new StudentService();

Student student = new Student()
{
    Id = 1,
    Name ="Jhon",
    Age =20,
    Adress ="KArabolo",
    Grades = [4,4,5,5,5,4]
};
studentService.AddStudent(student);
// System.Console.WriteLine(student.Id);
// System.Console.WriteLine(student.Name);
// System.Console.WriteLine(student.Age);
// System.Console.WriteLine(student.Adress);
// System.Console.WriteLine(studentService.Grades(1));
studentService.GetSudent();