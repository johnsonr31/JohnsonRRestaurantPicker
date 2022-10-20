// Richard Johnson

// 10-20-22

bool playAgain = true;
string input;


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
        Console.WriteLine("Good, let's begin.");
        Console.WriteLine("Which category do you want to pick from? FAST FOOD, CHINESE TAKEOUT, or ITALIAN?");
        Console.Write("Pick one: ");

        input = Console.ReadLine()
        input = input.ToUpper();

        if (input == "FAST FOOD")
        {
            //
        }
        else if(input == "CHINESE TAKEOUT")
        {
            //
        }
        else if(input == "ITALIAN")
        {
            //
        }
    }
    else
    {
        //
    }
    //
}