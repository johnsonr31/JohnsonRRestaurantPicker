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

            }
            else if(input == "CHINESE TAKEOUT")
            {
                // If the user chooses CHINESE TAKEOUT, they will recieve a random restaurant listed under CHINESE TAKEOUT
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
            }}
            else if(input == "ITALIAN")
            {
                // If the player chooses ITALIAN, they will recieve a random restaurant listed under ITALIAN
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