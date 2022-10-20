// Richard Johnson

// 10-20-22

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
        Console.WriteLine("Alright, go starve then.");
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
                // If the player chooses FAST FOOD, they will recieve a random restaurant listed under FAST FOOD
                restaurantChoice = random.Next(1, 10);
                switch(restaurantChoice)
                {
                    case 1: Console.WriteLine("McDonald's"); break;

                    case 2: Console.WriteLine("Fast Food 2"); break;

                    case 3: Console.WriteLine("Fast Food 3"); break;

                    case 4: Console.WriteLine("Fast Food 4"); break;

                    case 5: Console.WriteLine("Fast Food 5"); break;

                    case 6: Console.WriteLine("Fast Food 6"); break;

                    case 7: Console.WriteLine("Fast Food 7"); break;

                    case 8: Console.WriteLine("Fast Food 8"); break;

                    case 9: Console.WriteLine("Fast Food 9"); break;

                    case 10: Console.WriteLine("Fast Food 10"); break;
                }

            }
            else if(input == "CHINESE TAKEOUT")
            {
                // If the user chooses CHINESE TAKEOUT, they will recieve a random restaurant listed under CHINESE TAKEOUT
                restaurantChoice = random.Next(1, 10);
                switch(restaurantChoice)
                {
                    case 1: Console.WriteLine("Panda Express"); break;

                    case 2: Console.WriteLine("Chinese Takeout 2"); break;

                    case 3: Console.WriteLine("Chinese Takeout 3"); break;

                    case 4: Console.WriteLine("Chinese Takeout 4"); break;

                    case 5: Console.WriteLine("Chinese Takeout 5"); break;

                    case 6: Console.WriteLine("Chinese Takeout 6"); break;

                    case 7: Console.WriteLine("Chinese Takeout 7"); break;

                    case 8: Console.WriteLine("Chinese Takeout 8"); break;

                    case 9: Console.WriteLine("Chinese Takeout 9"); break;

                    case 10: Console.WriteLine("Chinese Takeout 10"); break;
            }}
            else if(input == "ITALIAN")
            {
                // If the player chooses ITALIAN, they will recieve a random restaurant listed under ITALIAN
                restaurantChoice = random.Next(1, 10);
                switch(restaurantChoice)
                {
                    case 1: Console.WriteLine("Olive Garden"); break;

                    case 2: Console.WriteLine("Italian 2"); break;

                    case 3: Console.WriteLine("Italian 3"); break;
                    
                    case 4: Console.WriteLine("Italian 4"); break;
                    
                    case 5: Console.WriteLine("Italian 5"); break;
                    
                    case 6: Console.WriteLine("Italian 6"); break;
                    
                    case 7: Console.WriteLine("Italian 7"); break;
                    
                    case 8: Console.WriteLine("Italian 8"); break;
                    
                    case 9: Console.WriteLine("Italian 9"); break;
                    
                    case 10: Console.WriteLine("Italian 10"); break;
                }
            }
            else
            {
                // If the player chooses anything aside from the three categories, they will have to enter their input again
                Console.WriteLine("That wasn't an option.");
                Console.Write("Please pick again: ");
            }
            Console.WriteLine("I hope you are satisfied with your choice.");
            Console.WriteLine("Do you want to pick again?");
            pickRestaurant = false;
            

        }
    }
    else
    {
        //
    }
    //
}