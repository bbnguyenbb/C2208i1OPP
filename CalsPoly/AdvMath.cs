namespace CalsPoly;
public class AdvMath : BasicMath
{
    public override void Divide()
    {
        try
        {
            Console.WriteLine(NumberOne / NumberTwo);
        }
        catch(Exception) when(NumberTwo == 0)
        {
            Console.WriteLine("numbertwo phải khác 0");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
