using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace My_Day4_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            YourTopJungler yourTopJungler = new YourTopJungler();

            Hashtable myHastable = yourTopJungler.yourTopJunglerHashtable();
            Console.WriteLine("Jungler name: " + myHastable[1]);
            Console.WriteLine("Jungler name: " + myHastable["Second"]);
            Console.WriteLine("Jungler name: " + myHastable[3.0]);

            Stack myStack = yourTopJungler.yourTopJunglerStack();
            Console.WriteLine("Base health of Lee Sin: " + myStack.Pop());

            Queue myQueue = yourTopJungler.yourTopJunglerQueue();
            Console.WriteLine("My favourite jungler: " + myQueue.Dequeue());


            Dictionary<int, string> yourDictionary = yourTopJungler.yourTopJunglerDictionary();
            foreach (KeyValuePair<int, string> dict in yourDictionary)
            {
                Console.WriteLine("{0}: Jungler name {1}", dict.Key, dict.Value);

                if (dict.Value == "Twitch" || dict.Key == 3)
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }

    class Champions
    {
        private long numberOfPlayers;
        private int numberOfChamps;
        private string colour;

        public long NumberOfPlayers { get => numberOfPlayers; set => numberOfPlayers = value; }
        public int NumberOfChamps { get => numberOfChamps; set => numberOfChamps = value; }
        public string Colour { get => colour; set => colour = value; }

        public Champions()
        {
            numberOfPlayers = 10000000000;
            numberOfChamps = 145;
        }

        public Champions(string colour)
        {
            this.Colour = colour;
        }

        public Champions(long numberOfPlayers, int numberOfChamps)
        {
            this.numberOfPlayers = numberOfPlayers;
            this.numberOfChamps = numberOfChamps;
        }

        public virtual void printNumberOfChampions()
        {
            Console.WriteLine("Total LoL players: " + numberOfPlayers + ", Total LoL champs: " + numberOfChamps);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + "\r\n");
        }

        public virtual void description()
        {
            Console.WriteLine("This is a Champion.");
        }
    }

    class TopLaner : Champions
    {
        public override void description()
        {
            Console.WriteLine("This is a Toplaner.");
        }

        public string[] SomeTopLaners()
        {
            // Arrays
            string[] toplaners = { "Wukong", "Malphite", "Darius", "Shen", "Jax" };

            foreach (string i in toplaners)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            return toplaners;
        }
    }

    class Jungler : Champions
    {

        public Jungler() { }

        public Jungler(long numberOfPlayers, int numberOfChamps) { }

        public Jungler(long numberOfPlayers, int numberOfChamps, string colour) : base(colour)
        {
            this.NumberOfPlayers = numberOfPlayers;
            this.NumberOfChamps = numberOfChamps;

        }

        public override void printNumberOfChampions()
        {
            Console.WriteLine("Total Jungle players: " + NumberOfPlayers + ", Total Jungle champs: " + NumberOfChamps);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + "\r\n");
        }

        public override void description()
        {
            Console.WriteLine("This is a Jungler.");
        }
    }

    class MyTopJungler : Jungler
    {
        private string name;

        public MyTopJungler()
        {
            name = "Warwick";
        }

        // Stringbuilder class for amending strings
        StringBuilder champName = new StringBuilder("Warwick");

        public int printLengthOfChamp()
        {
            int length = name.Length;
            Console.WriteLine("Length of Warwick: " + length);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + "\r\n");
            return length;
        }

        public string printUpperCaseOfChampName()
        {
            champName.ToString();
            champName.Append("Warwick");

            string upperCaseChampName = name.ToUpper();
            Console.WriteLine("Uppercase of Warwick: " + upperCaseChampName);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + "\r\n");
            return upperCaseChampName;
        }


        public MyTopJungler(string newName)
        {
            name = newName;
        }
        public string getChampionName()
        {
            return name;
        }

        public void setChampionName(string newName)
        {
            name = newName;
        }

        public void displayName()
        {
            Console.WriteLine("I am " + name);
        }

        public string abilityName(string abilityQ)
        {
            return abilityQ;
        }

        public string abilityName(string abilityQ, string abilityW)
        {
            return abilityQ + ", " + abilityW;
        }

        public string abilityName(string abilityQ, string abilityW, string abilityE)
        {
            return abilityQ + " - " + abilityW + " - " + abilityE;
        }

        public string abilityName(string abilityQ, string abilityW, string abilityE, string abilityR, out string abilityPassive)
        {
            abilityPassive = "Eternal Hunger";
            return abilityQ + " -- " + abilityW + " -- " + abilityE + " -- " + abilityR;
        }
    }

    class YourTopJungler : Jungler 
    {
        public YourTopJungler() { }

        Hashtable hashtable = new Hashtable();
        Stack stack = new Stack();
        Queue queue = new Queue();
        Dictionary<int, string> dictonary = new Dictionary<int, string>();


        public Hashtable yourTopJunglerHashtable()
        {
            hashtable.Add(1, "Vi");
            hashtable.Add("Second", "Rengar");
            hashtable.Add(3.0, "Elise");

            return hashtable;
        } 

        public Stack yourTopJunglerStack() 
        {
            stack.Push("LeeSin");
            stack.Push(null);
            stack.Push(250);
            stack.Push(750.0);
;
            return stack;
        }

        public Queue yourTopJunglerQueue()
        {
            queue.Enqueue("Gragas");
            queue.Enqueue(null);
            queue.Enqueue(100);
            queue.Enqueue(1050.0);
            return queue;
        }

        public Dictionary<int,string> yourTopJunglerDictionary() 
        {
            dictonary.Add(1, "Hecarim");
            dictonary.Add(2, "Rammus");
            dictonary.Add(3, "Khazix");
            dictonary.Add(4, "Twitch");
            dictonary.Add(5, "Kayn");

            return dictonary;
        }
    }
}
