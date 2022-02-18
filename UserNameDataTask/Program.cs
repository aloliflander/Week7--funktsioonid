using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada nimbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust;

            Console.WriteLine("Sisesta eesnimi");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number '1', '2' või '3':");
            char userChoice = Convert.ToChar(Console.ReadLine());
            switch(userChoice)
            {
                case '1':
                    userNameOne(userName);
                    break;
                case '2':
                    userNameTwo(userName);
                    break;
                case '3':
                    userNameThree(userName);
                    break;
            }


        }
        public static void userNameOne(string Userinput)
        {
            for (int i = Userinput.Length - 1; i >= 0; i--)
            {
                Console.Write(Userinput[i]);
            }
        }
        public static void userNameTwo(string Userinput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {Userinput[0]}.");
        }
        public static void userNameThree(string Userinput)
        {
            Console.WriteLine($"Sinu eesnimes on {Userinput.Length} sümbolit.");
        }
    }
}
