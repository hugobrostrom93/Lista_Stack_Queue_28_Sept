using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stack_And_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<string> shoppingList = new Stack<string> ();
            //shoppingList.Push("Köpa mjölk");
            //shoppingList.Push("Köpa bröd");
            //shoppingList.Push("Köpa ägg");
            //PrintStack(shoppingList);

            //string text = TextEditor();
            //Console.Clear();
            //Console.WriteLine("Du skrev:");
            //Console.WriteLine(text);


            //var queue = new Queue<string>();
            //queue.Enqueue("9:00 Kolla mailen");
            //queue.Enqueue("9:30 Standup");
            //queue.Enqueue("9:45 Kaffe");
            //queue.Enqueue("10:00 programmering");
            //queue.Enqueue("11:15 Möte med kund");
            //queue.Enqueue("12:00 Lunch");
            //PrintQueue(queue);

            //var queue2 = new Queue<string>();
            //queue2.Enqueue("9:00 Kolla mailen");
            //queue2.Enqueue("9:30 Standup");
            //queue2.Enqueue("9:45 Kaffe");
            //queue2.Enqueue("10:00 programmering");
            //queue2.Enqueue("11:15 Möte med kund");
            //queue2.Enqueue("12:00 Lunch");
            //PrintQueue2(queue2);

            //var stack = new Stack<string>();
            //stack.Push("9:00 Kolla mailen");
            //stack.Push("9:30 Standup");
            //stack.Push("9:45 Kaffe");
            //stack.Push("10:00 programmering");
            //stack.Push("11:15 Möte med kund");
            //stack.Push("12:00 Lunch");
            //PrintStack1(stack);

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Hej");
            //queue.Enqueue("Hejdå");
            //Queue<string> queue2 = CopyQueue(queue);
            //PrintQueue(queue); // anropar metoden du skapade i förra övningen
            //PrintQueue(queue2); // anropar metoden du skapade i förra övningen

            //Queue<string> queue = new Queue<string> ();
            //queue.Enqueue("Hej");
            //queue.Enqueue("Hejdå");
            //Queue<string> queue2 = CopyQueue2(queue);
            //PrintQueue(queue); // anropar metoden du skapade i förra övningen
            //PrintQueue(queue2); // anropar metoden du skapade i förra övningen

            //Stack<string> stack = new Stack<string>();
            //stack.Push("Citron");
            //stack.Push("Apelsin");
            //stack.Push("Banan");
            //Queue<string> queue = StackToQueue(stack);
            //PrintQueue(queue); // anropar metoden du skapade i förra övningen

            string[] lessons = {"Föreläsning", "Föreläsning 2", "Kodning", "Lunch", "Kodning", "Föreläsning 2", "Kodning"};
            Queue<string> schema = GetSchema(lessons);
            foreach (string pass in schema)
            Console.WriteLine(pass);
            Console.WriteLine("Gå hem!");

        }

        public static void PrintStack(Stack<string> shoppingList)
        {
            Console.WriteLine("~ Shoppinglista ~");
            foreach (var x in shoppingList)
            {
                Console.WriteLine(x);
            }
        }

        public static string TextEditor()
        {
            // Deklarera variabler
            string text = "";
            Stack<string> undo = new();
            // Bearbeta
            while (true)
            {
                // Skriv ut texten
                Console.Clear();
                Console.WriteLine("--- Sunkig Texteditor med Undo funktion ---");
                Console.WriteLine("undo = ångra senaste raden\t\tend = avsluta");
                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();
                // vänta på inmatning
                string input = Console.ReadLine();
                if (input == "undo")
                {
                    // om användaren skrev undo, hämta historiken
                    if (undo.Count > 0) text = undo.Pop();
                }
                else if (input == "end")
                {
                    // om användaren skrev end avsluta loopen
                    break;
                }
                else
                {
                    // annars spara historiken
                    undo.Push(text);
                    text += input + Environment.NewLine;
                }
            }
            return text;
        }

        public static void PrintQueue(Queue<string> queue)
        {
            foreach (var x in queue)
            {
                Console.WriteLine(x);
            }
        }

        public static void PrintQueue2(Queue<string> xxxx)
        {
            while (xxxx.Count > 0)
            {
                Console.WriteLine(xxxx.Dequeue());
            }
        }

        public static void PrintStack1(Stack<string> xxx)
        {
            while (xxx.Count > 0)
            {
                Console.WriteLine(xxx.Pop());
            }
        }

        public static Queue<string> CopyQueue(Queue<string> queue)
        {
            // Deklarera variabler
            Queue<string> newQueue = new(); // skapa en ny queue
                                            // bearbeta och leverera resultat
            foreach (var row in queue)
            {
                // Kopiera värden från gamla kön till nya
                string value = row;
                // Lägg till det nya värdet i den nya listan
                newQueue.Enqueue(value);
            }
            return queue;
        }

        public static Queue<string> CopyQueue2(Queue<string> queue)
        {
            // deklarera variabler
            string[] copy;
            Queue<string> newQueue;
            // Bearbeta data
            copy = queue.ToArray();
            newQueue = new Queue<string>(copy);
            // Leverera resultat
            return newQueue;
        }

        public static Queue<string> StackToQueue(Stack<string> stack)
        {
            // deklarera variabler
            Queue<string> queue;
            // Bearbeta data
            queue = new Queue<string>(stack);
            // Leverera resultat
            Console.WriteLine($"Din kö ha {stack.Count} element i sig");
            return queue;
        }

        public static Queue<string> GetSchema(string[] lessons)
        {
            {
                // deklarera variabler
                Queue<string> schema;
                DateTime time = DateTime.Today.AddHours(9);
                // Bearbeta data
                schema = new Queue<string>();
                foreach (string lesson in lessons)
                {
                    schema.Enqueue(time.ToString("HH:mm") + " " + lesson);
                    time = time.AddMinutes(45);
                    schema.Enqueue(time.ToString("HH:mm") + " Fri tid");
                    time = time.AddMinutes(15);
                }
                return schema;
            }
        }
    }
}

// Generisk klass betyder att klassen kan hantera objekt av vilken tyo som helst
// Generiska klasser är en av de mest användbara funktionerna i c#

//Stack<string> namn = new(); // Funkar bara med text
//Stack<int> siffror = new(); // Funkar bara med heltal

//// Lägg till element i stacken
//namn.Push("Kalle Anka");
//namn.Push("Mimmi");
//namn.Push("Hugo");
//namn.Push("Olle");
//namn.Push("Hejhej");

//// Tar bort det översta elementet i stacken och skriver ut det - Alltså Hejhej
//Console.WriteLine(namn.Pop());

//// Skriver ut det översta elementet i stacken utan att ta bord det - Alltså Olle eftersom Hejhej tagits bort
//Console.WriteLine(namn.Peek());

//Console.WriteLine();

//foreach (var X in namn)
//{
//    Console.WriteLine(X);
//}
//Console.WriteLine(namn.Peek());