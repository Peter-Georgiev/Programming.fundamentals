﻿using System;
using System.Collections.Generic;
using System.Linq;

class SortNumbers
{
    static void Main()
    {
        // in: 8 2 7 3   -  result: 2 <= 3 <= 7 <= 8
        List<double> inputNumber = Console.ReadLine()
            .Split(' ')
            .Select(Double.Parse)
            .ToList();


        inputNumber.Sort();

        Console.WriteLine(string.Join(" <= ", inputNumber));
    }
}