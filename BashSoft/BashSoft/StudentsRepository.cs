﻿using System.Collections.Generic;
using System;

public static class StudentsRepository
{
    public static bool isDataInitialized = false;
    private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

    public static void InitializedData()
    {
        if (!isDataInitialized)
        {
            OutputWriter.WriteMessageOnNewLine("Reading data...");
            studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
            ReadData();

        }
    }

    private static void ReadData()
    {
        var input = Console.ReadLine();

        while (!string.IsNullOrEmpty(input))
        {
            var tokens = input.Split(' ');
            var course = tokens[0];
            var student = tokens[1];
            var mark = int.Parse(tokens[2]);

            if (!studentsByCourse.ContainsKey(course))
            {
                studentsByCourse.Add(course,new Dictionary<string, List<int>>());
            }

            if (!studentsByCourse[course].ContainsKey(student))
            {
                studentsByCourse[course].Add(student,new List<int>());
            }

            studentsByCourse[course][student].Add(mark);
            input = Console.ReadLine();
        }
        isDataInitialized = true;
        OutputWriter.WriteMessageOnNewLine("Data read!");
    }

    private static bool IsQueryForCoursePossible(string courseName)
    {
        if (isDataInitialized)
        {
            return true;
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
        }
        return false;

        if (studentsByCourse.ContainsKey(courseName))
        {
            return true;
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
        }
    }

    private static bool IsQueryForStudentPossible(string courseName, string studentUserName)
    {
        if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
        {
            return true;
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
        }
        return false;
    }

    public static void GetStudentScoreFromCourse(string courseName, string username)
    {
        if (IsQueryForStudentPossible(courseName,username))
        {
            OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username,studentsByCourse[courseName][username]));
        }
    }

    public static void GetAllStudentsFromCourse(string courseName)
    {
        if (IsQueryForCoursePossible(courseName))
        {
            OutputWriter.WriteMessageOnNewLine($"{courseName}:");
            foreach (var studentmarksEntry in studentsByCourse[courseName])
            {
                OutputWriter.PrintStudent(studentmarksEntry);
            }
        }
    }
}

