// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("=======================");
//? Create an integer array with the values 0-9 inside
int[] numArray = {0,1,2,3,4,6,7,8,9};


Console.WriteLine("=======================");
//? Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] nameArray = {"Tim", "Martin","Nikki","Sara" };



Console.WriteLine("==========Bools=========");
//? Create a boolean array of length 10. Then fill it with alternating tru/false values, starting with true. 
bool[] boolsArray = {true, false, true, false, true, false, true, false, true, false};
Console.WriteLine(boolsArray);


Console.WriteLine("==========Bools 2=========");
// >>OR<<
bool[] boolsArray2 = new bool[10];
for (int i = 1; i < boolsArray2.Length; i += 2 )
{
    boolsArray2[i] = true;
}
foreach (bool j in boolsArray2)
{
    Console.WriteLine(j);
}

Console.WriteLine("=======================");
//? Create a string list of Ice Cream flavors that holds at least 5 different flavors
List<string> iceCreamList = new List<string>();
iceCreamList.Add("Cheesecake");
iceCreamList.Add("Cookies & Cream");
iceCreamList.Add("Double Chocolate");
iceCreamList.Add("Coffee");
iceCreamList.Add("Mint Chip");
iceCreamList.Add("Cookie Dough");

//
Console.WriteLine(iceCreamList.Count);

Console.WriteLine("=======================");
//Output the third flavor in the list:
Console.WriteLine(iceCreamList[2]);


Console.WriteLine("=======================");
iceCreamList.RemoveAt(2);

Console.WriteLine("=======================");
Console.WriteLine(iceCreamList.Count);
foreach (string flavor in iceCreamList)
{
    Console.WriteLine(flavor);
}



Console.WriteLine("================================");
Console.WriteLine("=========USER DICTIONARY========");

Dictionary<string, string> users = new Dictionary<string, string>();

//set up new random list
Random rand = new Random();
//foreach name in array
foreach (string name in nameArray)
{
    //random int value for position of flavor
    int randomI = rand.Next(iceCreamList.Count);
    //turn flavor int into a flavor string
    string randomFlavors = iceCreamList[randomI];
    //add a name with a random flavor
    users.Add(name, randomFlavors);
}
//use built in to add strings together
foreach ( KeyValuePair <string, string> user in users)
{
    //write out the results 
    Console.WriteLine($"{user.Key}: {user.Value}");
}

Console.WriteLine("================================");










