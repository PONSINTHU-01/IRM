try
{
    int x = 10, y = 0;
    int z = x / y;   
    Console.WriteLine(z);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You cannot divide by zero!");
}
catch (Exception ex)   
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("This block always runs.");
}

