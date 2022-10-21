# JohnsonRRestaurantPicker

Richard Johnson

10-20-22

Restaurant Picker

This program will allow the user to pick from three different categories, each of which has 10 restaurants. When they pick one,
they will be given a randomly generated restaurant from one of the lists. After they get this, they can either end the program,
or pick another restaurant

Peer review: By Kenneth Fujimura
Everything works! I couldn't see much if any bugs. The code is very well organized and easy to follow. One of the things I liked about your code is how the looping worked, and giving the user the ability to decide to say no at the beginning. Using a switch method to determine the restaurants was different from most of the other programs I've seen, and it works pretty well. The only critiques I'd make are:
- Make sure you've filled out the the comments at the top of the vs code and fully followed the submission guidelines for doing so.
- When you take in inputs from the user, you declare a string, and set that equal to the value of a ReadLine(). And then after that you, use a ToUpper() in a separate line of code. That works 100%, but if you wanted to simplify your code a little, you could merge the two lines together, so it would look like:
\\string yesNo = Console.ReadLine().ToUpper();
And that would work the same.
- When you ask users to enter a category, when the user puts in the wrong inputs and the program gives an error message and tells users to try again, I would include instructions telling users to spell the categories in the exact same way you did, just for a little clarity.
- Your random number generator for whatever reason won't pull the last number for whatever reason. If you increase the scope to be "random.Next(1, 11)" for whatever reason it start pulling the last option in your switch statements. I'm not totally sure why that's the case, but that's how it is.
If you have any questions, let me know. Otherwise, everything looks really good! Congrats!