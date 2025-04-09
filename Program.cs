using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;



namespace C__Learning
{
    internal class Program {
        static void Main()
        
        {
            //int a = 1;

            ////Students All Subjects Marks
            //string[] students = { "Dhoni", "Kohli", "Rohit", "Ashwin", "Boult" };
            //int[] physicsMarks = { 77, 18, 45, 99, 50 };
            //int[] chemistryMarks = { 75, 100, 95, 97, 91 };
            //int[] mathsMarks = { 90, 85, 100, 100, 85 };


            ////List<string> list = new List<string>();
            ////list.Add(1);

            ////Dictionary<int,string> obj = new Dictionary<int,string>();
            ////obj.Add(1, "kishore");
            //Console.WriteLine("Student Details:");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"{students[i]} - Physics: {physicsMarks[i]}, Chemistry: {chemistryMarks[i]}, Maths: {mathsMarks[i]}");
            //}

            //// All subjects passed students
            //Console.WriteLine("Students who passed all subjects:");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    if (physicsMarks[i] >= 50 && chemistryMarks[i] >= 50 && mathsMarks[i] >= 50)
            //    {
            //        Console.WriteLine(students[i]);
            //    }
            //}

            //// only maths centum students
            //Console.WriteLine("Students who scored centum in Maths:");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    if (mathsMarks[i] == 100)
            //    {
            //        Console.WriteLine(students[i]);
            //    }
            //}

            //Console.ReadLine();

            try
            {


                Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle(1);
            Vehicle vehicle3 = new Vehicle(3);
            vehicle1.EngineType = "Diesel";
            vehicle2.EngineType = "petrol";
            vehicle1 = vehicle2;
            vehicle2.EngineType = "Diesel";
            
            TwoWheeler TwoWheeler  =    new TwoWheeler();

            TwoWheeler.Wheeling();
            TwoWheeler.Wheeling("frontwheel");
            TwoWheeler.Wheeling("frontwheel", 30);

            int a = 1;
            int b = 2;
            a = b;
            b = 4;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("Vehicle1"+ vehicle1.EngineType);
            Console.WriteLine("Vehicle2" + vehicle2.EngineType);


                Console.WriteLine("Calculate time for Distance");

                Console.WriteLine("Enter Distance");

                short distance = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter Gear");

                short gear = Convert.ToInt16(Console.ReadLine());

                vehicle2.ShiftGear(gear);
                short time = vehicle2.CalculateDistance(distance);

                Console.WriteLine(time);
               


            }
            catch (IndexOutOfRangeException ex1)
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry please try again");
            }
            finally
            {
               


































































            }
            Console.ReadLine();
        }
    }
}


           
     



 