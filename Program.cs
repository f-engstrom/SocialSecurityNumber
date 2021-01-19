using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace SocialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter social security number: ");
            Ssn socialSecurityNumber = new Ssn(Console.ReadLine());
            Console.WriteLine(socialSecurityNumber.Age + socialSecurityNumber.Sex);
            Console.ReadKey();



            //if (args.Length == 0)
            //{
           // personummerBehandlare.Menu();
            //}
            //else if (args.Length > 0)
            //{
            //    personummerBehandlare.PersonNummerIn = args[0];
            //    bool korrektDetPersonummer = personummerBehandlare.ÄrDetPersonummer();

            //    if (korrektDetPersonummer)
            //    {
            //        personummerBehandlare.man_eller_kvinna();
            //        personummerBehandlare.personummer_ålder();
            //        Console.WriteLine(personummerBehandlare.Kön + ", " + personummerBehandlare.Ålder);
            //    }


            //}


        }
    }


    public class PersonummerBehandling
    {
        private int valNr;
        private int arrayPos;

         Ssn socialSecurityNumber;



        public void Menu()
        {
            do
            {
                valNr = 0;
                Console.Clear();
                Console.WriteLine("1 Lagra personummer.");
                Console.WriteLine("2 Sortera personummer.");
                Console.WriteLine("3 Skriv ut lagrade personummer.");
                Console.WriteLine("4 Beräkna kön och ålder för personummer.");
                Console.WriteLine("5 Beräkna kön och ålder för alla personummer.");
                Console.WriteLine("6 Avsluta progammet.\n");


                ConsoleKeyInfo UserInput = Console.ReadKey();

                if (char.IsDigit(UserInput.KeyChar))
                {
                    valNr = int.Parse(UserInput.KeyChar.ToString());

                }
                else
                {
                    valNr = -1;
                }

                switch (valNr)
                {
                    case 1:
                        Console.Clear();
                        StoreSsn();
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        Console.Clear();
                        //PrintStoredSsn();
                        
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        //skriv_ut__alla_personummer();
                        //Console.Write("Välj personummer: ");
                        //int personummerVal = Convert.ToInt32(Console.ReadLine());
                        //personummerVal--;
                        //personNummerIn = storePersonummerIn[personummerVal];
                        //if (personNummerIn == null)
                        //{
                        //    Console.WriteLine("Minnesplatsen är tom.");
                        //}
                        //else
                        //{
                        //    man_eller_kvinna();
                        //    personummer_ålder();
                        //    Console.Clear();
                        //    Console.WriteLine("{0},{1}", kön, ålder);
                        //    Console.ReadKey();
                        //}

                        //Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        //int personummerPos = 0;

                        //foreach (var personummer in storePersonummerIn)
                        //{
                        //    personNummerIn = storePersonummerIn[personummerPos];
                        //    if (personNummerIn == null)
                        //    {
                        //        Console.WriteLine("Inget personummer Lagrat.");
                        //        personummerPos++;
                        //    }
                        //    else
                        //    {
                        //        man_eller_kvinna();
                        //        personummer_ålder();
                        //        Console.WriteLine("{0},{1} ({2})", kön, ålder, personummer);
                        //        personummerPos++;
                        //    }

                        //}

                        Console.ReadKey();
                        break;

                    case 6:
                        break;



                }


            } while (valNr != 6);

        }

        public void StoreSsn()
        {

            //if (arrayPos < socialSecurityNumber.Length)
            //{
            Console.Write("Ange personummer (YYMMDD-XXXX): ");


           socialSecurityNumber.Sex = null;
           socialSecurityNumber.Age = 0;

            Console.ReadKey();
            //    arrayPos++;
            //    }

            //    Console.ReadKey();

            //}
            //else
            //{
            //    Console.WriteLine("Minnet är fullt!");
            //    Console.ReadKey();
            //}

        }


        public void PrintStoredSsn()
        {
          
            //int position = 1;

            //foreach (var personummer in socialSecurityNumber)
            //{
            //    Console.WriteLine(position + ": " + personummer);
            //    position++;
            //}
        }

        public void PrintSexAge()
        {

            Console.WriteLine();
        }


    }

    struct Ssn
    {
        public string Sex { get; internal set; }
        public int Age { get; internal set; }
        private string SsnIn;
        public override string ToString()
        {
            return SsnIn;
        }

        public Ssn(string ssn)
        {
            Sex = null;
            Age = 0;
            SsnIn = null;
            CheckCorrectSsn(ssn);
            SsnIn = ssn;
            CalculateAge();
            ManOrWoman();

        }

        
        public void PrintAgeSex()
        {
            Console.WriteLine($"{Sex}, {Age}");

        }

        public void CheckCorrectSsn(string ssn)
        {
            //bool KorrektPersonummer = false;
            //bool rättSistaSiffror = false;
            //bool rättTecken = false;
            //bool rättDatum = false;
            


            if (string.IsNullOrEmpty(ssn))
            {
                Console.WriteLine("Ange personummer.");
                Console.ReadKey();
            }
            else
            {

                try
                {
                    string tempDatum = ssn.Substring(0, 6);
                    DateTime testSsn =
                        DateTime.ParseExact(tempDatum, "yyMMdd", CultureInfo.InvariantCulture);
                    //rättDatum = true;

                }
                catch
                {
                    Console.WriteLine("Inkorrekt datum.");
                    throw;
                }


                try
                {
                    string testSsnLastFourDigits = ssn.Substring(7, 4);
                    Convert.ToInt32(testSsnLastFourDigits);
                    //rättSistaSiffror = true;

                }

                catch
                {
                    Console.WriteLine("Personummret måste sluta på siffror.");
                    throw;
                }

                int containsCorrectCharMinus = ssn.IndexOf('-', 6,1);
                int containsCorrectCharPlus = ssn.IndexOf('+', 6, 1);

                if (containsCorrectCharPlus != -1 || containsCorrectCharMinus != -1)
                {
                  

                }
                else
                {
                    Console.WriteLine("Fel bindetecken.");
                }



                //if (ssn[6] == '-')
                //{
                //    rättTecken = true;
                //}
                //else if (ssn[6] == '+')
                //{
                //    rättTecken = true;
                //}
                //else
                //{
                //    Console.WriteLine("Ej godkänt bindetecken.");
                //}

                //if (rättDatum && rättTecken && rättSistaSiffror)
                //{
                //    KorrektPersonummer = true;
                //}

            }
        }

        public void CalculateAge()
        {
            var idag = DateTime.Today;
            string strPersonummerÅrMånDag = SsnIn.Substring(0, 6);
            DateTime personummerÅrMånDag =
                DateTime.ParseExact(strPersonummerÅrMånDag, "yyMMdd", CultureInfo.InvariantCulture);

        Age = idag.Year - personummerÅrMånDag.Year;

            if (personummerÅrMånDag.Date > idag.AddYears(-Age))
            {
                Age--;
            }


            if (SsnIn[6] == '+')
            {

                Age = Age + 100;
            }

        }

        public void ManOrWoman()
        {
            if (SsnIn[9] % 2 == 0)
            {
                Sex = "Woman";
            }
            else
            {
                Sex = "Man";
            }

        }
    }
}

