using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class User
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber  { get; set; }

         public User()
        {

        }
         public void Start()
        { 
            Console.Clear();
            Console.WriteLine("Choose the option");
            Console.WriteLine("1.Sign In       2.Login in      3.Delete");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1: SignIn(); break;
                case 2: LoginIn (); break;
                case 3: Delete(); break;
             }
            
        }
         public void SignIn()
        {
            Console.Clear();
            
            Console.Write("Enter your FullName - ");
            string FullName = Console.ReadLine();
            Console.Write("Enter your UserName - ");
            string UserName = Console.ReadLine();
            Console.Write("Enter your PhoneNumber - +998");
            int PhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your Password - ");
            string Password = Console.ReadLine();
            Console.WriteLine("User's information is successfully registered");

            string path = $@"D:\hello c#\new folder\folders\{UserName + Password}.txt";
            File.Create(path).Close();

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("FullName : " + FullName);
                sw.WriteLine("UserName : " + UserName);
                sw.WriteLine("PhoneNumber : " + PhoneNumber);
                sw.WriteLine("Password : " + Password);
            }
            Start();
        }
        public void LoginIn()
        {
            Console.Clear();
            Console.WriteLine("Enter your Username - ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter your Password - ");
            string Password = Console.ReadLine();

            string FileName = UserName + Password; 
            string path = $@"D:\hello c#\new folder\folders\{FileName}.txt";
            if (File.Exists(path))
            {
                string texts = File.ReadAllText(path);
                Console.WriteLine(texts);
            }
            else
                File.Create(path).Close();
            Start();
        }
        public void Delete()
        {
            Console.Clear();
            Console.WriteLine("Enter your Username - ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter your Password - ");
            string Password = Console.ReadLine();

            string FileName = UserName + Password;
            string path = $@"D:\hello c#\new folder\folders\{FileName}.txt";
            if (File.Exists(path))
            {
                string texts = File.ReadAllText(path);
                Console.WriteLine(texts);
            }
            else
                File.Create(path).Close();
            Console.WriteLine("             Do you Delete another Profile\n[1] - yes\n[2] - no");
             int opp = int.Parse(Console.ReadLine());
            switch(opp)
            {
                case 1: File.Delete(path); break;
                case 2: Start(); break;
            }
            Start();
            
        }
        


    }
}
