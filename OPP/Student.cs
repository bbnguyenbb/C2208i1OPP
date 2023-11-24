namespace OPP;
internal class Student
{
    //các field 
    int id;
    string? fullname;
    bool gender;
    DateTime dob;

    //constructor
    public Student() { }

    public Student(int id, string? fullname, bool gender, DateTime dob)
    {
        this.id = id;
        this.fullname = fullname;
        this.gender = gender;
        this.dob = dob;
    }



}
