public class Program
{
    public static void  Main()
    {
        Person person = new Person();
        person.greet();

        Student student = new Student();
        student.greet();
        student.SetAge(18);
        student.Study();
        student.showage();

        Teacher teacher = new Teacher();
        teacher.greet();
        teacher.Explane();
    }
}

public class Person
{
    protected int age;
    public void greet(){
        Console.WriteLine("Hello!");
    }
    public void SetAge(int n)
        { age = n; }
}

class Student : Person
{
    public void Study()
    { Console.WriteLine("I'm studying");
    }
    public void showage()
    {
        Console.WriteLine("My age id " + age + "years old");
    }
}

public class Teacher: Person
{
    public void Explane()
    {
        Console.WriteLine("I'm explaining");
    }
}