namespace InterfaceCSharp;
public class SomeFile : IBinaryFile, ITextFile
{
    //thực thi các phương thức của interface
    //bổ từ truy cập (access modify) phải là public
    public void ReadFile() => Console.WriteLine("read file");
    public void WriteBinaryFile() => Console.WriteLine("write binary file");
    public void WriteTextFile() => Console.WriteLine("write text file");
}
