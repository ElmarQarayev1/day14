using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace task1;

class Program
{
    static void Main(string[] args)
    {
        //Fullname, BirthDate, GroupNo, Point xüsusiyyətlərinə və ShowInfo metoduna sahib Student class yaradırsınız. FullName və Point dəyəri təyin olunmamış student obyekti yaradıla bilməz.
        //Proqram açıldıqda bizdən tələbə yaratmaq üçün datalar daxil etməyimizi istyir, daxil edib tələbə obyektini yaradırıq və Shoüİnfo metodu ilə içindəki məlumatlara baxırıq
        string fullname;
        do
        {
            Console.WriteLine("telebe adini ve soyadini daxil edin:");
            fullname = Console.ReadLine();
        } while (String.IsNullOrWhiteSpace(fullname));

        string Strbirth;
        DateTime birth;
        do
        {
            Console.WriteLine("telebenin ad gununu daxil edin:");
            Strbirth = Console.ReadLine();

        } while (!DateTime.TryParse(Strbirth, out birth));

        string groupNo;
        do
        {
            Console.WriteLine("telebenin groub nomresini daxil edin:");
            groupNo = Console.ReadLine();

        } while (String.IsNullOrWhiteSpace(groupNo));


        string StrPoint;
        int point;
        do
        {
            Console.WriteLine("telebenin pointini daxil edin:");
            StrPoint = Console.ReadLine();

        } while (!int.TryParse(StrPoint, out point));
        Student student = new Student(fullname, birth, groupNo, point);

        student.ShowInfo();

        //  Name və Price dəyərləri olan Product classı yaradırsınız. Name dəyəri daxil edilmədən product yaradıla bilməz, Price isə default 10 olur.Proqram işə düşdükdə bizdən neçə ədəd product yaradacağımızı soruşur və daha sonra o sayda product dataları yaradırıq.
        //  Bunları bir array içərisində saxlayırsınız və daxil etdiyimiz sayda product datalarını daxil etdikdən sonra o product arrayındəki bütün productların qiymətlərini ortalaması, ən bahalı productın adı və ən ucuz productın adı console-da göstərilir
        string Strsay;
        int say;
        do
        {
            Console.WriteLine("nece eded product datasi yaradacaqsinizsa sayini daxil edin:");
             Strsay = Console.ReadLine();
        } while (!int.TryParse(Strsay,out say));
       
        Product[] products = new Product[say];
        string name;
        string Strprize;
        double prize;
        for (int i = 0; i < products.Length; i++)
        {

            do
            {
                Console.WriteLine($"{i + 1} ci productun adini daxil edin:");
                name = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(name));
            products[i] = new Product(name);


            Console.WriteLine($"{i + 1} ci productun qiymetini daxil edin:");
            Strprize = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Strprize))
            {
                products[i] = new Product(name);

            }
            else
            {
                if (double.TryParse(Strprize, out prize))
                {
                    products[i] = new Product(name, prize);
                }
                else
                {

                    do
                    {
                        Console.Write($"{i + 1} ci productun qiymətini daxil edin: ");
                        Strprize = Console.ReadLine();
                    } while (!double.TryParse(Strprize, out prize));

                    products[i] = new Product(name, prize);

                }
            }

        }

        for (int i = 0; i < products.Length; i++)
        {

            Console.WriteLine($"{products[i].Name}-{products[i].Price}");
        }
        double ort = 0;

        int max = 0;
        int min = 0;

        for (int i = 0; i < products.Length; i++)
        {
            if (products[max].Price < products[i].Price)
            {
                max = i;
            }
            if (min > products[i].Price)
            {
                min = i;
            }

            ort += products[i].Price;


        }

        Console.WriteLine($"productlarin qiymetlerini ortalamasi: {(ort / products.Length).ToString("#.##")}");
        Console.WriteLine($"en pahali product: {products[max].Name}");
        Console.WriteLine($"en ucuz product: {products[min].Name}");


        Console.ReadLine();
    }
}

