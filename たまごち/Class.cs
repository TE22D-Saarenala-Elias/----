public class たまごち{
    int hunger;
    int boredom;
    List <string> words = ["Hello", "bye"]; 
    bool isAlive=true;
    public Random generator = new Random();

    public string name;

    public void Feed(){
        hunger-=2;
        Console.WriteLine(name + ": jumi");

    } 

    public void Hi(){
        Console.WriteLine(name + ": "+ words[generator.Next(words.Count)]);
        ReduceBoredom();
       
    }

    public void Teach ( String word ){
        Console.WriteLine("\n"+ name + " learned the word "  + word + ".");
        words.Add(word);
        Console.WriteLine(name + ": " + words[words.Count -1] + "\n");
        ReduceBoredom();
    }
    
    public void Tick ()
    {
        if (isAlive)
        {
            boredom++;
            hunger++;   
            if (boredom >10||hunger >10)
            {
               isAlive=false;
            }         
        }
        else {
            Console.WriteLine("The Tamagochi is dead");
        }
    }

    public void PrintStats(){
        string condition;
        if(isAlive)
          {condition = "alive";}
          else {condition="dead";}
          if (hunger<0) 
           { hunger=0; }
           if (boredom<0)
           {boredom=0;}
        Console.WriteLine(name + "'s hunger is " + hunger+".\n"+ name +"'s boredom is "+ boredom +".\n Which means " + name + " is " + condition + "." );
    }

    public bool GetAlive(){
        
        return isAlive;
    }

   private void ReduceBoredom(){
        boredom-=2;
        
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


