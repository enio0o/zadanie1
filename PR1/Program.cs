﻿using System;

namespace PR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя:");
            string name = Console.ReadLine() ;
            Console.WriteLine("Привет, " +name+ ", сегодня " + DateTime.Now.ToLongDateString());
        }
    }
}
