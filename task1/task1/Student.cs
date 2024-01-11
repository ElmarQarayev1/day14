using System;
using System.Drawing;

namespace task1
{
	public class Student
	{

		//Fullname, BirthDate, GroupNo, Point xüsusiyyətlərinə və ShowInfo metoduna sahib Student class yaradırsınız. FullName və Point dəyəri təyin olunmamış student obyekti yaradıla bilməz.
		//Proqram açıldıqda bizdən tələbə yaratmaq üçün datalar daxil etməyimizi istyir, daxil edib tələbə obyektini yaradırıq və Shoüİnfo metodu ilə içindəki məlumatlara baxırıq

		
        public Student(string FullName,int Point)
		{
			this.Fullname = FullName;
			this.Point = Point;

		}
		public Student(string FullName,DateTime dateTime,string groupName,int point):this(FullName,point)
		{
			
			this.BirthDate = dateTime;
			this.GroupNo = groupName;
			
		}

		public string Fullname;
		public DateTime BirthDate;
		public string GroupNo;
		public int Point;

		public void ShowInfo()
		{
			Console.WriteLine($"{this.Fullname}-{this.BirthDate.ToString("dd.MM.yyy")}-{this.GroupNo}-{this.Point}");
		}


	}
}

