try
{
    Console.Write("input a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("input b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a == b)
    {
        Console.WriteLine("a equals b");
    } else if (a > b)
    {
        Console.WriteLine("a is more than b");
    } else
    {
        Console.WriteLine("b is more than a");
    }
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}