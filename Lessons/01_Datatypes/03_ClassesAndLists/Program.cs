/*  Lists
    --------------------------------------------------------------------------------
    En lista är en dynamisk lista som gör att det går att lägga till och ta bort objekt ifrån listan. 
    Det går även att sortera om den. Det finns lite olika typer av listor för olika ändamål.

    var list = new List<string>();
    List<int> list = new List<int>();
    List<string> list = new();

    List<>                      ReadWrite               Lägga till, ta bort, sortera
    IEnumerable<>               Read                    Sortera   
    ICollection<>       
    ObservableCollection<>        

    ---------------------------------------------------------------------------------

    using System.Collections.ObjectModel;

    List<string> list1 = new List<string>();
    list1.Add("1");
    list1.Add("2");
    list1.Remove("1");
    list1.OrderByDescending(x => x);
    list1.Clear();
    list1.FirstOrDefault();
    list1.LastOrDefault();

    IEnumerable<string> list2 = new List<string>();
    list2.Add("1");         //ERROR
    list2.Remove("1");      //ERROR
    list2.OrderByDescending(x => x);
    list2.Clear();          //ERROR
    list2.FirstOrDefault();
    list2.LastOrDefault();

    ICollection<string> list3 = new List<string>();
    list3.Add("1");
    list3.Add("2");
    list3.Remove("1");
    list3.OrderByDescending(x => x);
    list3.Clear();
    list3.FirstOrDefault();
    list3.LastOrDefault();
    list3.Insert(0,"1");    //ERROR

    ObservableCollection<string> list4 = new();
*/


/*  Klasser
    -----------------------------------------------------------------------------------
    Klasser är en del av objektorienterad programmering.
    En klass är alltså ett objekt och en klass kan innehålla flera olika saker.
    Se en klass som en mall över hur något ser ut eller hur något är.

    En bil, ett djur, en sko, en användare, en kund, en order, en dator,
    en byggnad, en .... Ja det kan vara vad som helst i systemet.
    





*/

using _03_ClassesAndLists.Models;

var contactPersons = new List<ContactPerson>();
var answer = "n";


do
{
    Console.Clear();

    var contactPerson = new ContactPerson();
    Console.Write("First name: ");
    contactPerson.FirstName = Console.ReadLine() ?? "";

    Console.Write("Last name: ");
    contactPerson.LastName = Console.ReadLine() ?? "";

    Console.Write("Email: ");
    contactPerson.Email = Console.ReadLine() ?? "";

    Console.Write("Phone number: ");
    contactPerson.PhoneNumber = Console.ReadLine() ?? "";

    contactPersons.Add(contactPerson);

    Console.Write("Vill du kägga till en till person y/n: ")
    answer = Console.ReadLine();



} while (answer.ToLower() == "y");