﻿using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject.");
                    break;

                case "Science":
                    Console.WriteLine("Science is a tough subject.");
                    break;

                case "English":
                    Console.WriteLine("English is a tough subject.");
                    break;

                default:
                    Console.WriteLine($"I have not taken that subject before. {subject} sounds fun! ");
                    break;

            }
        }

        }
    }

