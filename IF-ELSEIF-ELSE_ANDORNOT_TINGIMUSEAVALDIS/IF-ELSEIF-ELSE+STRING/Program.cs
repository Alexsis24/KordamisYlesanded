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



        }
    }
}
