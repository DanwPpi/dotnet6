// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System.Xml;

Console.WriteLine("Hello, World!");

// Create a pattern for a word that starts with letter "M"  
string pattern = @"\b[M]\w+";  
// Create a Regex  
Regex rg = new Regex(pattern);  
  
// Long string  
string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";  
// Get all matches  
MatchCollection matchedAuthors = rg.Matches(authors);  
// Print all matched authors  
for (int count = 0; count < matchedAuthors.Count; count++)  
    Console.WriteLine(matchedAuthors[count].Value);  

var type = typeof(Regex);
var assm = type.Assembly;
Console.WriteLine("FullName=" + assm.FullName);
Console.WriteLine("Location=" + assm.Location);