using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] Names = { "Abby", "Bobby", "Charity", "Debby", "Emma", "Falicia", "Gabriel", "Heather", "Inga", "Jazel", "Kammy", "Luise", "Margeret", "Naomi", "Oprah", "Penelope", "Quan", "Rebecca", "Shay", "Tammy" };
            string[] hometown = { "Ann arbor", "Bardoux", "Cincinatti", "Detroit", "Esexville", "Farwell", "Gaylord", "Hamilton", "Ingum", "Jarusalem", "Kansas City", "Langdon", "Monroe", "Nashville", "Omar", "Park City", "Quebec City", "Reno", "Saginaw", "Tempe" };
            string[] fFood = { "Apple", "Banana", "Cherry", "Durian", "Elderberry", "Focaccia", "Grape", "Hummus", "Ice cream", "Jack fruit", "Kuarma", "Lemonade", "Mango", "Nori", "Orzo", "Pumpkin Pie", "Quinoa", "Radish", "Spaghetti", "Tuna" };
            string[] fColor = { "Amarilo", "Blue", "Cyan", "Deep Purple", "Elving Green", "Forest Brown", "Grey", "Hip Pink", "Indigo", "Jamming Black", "Kimchi Red", "Lemonade Yellow", "Magenta","Nothing", "Orange", "Pea Grean", "Quiet Blue", "Red", "Superman Blue", "Tuna Pink" };

            ArrayList NamesArrayList = new ArrayList();
            NamesArrayList.AddRange(Names);

            ArrayList HometownArrayList = new ArrayList();
            HometownArrayList.AddRange(hometown);

            ArrayList fFoodArrayList = new ArrayList();
            fFoodArrayList.AddRange(fFood);

            ArrayList fFColorArrayList = new ArrayList();
            fFColorArrayList.AddRange(fColor);

            Console.WriteLine();
            Console.WriteLine("Hello, Welcome to your new school.");
            Console.WriteLine();

            Console.WriteLine("Some students said they would like you to know a little about them");
            Console.WriteLine("If you've met anyone maybe you would like to tell us about them.");
            Console.WriteLine();

bool AnotherStudent = true;
            while (AnotherStudent)
            {
            Console.WriteLine("Would you like to know about a student or would you like to tell us about a classmate?");
                Console.WriteLine();

            bool IncorrectAnswer = true;
            while (IncorrectAnswer)
            {
                Console.WriteLine("If you'd like to konw about a student type \"know\" if you would like to tell us about a student type \"tell\"");
                string TellKnow = Console.ReadLine().ToLower();
                if (TellKnow == "tell")
                {
                    
                    Console.WriteLine("OK, tell us about a student");

                        Console.Write("Please tell us their name: ");
                    string newName = Console.ReadLine();
                    NamesArrayList.Add(newName);

                        Console.Write("Please tell us their hometown: ");
                    string newHomtown = Console.ReadLine();
                    HometownArrayList.Add(newHomtown);

                        Console.Write("Please tell us their favorite food: ");
                    string newFavoriteFood = Console.ReadLine();
                    fFoodArrayList.Add(newFavoriteFood);

                        Console.Write("Please tell us their favorite color: ");
                    string newFavoriteColor = Console.ReadLine();
                    fFColorArrayList.Add(newFavoriteColor);


                   bool MoreStudents = true;
                    while (MoreStudents)
                    {
                        Console.WriteLine("Would you like to tell us about another student? yes or no?");
                        string TellMore = Console.ReadLine().ToLower();
                        if (TellMore == "yes")
                        {
                            MoreStudents = false;
                            IncorrectAnswer = true;
                        }
                        else if (TellMore == "no")
                        {
                            MoreStudents = false;
                            IncorrectAnswer = false;
                        }
                        else
                        {
                            MoreStudents = true;
                            Console.WriteLine("That wasn't the answer we were looking for");
                        }
                    }
                    }
                else if (TellKnow == "know")
                {
                    Console.WriteLine("Ok, lets get to know a student");
                    IncorrectAnswer = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry thats not an answer we're looking for");
                    IncorrectAnswer = true;
                }      
            }

            

            int counter = 0;
            foreach (string StudentNumber in NamesArrayList)
            {
                counter++;
                Console.WriteLine($"{counter}. {StudentNumber}");
            }
            


                Console.Write("Please choose a student ID number from the list: ");


                string input = Console.ReadLine();
                int index;
                bool Success = int.TryParse(input, out index);
                index--;

                if (index >= 0 && index < NamesArrayList.Count)
                {

                    if (Success)
                    {
                        bool GoOn = true;
                        while (GoOn)
                        {
                            Console.WriteLine($"What would you like to know about {NamesArrayList[index]}?");
                            while (GoOn)
                            {
                                Console.WriteLine("If you would like to know where she is from type \"Hometown\"");
                                Console.WriteLine("If you would like to know what her favorite food is type \"Favorite Food\"");
                                Console.WriteLine("If you would like to know what their favorite color is type \"Favorite Color\"");
                                Console.WriteLine();
                                string choice = Console.ReadLine().ToLower();
                                if (choice == "hometown")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(HometownArrayList[index]);
                                    GoOn = false;
                                }
                                else if (choice == "favorite food")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(fFoodArrayList[index]);
                                    GoOn = false;
                                }
                                else if (choice == "favorite color")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(fFColorArrayList[index]);
                                    GoOn = false;
                                }

                                else
                                {
                                    Console.WriteLine("I'm not sure what you're asking nor do we have that type of information.");
                                }
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("There is no student by that label");
                    }

                }

                else
                {
                    Console.WriteLine("We don't have that many students");
                    continue;
                }
                bool WrongEntry = true;
                while (WrongEntry)
                {
                    Console.WriteLine("Would you like to know about another student");
                    string again = Console.ReadLine().ToUpper();
                    if (again == "YES")
                    {
                        WrongEntry = false;
                        AnotherStudent = true;
                    }
                    else if (again == "NO")
                    {
                        WrongEntry = false;
                        AnotherStudent = false;

                    }
                    else
                    {
                        Console.WriteLine("Sorry I didn't understand your answer");
                        WrongEntry = true;
                    }
                }
            }
        }
    }
}



