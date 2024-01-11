using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Xml.Linq;
namespace task1
{
    public class Product
    {
        // Name və Price dəyərləri olan Product classı yaradırsınız.Name dəyəri daxil edilmədən product yaradıla bilməz, Price isə default 10 olur.Proqram işə düşdükdə bizdən neçə ədəd product yaradacağımızı soruşur
        //  və daha sonra o sayda product dataları yaradırıq.Bunları bir array içərisində saxlayırsınız və daxil etdiyimiz sayda product datalarını daxil etdikdən sonra o product arrayındəki bütün productların qiymətlərini ortalaması, ən bahalı productın adı və ən ucuz productın adı console-da göstərilir

        public Product(string name)
        {
            this.Price =10;
            this.Name = name;         
        }        
        public Product(string name, double price) : this(name)
        {
            this.Price = price;
        }
        public string Name;
        public double Price;

    }
}

