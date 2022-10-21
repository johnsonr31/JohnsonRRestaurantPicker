// Richard Johnson

// 10-20-22
//Peer review: By Kenneth Fujimura
//Everything works! I couldn't see much if any bugs. The code is very well organized and easy to follow. One of the things I liked about your code is how the looping worked, and giving the user the ability to decide to say no at the beginning. Using a switch method to determine the restaurants was different from most of the other programs I've seen, and it works pretty well. The only critiques I'd make are:
//- Make sure you've filled out the the comments at the top of the vs code and fully followed the submission guidelines for doing so.
//- When you take in inputs from the user, you declare a string, and set that equal to the value of a ReadLine(). And then after that you, use a ToUpper() in a separate line of code. That works 100%, but if you wanted to simplify your code a little, you could merge the two lines together, so it would look like:
// "string yesNo = Console.ReadLine().ToUpper();"
//And that would work the same.
//- When you ask users to enter a category, when the user puts in the wrong inputs and the program gives an error message and tells users to try again, I would include instructions telling users to spell the categories in the exact same way you did, just for a little clarity.
//- Your random number generator for whatever reason won't pull the last number for whatever reason. If you increase the scope to be "random.Next(1, 11)" for whatever reason it start pulling the last option in your switch statements. I'm not totally sure why that's the case, but that's how it is.
//If you have any questions, let me know. Otherwise, everything looks really good! Congrats!

bool playAgain = true;
bool pickRestaurant;
string input;
int restaurantChoice;

Console.Clear();
Console.WriteLine("Would you like to pick a restaurant to eat at?");
while(playAgain == true)
{
Console.Write("YES or NO: ");
string yesNo = Console.ReadLine();
yesNo = yesNo.ToUpper();

    if(yesNo == "NO")
    {
        // If the player types NO, playAgain will be declared false
        Console.WriteLine("Fine, go starve then.");
        playAgain = false;
    }
    else if
    (yesNo == "YES")
    {
        // If the player types YES, the program will give them some options they can choose from
        pickRestaurant = true;
        Console.WriteLine("Good, let's begin.");
        Console.WriteLine("Which category do you want to pick from? FAST FOOD, CHINESE TAKEOUT, or ITALIAN?");
        Console.Write("Pick one: ");
        while(pickRestaurant == true)
        {
            // The program will take the user's input, and convert it to all-caps
            input = Console.ReadLine();
            input = input.ToUpper();

            Random random = new Random();

            if (input == "FAST FOOD")
            {
                Console.Clear();
                // If the player chooses FAST FOOD, they will recieve a random restaurant listed under FAST FOOD
                restaurantChoice = random.Next(1, 10);
                switch(restaurantChoice)
                {
                    case 1: Console.WriteLine("McDonald's"); break;

                    case 2: Console.WriteLine("Jack in the Box"); break;

                    case 3: Console.WriteLine("Burger King"); break;

                    case 4: Console.WriteLine("Chick-Fil-A"); break;

                    case 5: Console.WriteLine("Subway"); break;

                    case 6: Console.WriteLine("In-N-Out Burger"); break;

                    case 7: Console.WriteLine("Popeye's"); break;

                    case 8: Console.WriteLine("Five Guys"); break;

                    case 9: Console.WriteLine("Arby's"); break;

                    case 10: Console.WriteLine("Carl's Jr"); break;
                }
                pickRestaurant = false;
            }
            else if(input == "CHINESE TAKEOUT")
            {
                // If the user chooses CHINESE TAKEOUT, they will recieve a random restaurant listed under CHINESE TAKEOUT
                Console.Clear();
                restaurantChoice = random.Next(1, 10);
                switch(restaurantChoice)
                {
                    case 1: Console.WriteLine("Panda Express"); break;

                    case 2: Console.WriteLine("East n West Chinese Cuisine"); break;

                    case 3: Console.WriteLine("Dynasty Restaurant"); break;

                    case 4: Console.WriteLine("Peking Restaurant"); break;

                    case 5: Console.WriteLine("Locke Garden"); break;

                    case 6: Console.WriteLine("Mandarin Villa"); break;

                    case 7: Console.WriteLine("Golden Bowl"); break;

                    case 8: Console.WriteLine("Lucky House"); break;

                    case 9: Console.WriteLine("Jade Fountain"); break;

                    case 10: Console.WriteLine("Mandarin Villa"); break;
                }
                pickRestaurant = false;
            }
            else if(input == "ITALIAN")
            {
                // If the player chooses ITALIAN, they will recieve a random restaurant listed under ITALIAN
                Console.Clear();
                restaurantChoice = random.Next(1, 10);
                switch(restaurantChoice)
                {
                    case 1: Console.WriteLine("Olive Garden"); break;

                    case 2: Console.WriteLine("Angelina's"); break;

                    case 3: Console.WriteLine("Mezzo"); break;
                    
                    case 4: Console.WriteLine("Pietro's"); break;
                    
                    case 5: Console.WriteLine("De Vega Brothers"); break;
                    
                    case 6: Console.WriteLine("Padella"); break;
                    
                    case 7: Console.WriteLine("Calzone Life"); break;
                    
                    case 8: Console.WriteLine("Pastosa by Lucia"); break;
                    
                    case 9: Console.WriteLine("Romano's Macaroni Grill"); break;
                    
                    case 10: Console.WriteLine("Gian's Delicatessen"); break;
                }
                pickRestaurant = false;
            }
            else
            {
                // If the player chooses anything aside from the three categories, they will have to enter their input again
                Console.WriteLine("That wasn't an option.");
                Console.Write("Please pick again: ");
            }
            

        }
            // After a restaurant has been randomly picked, the text below will be printed, and the program will loop back to the
            // YES or NO input from the beginning, allowing the user to either choose to pick again, or exit the program
            Console.WriteLine(" ");
            Console.WriteLine("I hope you are satisfied with your choice.");
            Console.WriteLine("Do you want to pick again?");
    }
    else
    {
        // If the user inputs anything aside from YES or NO, the program will print the text below to the console, and then go back
        // to the beginning of the loop so the user can try to input it again.
        Console.WriteLine("Invalid Input");
    }
    
}