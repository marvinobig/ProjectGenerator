using static System.Environment;
using static ProjectGenerator.VanillaWebProjectGen;

Console.WriteLine("Project Generator");
seperator();


try
{
    string[] allowedArgs = { "vanilla-web", "express" };
    string[] passedArg = GetCommandLineArgs();


    if (passedArg.Length <= 1)
    {
        throw new ArgumentException("Project generator needs to know which kind of project to generate");
    }
    else if (!allowedArgs.Contains(passedArg[1]))
    {
        throw new ArgumentException($"The only valid arguments to pass are: {string.Join(", ", allowedArgs)}. You passed: {passedArg[1]}");
    }
    //else
    //{
    //    Console.WriteLine($"Chosen Project Type: {passedArgs[1]}");
    //    Console.WriteLine(folderFileGen());
    //}
    //}
    Console.WriteLine($"Chosen Project Type: {passedArg[1]}");
    Console.Write("What would you like to call your project? (vanilla-web-project) ");
    
    string? projectName = Console.ReadLine();
    Console.Write("\n");


    if (projectName == "")
    {
        projectName = "vanilla-web-project";

        folderFileGen(projectName);
    }
    else
    {
        folderFileGen(projectName);
    }


}
catch (ArgumentException e)
{
    Console.WriteLine($"Error: {e.GetType()}");
    Console.WriteLine($"Message: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Error: {e.GetType()}");
    Console.WriteLine($"Message: {e.Message}");
}


void seperator()
{
    int separatorCount = 100;

    for (int i = 0; i <= separatorCount; i++)
    {
        Console.Write('-');

        if (i == separatorCount)
        {
            Console.WriteLine("\n");
        }
    }
}