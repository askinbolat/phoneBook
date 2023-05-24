using System;

namespace phoneBook

{
    internal class Program
    {
        static void Main(string[] args)
        {   
           
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int choose = Convert.ToInt32(Console.ReadLine());
            AllActions newAction =new AllActions();
            switch (choose)
            {
               case 1:
                    newAction.AddPerson();
                    break;
                case 2:
                    newAction.DeletePerson();
                    break;
                case 3:
                    newAction.UptadePerson();
                    break;
                case 4:
                    newAction.ListPhoneBook();
                    break;
                case 5:
                    newAction.SearchInPhoneBook();
                    break;
                default:
                    Console.WriteLine("Yanlış bir tuş seçtiniz.");
                    break;
                
            }
        }
    }
}