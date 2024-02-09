//Değişekenler();
using Business.Concrete;
using Entities.Concrete;

National national = new National();

static void Değişekenler()
{
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Hello, World!");
    string message = "selam";
    double price = 1000.34;
    int number = 100;
    bool durum = true;
    string name = "Nursel";
    string surname = "Düzdar";
    int birthyear = 1998;


    for (int i = 0; i < message.Length; i++)
    {
        Console.WriteLine(message);
        Console.WriteLine(price);
    }
}

SelamVer("Nursel");
SelamVer("Nursel");
SelamVer();
Console.WriteLine("Bir sayı giriniz");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bir sayı giriniz");
int num1 = Convert.ToInt32(Console.ReadLine());
int sonuc = Topla(num,num1);
static int Topla(int number,int number1)
{

    int result = number + number1;
    Console.WriteLine("Sonuc:" + result);
    return result;  

    
}

//Diziler/Array;


string student1="Engin";
string student2 = "Nursel";
string student3 = "Merve";


string[] students=new string[3] ;
students[0]=student1;
students[1]=student2;
students[2]=student3;

students = new string[4];
for (int i = 0;i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}






static void SelamVer(string name="noname")
{
    Console.WriteLine("Merhaba "+ name);
}



//Stack -----HEAP
//null referance exeption 

//REFERANS tiplerı kullanmak ıcın bellekte yer acmak gerekıyor
//referans tipler

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Kayseri", "Sivas", "Kırşehir" };
foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
sehirler1 = sehirler2;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);
//deger Tipler
int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine(sayi2);
Person person = new Person();
person.FirstName = "nURSEL";
person.LaastName = "dÜZDAR";
person.NationalIdentity =44;
person.DateOfBirthYear = 1997;

List<int> mylist = new List<int> { 1, 2, 3, 4, 5 };

// Liste içeriğini yazdırma
Console.WriteLine("Liste içeriği:");
foreach (int item in mylist)
{
    Console.WriteLine(item);
}
//Tip guvenlı yapı

List<string> newCity = new List<string> { "Ankara", "Sinop", "Şanlıurfa" };
newCity.Add("Nevşehir");
foreach (var item in newCity)
{
    Console.WriteLine(item);
}

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person);



public class National
{
    //Pascal Casing --kelimelerin ilk harfi buyuk
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Birthyear { get; set;}
    public long Tc { get; set;}
  

}
// Tamamen dolu bir liste oluşturmak için, başlangıçta içerisine değerler ekleyebilirsiniz

/*
 Deger Tipler
-int short long byte uint ushort ulong sbyte
-float double decimal
-boolen
-char
-struct-bir den fazla veri türünü tek yapı ıcınde gruplamak ıcın kullanılır
enum -numaralandırma

*struc Point{
*public int x;
*public int y;
*}
 */

/*
 Refarans tipler
class 
interface
delegate:metodları bır nesne gibi tasıyabılen  ve cagırabılen bir tudur 
delegate void MyDelegate(string messsage)
dynsinc türler

calısma zamanların da tur belirlenır

dynamic dynamicVariable="Hello";

 */