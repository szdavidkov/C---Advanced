using System;
using System.Collections.Generic;

public static class OutputWriter
{
    public static void WriteMessage(string message)
    {
        ConsoleColor currenColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = currenColor;
    }

    public static void WriteMessageOnNewLine(string message)
    {
        ConsoleColor currenColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = currenColor;
    }

    public static void WriteEmptyLine()
    {
        Console.WriteLine();
    }

    public static void DisplayException(string message)
    {
        ConsoleColor currenColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = currenColor;
    }
    public static void PrintStudent(KeyValuePair<string, List<int>> student)
    {
        OutputWriter.WriteMessageOnNewLine(string.Format($"{student.Key} - {string.Join(", ", student.Value)}"));
    }

}

