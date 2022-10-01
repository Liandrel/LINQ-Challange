Console.Write("Write word to process: ");

string word = Console.ReadLine();

var wordlist = from letter in word.ToCharArray()
               orderby letter.ToString().ToLower() ascending
               select letter;

wordlist.ToList().ForEach(x => Console.Write(x));
