namespace ReviewExtensionMethod;
//class sử dụng theo các phương thức mở rộng (extension method)
//buộc phải là static class
//toàn bộ bên trong class đều phải là static

static class ExtMethod
{
    public static bool IsGreater(this int i, int value) => i > value;

    public static void Hi(this Program obj) => Console.WriteLine("xin chào");
}
