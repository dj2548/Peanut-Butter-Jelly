using System;
/*
Each sandwich requires 2 slices of bread, 2 tablespoons of peanut butter, and 4 teaspoons of jelly
Assume 1 sandwich per person
Assume 1 loaf of bread contains exactly 28 slices
Assume 1 jar of peanut butter contains exactly 32 tablespoons
Assume 1 jar of jelly contains exactly 48 teaspoons
totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf. 
But since we can't buy partial loaves, round up the answer. 
 */
bool run = true;
while (run == true)
{
    Console.WriteLine("How many people are we making PB&J sandwiches for?");

    string speople = Console.ReadLine();
    double numPeople = int.Parse(speople);
    double numSlices = numPeople * 2;
    double PB = numPeople * 2;
    double Jelly = numPeople * 4;

    double Loaf = Math.Ceiling(numSlices / 28);
    double JellyJar = Math.Ceiling((Jelly / 48));
    double PBJar = Math.Ceiling(PB / 32);

    Console.WriteLine(numSlices + " slices of bread");
    Console.WriteLine(PB + " tablespoons of peanut butter");
    Console.WriteLine(Jelly + " teaspoons of jelly");
    Console.WriteLine();
    Console.WriteLine(Loaf + " Loaves of bread");
    Console.WriteLine(PBJar + " Jar of peanut butter");
    Console.WriteLine(JellyJar + " Jars of jelly");
    Console.WriteLine();
    Console.WriteLine(" Would you like to continue?");
    string input = Console.ReadLine();
    if (input == "no" || input == "n")
    {
        Console.WriteLine("Goodbye");
        run = false;
    }
}