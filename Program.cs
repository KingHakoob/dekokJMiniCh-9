// Jacob Dekok
// 10/17/2022
// Mini Challenge #9 Restaurant Picker
// This is a console project that gives the user
// three categories to choice from and each has
// 10 restaurants. The program will then pick
// a random restaurent in the chosen category

Console.Clear();


string pickAgain = "YES";

while(pickAgain == "YES"){

    bool validChoice = false;

    string category = " ";
    Random random = new Random();

    string[] fastFood = {"Mc Donalds", "Carls Jr", "Wendys", "Taco Bell", "Sonic",
    "Panda Express", "In n Out", "Chic Fil A", "Caines", "Popeyes"};

    string[] delivery = {"Round Table", "Dominos", "Chinese", "Mountain Mikes", "Door Dash Chipotle",
    "Door Dash Sushi", "Door Dash Burger King", "Sandwich", "Door Dash Carls Jr", "Dennys"};

    string[] dineIn = {"Pizza Plus / Gold Dust Pizza", "Veronas", "Esmeraldas", "Masumi", "Mikes Grill House",
    "Brothers", "Taqueria", "Las Casuelas", "Texas Roadhouse", "Red Robbins"};

    string[] all = {"Mc Donalds", "Carls Jr", "Wendys", "Taco Bell", "Sonic",
    "Panda Express", "In n Out", "Chic Fil A", "Caines", "Popeyes", "Round Table", "Dominos", "Chinese", "Mountain Mikes", "Door Dash Chipotle",
    "Door Dash Sushi", "Door Dash Burger King", "Sandwich", "Door Dash Carls Jr", "Dennys", "Pizza Plus / Gold Dust Pizza", "Veronas", "Esmeraldas",
    "Masumi", "Mikes Grill House", "Brothers", "Taqueria", "Las Casuelas", "Texas Roadhouse", "Red Robbins"};


    while (!validChoice)
    {

    Console.WriteLine("Pick a category? 'fastFood' 'delivery' 'dineIn'");
    Console.WriteLine("Or type 'all' to generate from all categories.");
    category = Console.ReadLine().ToLower();

    switch(category)
    {

        case "fastfood":

        validChoice = true;

            int fastFoodIndex = random.Next(fastFood.Length);
            Console.WriteLine("");
            Console.WriteLine(fastFood[fastFoodIndex]);

        break;

        case "delivery":

        validChoice = true;

            int deliveryIndex = random.Next(delivery.Length);
            Console.WriteLine("");
            Console.WriteLine(delivery[deliveryIndex]);

        break;

        case "dineIn":

        validChoice = true;

            int dineInIndex = random.Next(dineIn.Length);
            Console.WriteLine("");
            Console.WriteLine(dineIn[dineInIndex]);

        break;

        case "all":

        validChoice = true;

            int allIndex = random.Next(all.Length);
            Console.WriteLine("");
            Console.WriteLine(all[allIndex]);

        break;

        defualt:

            Console.WriteLine("That was not a valid category");
            Console.WriteLine("Please enter a valid category");

        break;


    }

    }
    Console.WriteLine("");
    Console.WriteLine("Would you like pick another restaurant? 'YES' 'NO'");
    pickAgain = Console.ReadLine().ToUpper();

    if(pickAgain == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (pickAgain != "YES" && pickAgain != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }

}