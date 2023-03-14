// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] cupValues = new int[4]; //create a new array of size 4

cupValues[0] = 35;
cupValues[1] = 54;
cupValues[2] = 24;
cupValues[3] = 12;

Console.WriteLine(cupValues[0]); //35
cupValues = new int[6]; //create a new array using same variable

//Console.WriteLine(cupValues.Length); // prints out 6

//string[] words = { "fee", "fie", "foe", "fum"};

//string source = "this,that, the other";
//string[] elements = source.Split(",");
//Console.WriteLine(elements[0]); //this

//string name = "chris";
//char[] letter = name.ToCharArray();

//Console.WriteLine(name.IndexOf('r')); //2





Console.WriteLine();
Console.ReadLine();
string[] firstName = { "Sok", "Omar", "Tom", "Smith" };


for(int i = 0; i < 4; i++)
{
    char[] letters = firstName[i].ToCharArray();

    Console.WriteLine("The first letter of my name is " + " " + firstName[0]);

}


string[] peers = { "Joe", "Trey", "Mickee", "Omar" };
foreach (string s in peers)
{
    Console.WriteLine(s[0]);
}

for (int i = 0; i < peers.Length; i++)
{
    Console.WriteLine(peers[i][0]);
    //Console.WriteLine(peers[i].Substring(0, 1));
}


Console.WriteLine("Enter a word ");
string input = Console.ReadLine();
Console.WriteLine("Enter a letter ");
string letter = Console.ReadLine();
char search = letter[0];
string answer = "no";
for (int i = 0; i < input.Length; i++)
{

    if (input[i] == search)
    {
        answer = "Yes";
    }

}
Console.WriteLine(answer);


string listOfThings = "Football, Hockey, Baseball, Tennis";
string[] inputOfThings = listOfThings.Split(",");

Console.WriteLine(inputOfThings[0]);














