using static System.Environment;
using static ProjectGenerator.VanillaWebProjectGen;

Console.WriteLine("Project Generator");
seperator();


try
{
    string[] allowedArgs = { "vanilla-web" };
    string[] passedArg = GetCommandLineArgs();

    if (passedArg.Length <= 1)
    {
        throw new ArgumentException("Project generator needs to know which kind of project to generate");
    }
    else if (!allowedArgs.Contains(passedArg[1]))
    {
        throw new ArgumentException($"The only valid arguments to pass are: {string.Join(", ", allowedArgs)}. You passed: {passedArg[1]}");
    }

    Console.WriteLine($"Chosen Project Type: {passedArg[1]}");

    if (passedArg.Length >= 3)
    {
        Console.WriteLine($"Chosen Project Name: {passedArg[2]}");
        folderFileGen(passedArg[2]);
    }
    else
    {
        string projectName = "vanilla-web-project";
        Console.WriteLine($"Chosen Project Name: {projectName}");
        folderFileGen(projectName);
    }

    seperator();
    Console.ReadLine();
}
catch (ArgumentException e)
{
    errors(e);
}
catch (Exception e)
{
    errors(e);
}


void seperator()
{
    int separatorCount = 100;
    Console.Write("\n");

    for (int i = 0; i <= separatorCount; i++)
    {
        Console.Write('-');

        if (i == separatorCount)
        {
            Console.WriteLine("\n");
        }
    }
}

void errors(Exception e)
{
    Console.WriteLine($"Error: {e.GetType()}");
    Console.WriteLine($"Message: {e.Message}");
    seperator();
    Console.ReadLine();
}