/*#8
//string word = "vlad skushal zan";
int counter = 0;

for (int i = 0; i < word.Length; i += 2)
{
    if (word[i] == 'z')
    {
        counter++;
    }
}

Console.WriteLine("count bukva 'z' in even places it is equal to: " + counter);*/



/*#9
string word = "vlad best acount seller?";
string updword = word.Replace('a', 'A');
Console.WriteLine(updword) ;

#10
/*string word = "vlad";
int counter0 = 0; 
int counter1 = 0;

for (int i = 0;i < word.Length; i++)
{
    if (word[0] == word[i]) 
    {  
        counter0++; 
    }
    if (word[word.Length-1] == word[i]) 
    { 
        counter1++;
    }

}
if (counter0 > counter1)
{
    Console.WriteLine("1 word chase:" + counter0 + " count");
}
else if (counter1 > counter0) {
    Console.WriteLine("Last word chase:" + counter1 + " count");
}
else
{
    Console.WriteLine("wrong, the same ");
        }*
*/