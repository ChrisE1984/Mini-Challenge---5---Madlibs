//Chris Estrada
//9-10-2026
//Assignment Name Mini Challenge # 5 - Mad Lib
//Created a program with 10 prompts to ask users to input specific types of words and output them into a Madlib story.
//Peer Review:
//Review:

Console.Clear();

//each prompt has an output phrase associated with a user input to add to the story at the end
Console.WriteLine("Please Enter an Adjective:");
string firstAdj = Console.ReadLine();

Console.WriteLine("Please Enter a Noun:");
string firstNoun = Console.ReadLine();

Console.WriteLine("Please Enter a Plural Noun:");
string pluralNoun = Console.ReadLine();

Console.WriteLine("Please Enter a Verb ending in '-ing':");
string verb = Console.ReadLine();

Console.WriteLine("Please Enter a Color:");
string color = Console.ReadLine();

Console.WriteLine("Please Enter an Adjective:");
string secondAdj = Console.ReadLine();

Console.WriteLine("Please Enter a Number:");
string number = Console.ReadLine();

Console.WriteLine("Please Enter an Exclamation:");
string exclamation = Console.ReadLine();

Console.WriteLine("Please Enter a Noun:");
string secondNoun = Console.ReadLine();

Console.WriteLine("Finally lease Enter a Silly word:");
string sillyWord= Console.ReadLine();

//Used an output to write the title then complied the inputs into the story below.
Console.WriteLine("The Field Trip Story");
Console.WriteLine ("Today our class took a field trip to the " + firstAdj + " Museum of Ancient "+ firstNoun + ". We rode on a very loud bus with sticky " + pluralNoun +
". While our teacher was " + verb + ", my best friend dropped a " + color + " sandwich on the floor. It was so " + secondAdj + ". The tour guide showed us " + number +
" ancient artifacts. Suddenly, someone yelled " + exclamation + "! A wild " + secondNoun + " jumped out from behind a display case and shouted " + sillyWord + "! We all laughed and ran back to the bus.");
Console.WriteLine("Would you like to play again?");
