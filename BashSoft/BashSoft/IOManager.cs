using System;
using System.Collections.Generic;
using System.IO;
public static class IOManager
{
    public static void TraverseDirectory(string path)
    {
        OutputWriter.WriteEmptyLine();
        int initialIdentation = path.Split('\\').Length;
        Queue<string> subFolders = new Queue<string>();
        subFolders.Enqueue(path);

        while (subFolders.Count != 0)
        {
            subFolders.Dequeue();
            Console.WriteLine(path);
            subFolders.Enqueue(path);
        }

        var currentPath = subFolders.Dequeue();
        int identation = currentPath.Split('\\').Length - initialIdentation;
        Console.WriteLine(currentPath);

        foreach (var directoryPath in Directory.GetDirectories(currentPath))
        {
            subFolders.Enqueue(directoryPath);
        }

        OutputWriter.WriteMessageOnNewLine(string.Format("{0}{1}", new string('-', identation), currentPath));
    }
}