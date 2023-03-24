using static System.Environment;
using static ProjectGenerator.VanillaWebProjectGen;
using System.Linq;

Console.WriteLine("Project Generator");
seperator();


try
{
    string[] allowedArgs = { "vanilla-web", "express" };
    string[] passedArgs = GetCommandLineArgs();

    if (passedArgs.Length <= 1) {
        throw new ArgumentException("Project generator needs to know which kind of project to generate");
    } 
    else if (!allowedArgs.Contains(passedArgs[1])) {
        throw new ArgumentException($"The only valid arguments to pass are: {string.Join(", ", allowedArgs)}. You passed: {passedArgs[1]}");
    }   
    else
    {
        Console.WriteLine($"Chosen Project Type: {passedArgs[1]}");
    }


}catch (ArgumentException e)
{
    Console.WriteLine($"Error: {e.GetType()}");
    Console.WriteLine($"Message: {e.Message}");
}


void seperator()
{
    int separatorCount = 40;

    for (int i = 0; i <= separatorCount; i++) {
        Console.Write('-');

        if (i == separatorCount)
        {
            Console.WriteLine("\n");
        }
    }
}