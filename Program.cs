

/*
 * Program Name: Roster
 * Programmer: Jason Beard
 * Date: 12/19/2022
 *
 * Description: This program allowes users to create a list of names, with a first name,
 * last name, and gender. User can view list, which seperates the names based on grades. 
 * this is a c# console application
 *
 */

List<Freshman> freshmen = new List<Freshman>();
List<Sophmore> sophmores = new List<Sophmore>();
List<Junior> juniors = new List<Junior>();
List<Senior> seniors = new List<Senior>();

menu();

// initial menu to see or add to roster
void menu()
{
    string menuSelect = Prompt("Press 1 to view current roster\nPress 2 to add to roster.");
    if (menuSelect == "1")
    {
        viewRoster();
    }
    else if (menuSelect == "2")
    {
        addToRoster();
    }
    else
    {
        Console.WriteLine("\nPlease enter a valid Input");
        Thread.Sleep(2500);
        Console.Clear();
        menu();
    }
}


//Adds student to rester then displays current roster
void addToRoster()
{
   
    while (true)
    {
        string fn = Prompt("First name: ");
        string ln = Prompt("Last name: ");
        string g = Prompt("Gender\nM or F: ");
        string gy = Prompt("Graduation Year\n23, 24, 25, or 26: ");
        Console.Clear();

        switch (gy)
        {
            case "26":
                freshmen.Add(new Freshman(fn, ln, gy, g));
                Console.WriteLine(fn + ": Added to Roster\n");
                break;

            case "25":
                sophmores.Add(new Sophmore(fn, ln, gy, g));
                Console.WriteLine(fn + ": Added to Roster\n");
                break;

            case "24":
                juniors.Add(new Junior(fn, ln, gy, g));
                Console.WriteLine(fn + ": Added to Roster\n");
                break;

            case "23":
                seniors.Add(new Senior(fn, ln, gy, g));
                Console.WriteLine(fn + ": Added to Roster\n");
                break;

            default:
                Console.WriteLine("Year Invalid, Please retry.\n");
                break;
        }
        Thread.Sleep(1000);
        menu();
    }
}

// see roster
void viewRoster()
{
    Console.Clear();
    Console.WriteLine("Freshman: ");
    foreach (Freshman fm in freshmen)
    {
        Console.WriteLine(fm.lName + ", " + fm.fName + ", " + fm.gender);
    }

    Console.WriteLine("\nSophmores: ");
    foreach (Sophmore sm in sophmores)
    {
        Console.WriteLine(sm.lName + ", " + sm.fName + ", " + sm.gender);
    }

    Console.WriteLine("\nJuniors: ");
    foreach (Junior jr in juniors)
    {
        Console.WriteLine(jr.lName + ", " + jr.fName + ", " + jr.gender);
    }

    Console.WriteLine("\nSeniors: ");
    foreach (Senior sr in seniors)
    {
        Console.WriteLine(sr.lName + ", " + sr.fName + ", " + sr.gender);
    }
    string nav = Prompt("\n\nTo return to menu, type \"b\"");
    if (nav == "b")
    {
        Console.Clear();
        menu();

    }
}


//function to prompt user
string Prompt(string prompt)
{
    Console.WriteLine(prompt);
    return Console.ReadLine();
}