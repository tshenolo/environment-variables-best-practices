using System;

class Program
{
    static void Main()
    {
        string variableName = "YOUR_VARIABLE_NAME"; // Replace with your environment variable name

        string variableValue = Environment.GetEnvironmentVariable(variableName);

        if (variableValue != null)
        {
            Console.WriteLine($"Value of {variableName}: {variableValue}");
        }
        else
        {
            Console.WriteLine("Environment variable not found.");
        }
    }
}
