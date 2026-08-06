namespace IF_ELSEIF_ELSE_STRING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. - "lemmiklipp" 
            //kasutades stringi tööriistu ja metoodikaid
            //kirjuta programm mis
            //töötle sisestust enne võrdlust, eemalda tühikud, kui on kaks sõna, ühenda nad üheks kokku.
            //eesti lipu puhul ütle "suitsupääsuke on su üle uhke"
            //vene lipu puhul "pokri lähed"
            //soome lipu puhul "soomes olid rahad, enam ei ole"
            //programmeerija lemmiklipu puhul programmeerija sõnum
            //tühja sisestuse puhul et midagi pidi sisestama
            //malelipu puhul ütle et "BUT WHY THO"
            //muu lipu puhul ütle et "ei tunne sellist riiki kahjuks :c"*/

            
            string eestiLipp = "Kalevi poeg on uhke sinu üle!";
            string veneLipp = "Tervita babuskat!";
            string soomeLipp = "Ohh Soomelainen";
            string progLipp = "See on parim lipp, mis kunagi olemas on olnud!";
            string maleLipp = "Sohki tegid!";
            string tundmatuLipp = "Ei viitsinud lisada sellist lippu. Sorry!";

            //küsib kasutajalt tema lemmikut riigilippu
            Console.WriteLine("Mis on sinu lemmik riigilipp?");
            string lemmikLippSisestus = Console.ReadLine().ToLower().Trim(); // muudab väikesteks tähtedeks
            string lemmikLipp = string.Concat(lemmikLippSisestus.Where(c => !Char.IsWhiteSpace(c))); // eemaldab tühikud ja ongi valmis võrdlusteks

            Console.WriteLine(lemmikLipp); // testiks lisasin et näha tulemust pärast töötlemist

            if (lemmikLipp == "eestilipp")
            {
                Console.WriteLine(eestiLipp);
            }
            else if (lemmikLipp == "venelipp")
            {
                Console.WriteLine(veneLipp);
            }
            else if (lemmikLipp == "soomelipp")
            {
                Console.WriteLine(soomeLipp);
            }
            else if (lemmikLipp == "waleslipp")
            {
                Console.WriteLine(progLipp);
            }
            else if (lemmikLipp == "malelipp")
            {
                Console.WriteLine(maleLipp);
            }
            else if (lemmikLipp == "")
            {
                Console.WriteLine("Oled ikka laisk. Sa pead midagi ikka sisestama!");
            }
            else
            {
                Console.WriteLine(tundmatuLipp);
            }


            /* 2. - "Panga kasutajatuvastus" 
            //kasutades stringi tööriistu ja metoodikaid
            //kirjuta programm mis
            //küsib kasutajalt tema eesnime, mille programm töötleb esisuurtäheliseks ja puhastab ära
            //küsib kasutajalt tema perekonnanime, mille programm töötleb esisuurtäheliseks ja puhastab ära
            //kontrollib kas eesnimi on sisestatud
            // kui jah, programm jätkub:
            // kontrollib kas perekonnanimi on sisestatud
            //  kui jah programm jätkub:
            //   konkateneerib ühes muutujas olevaks andmeks mõlemad nimed, perekonnanimi esimeseks, eesnimi teiseks ja eraldab koma ja tühikuga.
            //   küsib kasutajalt parooli mis peab olema vähemalt 8 tähe-numbriga, ja sisaldama ühte järgnevaist märkidest: ,.-_:;!?+
            //    kui parool ei sisalda neid märke, ütle kasutajale et paroolist on puudu kirjavahemärk, ning programm lõppeb
            //    kui parool sisalda kirjavahemärke, ütle kasutajale "tere tulemast {konkateneeritudnimi}, olete registreerunud."
            //  kui ei, programm lõppeb
            // kui ei, programm lõppeb*/

            //errori vastus
            string errorNimi = "Sisestatud nimi ei saa olla tühi.";
            string errorPW = "Sisestatud parool ei sobi. Paroolis on vaja vähemalt ";

            //eesnime küsimine
            Console.WriteLine("Sisetage eesnimi:");
            string sisEesnimi = Console.ReadLine().Trim(); // sisestatud lühendus sis
            string eesNimi = toCapEes(sisEesnimi);
            if (sisEesnimi == "")
            {
                Console.WriteLine(errorNimi);
            }
            

            //perekonnanime küsimine
            Console.WriteLine("Sisetage perekonnanimi:");
            string sisPerenimi = Console.ReadLine().Trim();
            string pereNimi = toCapPere(sisPerenimi);
            if (sisPerenimi == "")
            {
                Console.WriteLine(errorNimi);
            }

            // küsib parooli
            Console.WriteLine("Sisestage parool:");
            string pw = Console.ReadLine();

            // kontrollib pikkust, vähemalt 8 tähte

            if (pw.Length >= 8)
            {
                // otsib neid märke: ,.-_:;!?+
                if (pw.Contains(",") 
                    || pw.Contains(".") 
                    || pw.Contains("-") 
                    || pw.Contains("_")
                    || pw.Contains(":")
                    || pw.Contains(";")
                    || pw.Contains("!")
                    || pw.Contains("?")
                    || pw.Contains("+"))
                {                    
                   //kõik kontrollid läbitud ja tervitus
                    string terveNimi = TerveNimi(eesNimi, pereNimi);
                    Console.WriteLine("Tere tulemast " + terveNimi + " olete sisse logitud");
                }
                else
                {
                    Console.WriteLine(errorPW + "ühte erilist märki nagu ,.-_:;!?+");
                    return;
                }
            }
            else
            {
                Console.WriteLine(errorPW + "8 tähte.");
                return;
            }              

                
        }

        //programm mis muudab esimesed tähed nimedes suure täheks
        //kahjuks ei tööta mitme nimega kuna see liiga keeruline praegu
        public static string toCapEes(string sisEesnimi)
        {
            //a1 on esimese tähe otsijaks ja a2 on ülejäänud tähed nimest
            string a1;
            string a2;

            // otsib nimes esimese tähe ja muudab selle suureks
            a1 = sisEesnimi.Substring(0, 1).ToUpper();

            // muudab kõik peale esimese tähe väikseks
            a2 = sisEesnimi.Substring(1).ToLower();

            //paneb erineva suurusega tähed kokku
            return a1+a2;
        }

        public static string toCapPere(string sisPerenimi)
        {
            //b1 on esimese tähe otsijaks ja b2 on ülejäänud tähed nimest
            string b1;
            string b2;

            // esimene täht peab suur olema.
            b1 = sisPerenimi.Substring(0, 1).ToUpper();

            // teiste tähtede väikeseks tegemine
            b2 = sisPerenimi.Substring(1).ToLower();

            //paneb erineva suurusega tähed kokku
            return b1 + b2;
        }

        public static string TerveNimi(string eesNimi, string pereNimi)
        {
            string terveNimi = pereNimi + ", " + eesNimi;
            return terveNimi;
        }



    }
}
