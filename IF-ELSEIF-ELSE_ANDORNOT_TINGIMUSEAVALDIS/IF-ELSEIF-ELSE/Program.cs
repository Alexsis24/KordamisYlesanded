namespace IF_ELSEIF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*1. kasutajapikkus*/
            //Küsi kasutajalt tema pikkust
            Console.WriteLine("Sisestage oma pikkus sentimeetrites:");
            int kasutajaPikkus = Convert.ToInt32(Console.ReadLine());
            
            //kui ta on lühem kui 0cm, ütle võimatu pikkus
            if(kasutajaPikkus < 0)
            {
                Console.WriteLine("Võimatu pikkus.");
            }
            //kui ta on lühem kui 1m, ütle juntsu
            else if (kasutajaPikkus < 100)
            {
                Console.WriteLine("Oled juntsu!");
            }
            //kui ta on lühem kui 2m, ütle tavaline kolge
            else if (kasutajaPikkus < 200)
            {
                Console.WriteLine("Oled tavaline kolge!");
            }
            //kui ta on pikem kui 2m, ütle hiiglane
            else
            {
               Console.WriteLine("Oled hiiglane!");
            }
        
        
            /*2. sõnum noorukile*/
            //küsi kasutajalt kui vana ta on
            Console.WriteLine("Sisestage oma vanus:");
            int kasutajaVanus = int.Parse(Console.ReadLine());
            
            //küsi kasutajalt praegust aastaarvu
            Console.WriteLine("Sisestage praegune aasta:");
            int praeguneAasta = int.Parse(Console.ReadLine());
            
            //lahuta aastast kasutaja vanus
            int synniAasta = praeguneAasta - kasutajaVanus;
            
            //kui kasutaja on sündinud 2026-2020, ütle talle, kes sulle arvuti juba andis
            if (synniAasta >= 2020 && synniAasta <= 2026)
            {
                Console.WriteLine("Kes sulle arvuti juba andis?");
            }
            //kui kasutaja on sündinud 2020-2015, ütle talle, skibidi sigmaless
            else if (synniAasta >= 2015 && synniAasta <= 2020)
            {
                Console.WriteLine("Skibidi sigmaless. 67");
                
            }
            //kui kasutaja on sündinud 2015-2010, küsi talt kas ta tahab saada programmeerijaks
            //    kui jah, ütle tubli
            //    kui ei, ütle kahju
            else if (synniAasta >= 2010 && synniAasta <= 2015)
            {
                
                Console.WriteLine("Kas tahad saada programmeerijaks? (jah/ei)");
                string tulevaneProgrameerija = Console.ReadLine();
                
                if (tulevaneProgrameerija == "jah" )
                {
                    Console.WriteLine("Tubli!");
                }
                else if (tulevaneProgrameerija == "ei" )
                {
                    Console.WriteLine("Kahju.");
                }
                else
                {
                    Console.WriteLine("Sa ei oska vist jah või ei kirjutada...");
                
                }
                return;
            }
            
            //kui kasutaja on sündinud enne 2010, küsi mitu rage comicsit ta täna oma redditi lugemise ajal leidis 
            else if (synniAasta < 2010)
            {
                Console.WriteLine("Mitu rage comicsit täna redditist leidnud oled?");
            }
            //enda lisa
            else
            {
                Console.WriteLine("Tervitusi minevikust!");
            }
        
        
            /*3. suunakoodituvasti*/
            //küsi kasutajalt tema elukoha suunakoodi
            int suunaKood = 0;
            Console.WriteLine("Sisesta oma elukoha suunakood:");
            suunaKood = int.Parse(Console.ReadLine());
            
            //kui suunakood on väiksem kui number 5, ütle talle, 1 number on puudu
            if (suunaKood < 10000 )
            {
                Console.WriteLine("Sisestasid liiga vähe numbreid. Suunakood peab olema 5 numbrit pikk!");
            }
            
            //kui suunakood on suurem kui number 5, ütle talle, 1 number on üle
            else if (suunaKood > 99999 )
            {
                Console.WriteLine("Sisestasid liiga palju numbreid. Suunakood peab olema 5 numbrit pikk!");
            }
            
            //kui suunakoodis on 5 tähte, ütle "ahha nüüd tean kus elad"
            else if (suunaKood > 9999 && suunaKood < 100000)
            {
                Console.WriteLine("Ahha nüüd tean kus sa elad!");
            }
            
            
            /*4. töökoht*/
            //küsi kasutajalt kas ta töötab
            Console.WriteLine("Kas sul on töökoht olemas? (jah/ei/otsin)");
            string tootaja = Console.ReadLine();
            //kui kasutaja vastab jah, siis ütle tubli
            if (tootaja == "jah")
            {
                Console.WriteLine("Oled tubli!");
            }
            
            //kui kasutaja vastab ei, siis ütle, kahju, miks sa siis töökohta ei otsi?
            else if (tootaja == "ei")
            {
                Console.WriteLine("Kahju. Miks sa siis töökohta ei otsi?");
            }
            //kui kasutaja vastab otsin, siis ütle, loodan et saad varsti tööle c:
            else if (tootaja == "otsin")
            {
                Console.WriteLine("Loodan et saad varsti tööle! c:");
            }
            //lisasin ise
            else
            {
                 Console.WriteLine("Palun loe, mis valikuid sulle anti järgmine kord.");
            }
            

            /*5. 2FA autentija */
            //küsi kasutajalt tema parooli
            string parool1 = "69420";
            Console.WriteLine("Sisestage oma parool:");
            string sisestatudParool = Console.ReadLine();
            
            //kui parool on õige, kontrolli 2FA koodi:
            if (sisestatudParool == parool1)
            {
                Console.WriteLine("Sisestage 2FA kood:");
                int twoFA = int.Parse(Console.ReadLine());
                
                //kui 2FA kood on lühem kui 6 tähte, ütle sissepääs keelatud, kood on liiga lühike
                if (twoFA < 100000)
                {
                    Console.WriteLine("Sissepääs keelatud, kood on liiga lühike.");
                    return;
                }
                
                //kui 2FA kood on pikem kui 6 tähte, ütle sissepääs keelatud, kood on liiga pikk
                else if (twoFA > 999999)
                {
                    Console.WriteLine("Sissepääs keelatud, kood on liiga pikk.");
                    return;
                }
                
                //kui 2FA kood on 6 tähte, siis lase sisse, öeldes "oled sissepääsenud"
                else
                {
                    Console.WriteLine("Oled sissepääsenud.");
                }
                
            }
            //kui parool on vale, ütle sissepääs keelatud
            else
            {
                Console.WriteLine("Parool vale. Sissepääs keelatud");
            }
            //NB: 2FA kood ei pea matchima eksisteeriva näitega nagu parool.
        }
    }
}
