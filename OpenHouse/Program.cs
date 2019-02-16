using System;

namespace OpenHouse
{
    class Program
    {
        static string GetUserResponse(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            return response;
        }

        static bool IsAffirmative(string userResponse)
        {
            userResponse = userResponse.ToUpper();

            if (userResponse == "YES" || userResponse == "YEAH" || userResponse == "PLEASE")
            {
                return true;
            }
            else
            {
                return false;
            }
        }   
            
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Thank you for coming to my open house today!");
            string name = GetUserResponse("Whats your name?");
            Console.WriteLine("It's so nice to eet you, " + name + ".");                   
                               

            

            string answer = GetUserResponse("Would you like to see the house?");

            

                             if (answer == "yes")
                              {
                                
                                //ShowRoom(livingRoom);
                                //ShowRoom(diningRoom);
                                //ShowRoom(kitchen);
                                 Console.WriteLine("The house has an upstaris and a downstaris area!");

                              }
                              else
                               {
                                 
                                 Console.WriteLine("Oh dang, well it was very nice to meet you!");
                                 Console.ReadLine();
                
                              }

                                 Console.WriteLine("Would you like to take a one-sheet?");
                                 answer = Console.ReadLine();

                                 if (answer == "yes")
                                  {

                                    Console.WriteLine("Here you go!");

                                  }
                                 else
                                  {
                                  Console.WriteLine("Alright, have a good day!");
                                  }

                                  Console.WriteLine("Would you like to see the kitchen?");

                                  if (IsAffirmative(answer))

                            Console.WriteLine("The kitchen comes with a refrigerator that has its own build in ice machine!");
                            Console.WriteLine("Would you like to see the living room?");
                            Console.WriteLine("The living room conatins a nice pool set table!");

                            if (answer == "yes")
                            {
                            // show the living room
                            }
                            else
                            {
                            Console.WriteLine("Ok, well we will go to the next area!");
                            } 
                
                            Console.WriteLine("Would you like to go upstaris?");
                            Console.WriteLine("Upstairs has a major gameroom such as xbox, playstation, and nintendo!");
                            Console.WriteLine("Its the perfect place for someone who wants competition or to just have fun!");

                            if (IsAffirmative(answer))
                            {
                            // show the upstaris
                            }
                            else
                            {
                            Console.WriteLine("Ok, lets go to the next area!");
                            } 
            
                            
                                
                            

                                 






                         Console.ReadLine();
                

            
            

            }
        }
    }

