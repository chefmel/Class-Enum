using System;

namespace Class_Enum
{       
    class Program
    {
            enum Student
            {
                Melissa,
                Grace,
                Lily,
                David,
                Henry,
                Ivy,
                Pilot,
                Max,
                Noah,
                Eli,
            }


            static void Main(string[] args)
            {
                Console.WriteLine("what is your first name");
                // int caseSwitch = 1;
                string FirstName = Console.ReadLine();

                switch (FirstName)
                {
                    case nameof(Student.Melissa):
                        Console.WriteLine("Doddruesing");
                        break;
                    case nameof(Student.Grace):
                        Console.WriteLine("DoddRuesing");
                        break;
                    case nameof(Student.Lily):
                        Console.WriteLine("Dodd");
                        break;
                    case nameof(Student.David):
                        Console.WriteLine("Walser");
                        break;
                    case nameof(Student.Ivy):
                        Console.WriteLine("Doddruesing");
                        break;
                    case nameof(Student.Henry):
                        Console.WriteLine("Doddruesing");
                        break;
                    case nameof(Student.Pilot):
                        Console.WriteLine("Doddruesing");
                        break;
                    case nameof(Student.Max):
                        Console.WriteLine("Doddruesing");
                        break;
                    case nameof(Student.Noah):
                        Console.WriteLine("Doddruesing");
                        break;
                    case nameof(Student.Eli):
                        Console.WriteLine("Doddruesing");
                        break;



                }

                Console.ReadLine();
            }
        }
    }


