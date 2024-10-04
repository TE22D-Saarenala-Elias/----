たまごち　tamagutchi = new();


Console.WriteLine("Name your tamagutchi");
 tamagutchi.name = Console.ReadLine();
Console.WriteLine("Your tamagutchi is named " + tamagutchi.name);

    string answer; 
while (tamagutchi.GetAlive())
{
Console.WriteLine("\n select one of the commands:" +
     "\n 1: to teach " + tamagutchi.name + " a word." +
     "\n 2: to say hi." +
     "\n 3: to feed " + tamagutchi.name + "." +
     "\n or press enter to skip");

    answer = Console.ReadLine(); 
    if (answer=="1")
    {  Console.WriteLine("What word do you want to teach?");
       tamagutchi.Teach(Console.ReadLine());
    }
    else if (answer=="2")
    { tamagutchi.Hi();      
    }
    else if (answer=="3")
    { tamagutchi.Feed();
    }
    tamagutchi.Tick();
        
    tamagutchi.PrintStats();
    
}






Console.ReadLine();
