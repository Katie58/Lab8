using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInputColumn();
            UserInputRow();
        }

        static void Header()
        {
            Console.Clear();
            Console.Write("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-19):  ");
        }

        /*static void UserInputColumn()
        {
            bool retry = true;
            while (retry)
            {

                ////////////////////////////////////////////////////////////////////////////////////////////////////////using column data
                var arrayList = new ArrayList();
                arrayList[0] = new string[19] { "Brian", "Tyler", "Damacious", "David", "Clayton", "Mauricio", "Jacky", "Rudy", "Evan", "Camille", "Steven", "Sean", "Heather", "Anthony", "Jonathan", "Nicholas", "Levi", "Andrea", "Kathleen" };
                arrayList[1] = new string[19] { "Wahler", "Carron", "White", "Hess", "Cox", "Reyna", "Chan", "Gall", "Simon", "Pouncy", "Webster", "Robinson", "Harper", "Todek", "Leech", "landau", "Sims", "Dabrowski", "Harrell" };
                arrayList[2] = new string[19] { "N/A", "N/A", "Mace", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "Steve", "Sean'O", "N/A", "Tony", "N/A", "N/A", "N/A", "N/A", "Katie" };
                arrayList[3] = new double[19] { 76, 76, 72, 71, 72, 67, 71, 68, 72, 63.75, 77, 71, 65, 72, 66.5, 68, 68, 65.5, 68 };
                arrayList[4] = new int[19] { 28, 18, 27, 23, 32, 19, 24, 20, 28, 26, 28, 31, 43, 27, 27, 23, 21, 24, 36 };
                arrayList[5] = new char[19] { 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'F', 'M', 'M', 'F', 'M', 'M', 'M', 'M', 'F', 'F' };
                arrayList[6] = new bool[19] { true, false, false, true, false, true, false, false, false, false, true, false, false, true, false, false, false, false, true };
                arrayList[7] = new string[19] { "MI", "MI", "MI", "MI", "IN", "MI", "MI", "MI", "OH", "MI", "OH", "MI", "MI", "MI", "MI", "MI", "MI", "MI", "MI" };

                Console.Write("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-19):");
                int index = int.Parse(Console.ReadLine());
                while (index < 1 || index > 20)
                {
                    Console.Write("\nThat student does not exist. Please try again. (enter a number 1-19): ");
                    UserInputColumn();
                }

                Console.WriteLine("Student {0} is {1}{2}. What would you like to know about {1}? (enter \"Nickname\", \"Height\", \"Age\", \"Gender\", \"Glasses\", \"Home State\")", index, firstName[index], lastName[index]);
                //switch (index)
                //  switch 1:
                retry = Retry();
            }
            Exit();
        }*/
        
        public static void UserInputRow()
        { ///////////////////////////////////////////////////////////////////////////////////////////////////////////using row data
            object[][] dataGrid = new object[20][];
            dataGrid[0] = new object[8] { "first name", "last name", "nickname", "height", "age", "gender", "glasses", "home state" };
            dataGrid[1] = new object[8] { "Brian", "Wahler", "N/A", 76, 28, 'M', true, "MI" };
            dataGrid[2] = new object[8] { "Tyler", "Carron", "N/A", 76, 18, 'M', false, "MI" };
            dataGrid[3] = new object[8] { "Damacious", "White", "Mace", 72, 27, 'M', false, "MI" };
            dataGrid[4] = new object[8] { "David", "Hess", "N/A", 71, 23, 'M', true, "MI" };
            dataGrid[5] = new object[8] { "Clayton", "Cox", "N/A", 72, 32, 'M', false, "OH" };
            dataGrid[6] = new object[8] { "Mauricio", "Reyna", "N/A", 67, 19, 'M', true, "MI" };
            dataGrid[7] = new object[8] { "Jacky", "Chan", "N/A", 71, 24, 'M', false, "MI" };
            dataGrid[8] = new object[8] { "Rudy", "Gall", "N/A", 68, 20, 'M', false, "MI" };
            dataGrid[9] = new object[8] { "Evan", "Simon", "N/A", 72, 28, 'M', false, "OH" };
            dataGrid[10] = new object[8] { "Camille", "Pouncy", "N/A", 62.75, 26, 'F', false, "MI" };
            dataGrid[11] = new object[8] { "Steven", "Webster", "Steve", 77, 28, 'M', true, "OH" };
            dataGrid[12] = new object[8] { "Sean", "Robinson", "Sean'O", 71, 31, 'M', false, "MI" };
            dataGrid[13] = new object[8] { "Heather", "Harper", "N/A", 65, 43, 'F', false, "MI" };
            dataGrid[14] = new object[8] { "Anthony", "Todek", "Tony", 60, 27, 'M', true, "MI" };
            dataGrid[15] = new object[8] { "Jonathan", "Leech", "N/A", 66.5, 27, 'M', false, "MI" };
            dataGrid[16] = new object[8] { "Nicholas", "Landan", "N/A", 68, 23, 'M', false, "MI" };
            dataGrid[17] = new object[8] { "Levi", "Sims", "N/A", 68, 21, 'M', false, "MI" };
            dataGrid[18] = new object[8] { "Andrea", "Dabrowski", "N/A", 65.5, 24, 'F', false, "MI" };
            dataGrid[19] = new object[8] { "Kathleen", "Harrell", "Katie", 68, 36, 'F', true, "MI" };

            Regex numeric = new Regex("[0-9]{ 1,19}");
            bool retry = true;
            while (retry)
            {
                Header();
                string key = Console.ReadLine();
                while (int.TryParse(key, out int index))
                {
                    //if (numeric.IsMatch(key))
                    if (index > 0 && index < 20)
                    {
                        while (retry)
                        {
                            var options = dataGrid[0].Skip(2).Take(6).ToArray();
                            string valueKey = string.Join(", ", options);
                            Regex valKey = new Regex(valueKey);
                            Console.WriteLine("Student {0} is {1} {2}. What would you like to know about {1}?\n({3}):  ", index, dataGrid[index][0], dataGrid[index][1], valueKey);
                            string selection = Console.ReadLine();
                            int request = 0;
                            foreach (string value in dataGrid[0])
                            {
                                for (int i = 0; i < 8; i++)
                                {
                                    string select = Convert.ToString(dataGrid[0][i]);
                                    if (select == selection)
                                    {
                                        request = i;                                       
                                    }                                  
                                }
                            }
                            Console.WriteLine("{0}: {1}",selection, dataGrid[index][request]);
                        }
                        Console.WriteLine("Find out more about {0}? (y/n)  ", dataGrid[index][0]);
                        retry = Retry();
                    }
                    else
                    {
                        Console.WriteLine("\nThat student does not exist. Please try again. (enter a number 1-19):  ");
                        key = Console.ReadLine();
                    }
                }
                Console.WriteLine("Choose another student from our class? (y/n)  ");
                retry = Retry();
            }
            Exit();
        }

        static bool Retry()
        {         
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
            {
                return true;
            }
            else if (key == ConsoleKey.N)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Input, Please Try Again...");
                bool retry = Retry();
                return retry;
            }
        }

        static void Exit()
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Exit();
            }
        }
    }
}
