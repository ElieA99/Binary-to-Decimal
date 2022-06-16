Console.Title = "Binary To Decimal";
try
{
    for (int i = 0; ; i++)
    {
        Console.Write("Enter Binary Number: ");
        string input = Console.ReadLine();
        Console.Write("Decimal Number: ");
        Console.Write("{0}", Convert.ToInt32(input, 2));
        Console.WriteLine("\n");

        Console.Write("Enter Decimal Number: ");
        int inp = int.Parse(Console.ReadLine());
        Console.Write("Binary Number: ");
        Console.Write("{0}", Convert.ToString(inp, 2));
        Console.WriteLine("\n");

    }
    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
