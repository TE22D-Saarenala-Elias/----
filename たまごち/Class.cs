public class たまごち{
    int hunger;
    int boredom;
    List <string> words = ["Hello", "bye", "ragnoirog", "wEOFIJOF"]; 
    bool isAlive;
    public Random generator = new Random();

    public string name;

    public void Feed(){
        hunger--;
        Console.WriteLine(name + ": jumi");

    } 

    public void Hi(){
        Console.WriteLine(name + ": "+ words[generator.Next(words.Count)]);
        ReduceBoredom();

    }

//     public void Teach (word : String){

//     }
    
//     public void Tick ()
//     {
//         if (isAlive)
//         {
//             boredom++;
//             hunger++;   
//             if (boredom >10||hunger >10)
//             {
//                isAlive=false;
//             }         
//         }
//         else {
//             Console.WriteLine("The Tamagochi is dead");
//         }
//     }

    public void PrintStats(){
        string condition;
        if(isAlive)
          {condition = "lever";}
          else {condition="död";}
        Console.WriteLine(name + "'s hunger is " + hunger+".\n"+ name +"'s boredom is "+ boredom +".\n Which means " + name + " is "  );
    }

    public bool GetAlive(){
        
        return isAlive;
    }

   private void ReduceBoredom(){
        boredom--;
        
    }
    


 }



// (+ betyder public, − betyder private)
// Tamagotchi
// − hunger: int
// − boredom: int
// − words: List<string>
// − isAlive: bool
// − generator: Random
//       + name: string
//       + Feed(): void
//       + Hi(): void
//       + Teach(word: string): void
//       + Tick(): void
//       + PrintStats(): void
//       + GetAlive(): bool
//       − ReduceBoredom(): void


