using System.Text;
using ReviewExtensionMethod;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
//nhập vào biến i
Console.WriteLine("vui lòng nhập số: ");
int i = int.TryParse(Console.ReadLine(), out int result)?result:0;
//xuất ra biến i
Console.WriteLine($"{nameof(i)} = {i}");

//so sánh i với giá trị bất kỳ
Console.WriteLine("so sánh giá trị i có lớn hơn 1 số bất kỳ");
Console.WriteLine(Valid.IsGreaterThan(i, 100) ? "i lớn hơn" : "i ko lớn hơn");


//so sánh i với giá trị bất kỳ, dùng extension method
Console.WriteLine("so sánh giá trị i có lớn hơn 1 số bất kỳ");
Console.WriteLine(i.IsGreater(100) ? "i lớn hơn" : "i ko lớn hơn");

int x = 50;

Console.WriteLine(x.IsGreater(10) ? "x>10" : "x<=10");

//===
Program pro1 = new();
pro1.Hi();
//ExtMethod.Hi(pro1);