// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Three Basic Arrays 
// 1
int[] numArray = new int[] {0,1,2,3,4,5,6,7,8,9};
// 2
string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
// 3
bool[] values = new bool[10];
for (int i = 0; i < values.Length; i++)
{
    values[i] = i % 2 == 0;
}

// List of Flavors
// 1
List<string> iceCreamFlavors = new List<string>()
{
    "Vanilla",
    "Chocolate",
    "Strawberry",
    "Coconut",
    "Gum",
    "Coffee"
};
// 2
Console.WriteLine("How many flavors are there? " + iceCreamFlavors.Count);
// 3
Console.WriteLine( "What is the third flavor of this list? " + iceCreamFlavors[2]); 
// 4
iceCreamFlavors.RemoveAt(2);
// 5
Console.WriteLine("How many flavors are there? " + iceCreamFlavors.Count);

// User Dictionary
// 1
Dictionary<string,string> newDictionary = new Dictionary<string,string>();
// 2
List<string> Names = new List<string>()
{
    "Tim",
    "Martin",
    "Nikki",
    "Sara"
};

Random random = new Random();
Dictionary<string, string> flavorsWithNames = new Dictionary<string, string>();

foreach (string name in Names)
{
    int randomIdx = random.Next(iceCreamFlavors.Count);
    string flavor = iceCreamFlavors[randomIdx];

    flavorsWithNames.Add(name, flavor);
}
// 3
foreach (KeyValuePair<string, string> pair in flavorsWithNames)
{
    string name = pair.Key;
    string flavor = pair.Value;

    Console.WriteLine("Name: " + name + " - Favorite Flavor: " + flavor);
}