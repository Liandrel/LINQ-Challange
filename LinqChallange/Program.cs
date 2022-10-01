Console.Write("Write word to process: ");

string word = Console.ReadLine();

//var letterList = from x in word
//               orderby x.ToString() ascending
//               select x;

//letterList.ToList().ForEach(x => Console.Write(x));

var letterListAdv = from x in word
                    group x by x.ToString().ToLower() into y
                    orderby y.Count() descending, y.Key.ToString()
                    select (new { Letter = y.Key, Count = y.Count() });

foreach(var letter in letterListAdv)
{
    Console.WriteLine($"Letter: {letter.Letter}, Count: {letter.Count}");
}
