using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


class AMinerTask
{
    static void Main()
    {
        string[] resourseType = File.ReadAllLines("input.txt");

        Dictionary<string, long> resourses = new Dictionary<string, long>();

        int i = 0;
        int j = 1;

        while (!resourseType[i].Equals("stop"))
        {
            long resourseQuantity = long.Parse(resourseType[j]);

            if (!resourses.ContainsKey(resourseType[i]))
            {
                resourses.Add(resourseType[i], 0);
            }
            resourses[resourseType[i]] += resourseQuantity;
            resourseType = File.ReadAllLines("input.txt");
            i+=2;
            j+=2;
        }

        foreach (var resourse in resourses)
        {
            File.AppendAllText("output.txt", string.Join("", $"{resourse.Key} -> {resourse.Value}\r\n"));
        }
    }
}