using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int computerPoint = 0;
            int userpoint = 0;
            int maxPoint;

            Console.WriteLine("");
            Console.WriteLine("Welcome to Rock Paper Scissors. Pleas write R for rock, P for Paper, S for Scissors");
            Console.WriteLine("");
            Console.WriteLine("First of all can you type what is the maximum point someone get ? \n3 is recommended : ");
            

            while (true)
            {
                try
                {

                    maxPoint = int.Parse(GetStringFromUser("MAX NUMBER: "));
                    break;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("It wasn't a number");
                }
            }



            bool a = true;
            while (a)
            {
                Console.WriteLine("");
                string user = GetStringFromUser("please choose what you want to play : ");
                int sayi = rastgele.Next(3);
                Console.Clear();

                switch (sayi)
                {
                    case 0:

                        Console.WriteLine("");
                        Console.WriteLine("Computer Choose : Rock");


                        if (user == "R" || user == "r")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("draw");
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else if (user == "P" || user == "p")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You get the point");
                            userpoint++;
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else if (user == "S" || user == "s")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computer get the point");
                            computerPoint++;
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Are you sure you read the instructions truly? Please choose between P, R, S");
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        break;

                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Computer Choose : Paper");


                        if (user == "P" || user == "p")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("draw");
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else if (user == "R" || user == "r")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You get the point");
                            userpoint++;
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else if (user == "S" || user == "s")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computer get the point");
                            computerPoint++;
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Are you sure you read the instructions truly? Please choose between P, R, S");
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Computer Choose : Scissors");


                        if (user == "S" || user == "s")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("draw");
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else if (user == "R" || user == "r")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You get the point");
                            userpoint++;
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else if (user == "P" || user == "p")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computer get the point");
                            computerPoint++;
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Are you sure you read the instructions truly? Please choose between P, R, S");
                            Console.WriteLine("");
                            Console.WriteLine("User Point {0}, Computer Point {1}", userpoint, computerPoint);
                        }
                        break;

                }
                if (userpoint == maxPoint || computerPoint == maxPoint)
                {

                    if (userpoint == maxPoint)
                    {

                        Console.WriteLine("---------------------");
                        Console.WriteLine("Congrulations You Won!");
                        Console.WriteLine("---------------------");
                    }
                    else
                    {
                        Console.WriteLine("Computer Won");
                    }

                    Console.WriteLine("Do you want to play again ? Y for yes N for no");
            
                    string isGameFinished = GetStringFromUser("YES OR NO: ");

                    if (isGameFinished == "Y" || isGameFinished == "y")
                    {

                        computerPoint = 0;
                        userpoint = 0;

                    }
                    else
                    {
                        a = false;
                    }
                }


            }
        }

        public static string GetStringFromUser(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

    }
}
