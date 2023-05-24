using System;

namespace phoneBook
{
    public class AllActions
    {
        List<Persons> personList =new List<Persons>();
        public AllActions()
        {
            personList.Add(new Persons("aşkın", "bolat", "549612"));
            personList.Add(new Persons("enver", "bolat", "419982"));
            personList.Add(new Persons("yadigar", "bolat", "121793"));
            personList.Add(new Persons("hasret", "bolat", "399941"));
            personList.Add(new Persons("puruşa", "bolat", "471666"));   
        }

        
        public void AddPerson()
        {
            Console.WriteLine("Lütfen isim giriniz             : ");
            string Name = Console.ReadLine().ToLower();
            Console.WriteLine("Lütfen soyisim giriniz             : ");
            string Surname = Console.ReadLine().ToLower();
            Console.WriteLine("Lütfen numara giriniz             : ");
            string Number = Console.ReadLine().ToLower();
            
            personList.Add(new Persons(Name,Surname,Number));
            Console.WriteLine(Name+" adlı kişi rehbere başarıyla kaydedildi."); 

        }


        public void DeletePerson()
        {   
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string deleteNameorSurname = Console.ReadLine();
            deleteNameorSurname =deleteNameorSurname.ToLower();

            foreach (var item in personList)
            {   
                
                if (item.name.Equals(deleteNameorSurname)||item.surname.Equals(deleteNameorSurname))
                {
                    Console.WriteLine(item.name +" silinecektir. Onaylıyorsanız (1) onaylamıyorsanız (0) seçiniz.");
                    int choose = Convert.ToInt32(Console.ReadLine());

                    if (choose==1)
                    {
                        personList.Remove(item);
                        Console.WriteLine(item.name+" kişisi başarıyla silindi.");
                        break;
                    }
                    else if (choose==0)
                    {
                        Console.WriteLine("Silme işlemi sonlandırıldı.");
                        break;
                    }
                    break;      
                }
                
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");

                    int noFoundForDelete = Convert.ToInt32(Console.ReadLine());
                        
                    if (noFoundForDelete==1)
                    {
                        break;
                    }
                        
                    else if(noFoundForDelete==2)
                    {
                        DeletePerson();
                    }
                        
                    else
                    {
                        Console.WriteLine("Yanlış bir tuş seçtiniz.");
                        break;
                    }
                        
                }
            }
            
        }

        public void UptadePerson()
        {   
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string updatePerson = Console.ReadLine();
            
            foreach (var item in personList)
            {
                if (item.name.Equals(updatePerson)||item.surname.Equals(updatePerson))
                {
                    Console.Write("Yeni numarayı giriniz:");
                    string updateNumber = Console.ReadLine();

                    item.number =updateNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                    Console.WriteLine("* Yeniden denemek için              : (2)");
                    
                    int updateChoose = Convert.ToInt32(Console.ReadLine());
                    
                    if (updateChoose==1)
                    {
                        break;
                    }
                    else if (updateChoose==2)
                    {
                        UptadePerson();
                    }

                }
            }
        }
        
        public void ListPhoneBook()
        {   
            Console.WriteLine("Telefon Rehberi");
            
            foreach (var item in personList)
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("İsim: {0}",item.name);
                Console.WriteLine("Soyisim: {0}",item.surname);
                Console.WriteLine("Telefon Numarası: {0}",item.number);
            }
        }

        public void SearchInPhoneBook()
        {   
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1) Telefon numarasına göre arama yapmak için: (2)");

            int searhingChoose = Convert.ToInt32(Console.ReadLine());

            if (searhingChoose==1)
            {
                Console.Write("Lütfen isim veya soyisim giriniz:");
                string searchingNameOrSurname= Console.ReadLine();
                foreach (var item in personList)
                {
                    if (item.name.Equals(searchingNameOrSurname) || item.surname.Equals(searchingNameOrSurname))
                    {
                        Console.WriteLine("Arama sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("İsim: {0}",item.name,"soyisim: {0}",item.surname,"Telefon Numarası: {0},",item.number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Girmiş olduğunuz isim veya soyisim rehberde bulunamadı.");
                        break;
                    }
                         
                }
            }
            else if (searhingChoose==2)
            {
                Console.WriteLine("Numara giriniz:");
                string searchingNumber = Console.ReadLine();
                foreach (var item in personList)
                {
                    if (item.surname.Equals(searchingNumber))
                    {
                        Console.WriteLine("Arama sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine($"İsim: {0}",item.name,"soyisim: {0}",item.surname,"Telefon Numarası: {0},",item.number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Girmiş olduğnuz numara rehberde bulunamadı.");
                        break;
                    }

                }
            }

        }
    }
}