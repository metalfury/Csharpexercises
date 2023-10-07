
internal class Program
{
    static void Main(string[] args)
    {
        // aritmetik operatorler

        /*int sayi1 = 20;
        int sayi2 = 4;

        decimal toplam = sayi1 + sayi2;
        decimal fark = sayi1 - sayi2;
        decimal bolum =  sayi1 / sayi2;
        decimal carpim = sayi1 * sayi2;
        decimal mod = sayi1 % sayi2;

        Console.WriteLine("Toplam: " + toplam);
        Console.WriteLine("Fark: " + fark);
        Console.WriteLine("Bolum: " + bolum);
        Console.WriteLine("Carpim: " + carpim);
        Console.WriteLine("Mod: " + mod); */

        // random sinifi
        /*
        Random rastgele = new Random();
        int sayi1 = rastgele.Next(100);// max deger belirtilir
        int sayi2 = rastgele.Next(5,15);// sayi araligi verilir

        Console.WriteLine("Rastgele sayi:"+sayi1);
        Console.WriteLine("Rastgele sayi:"+sayi2);
        */

        // conversion methods convert
        /*
        int sayi = 12;
        string sayiStr = "12";

        bool varMi = false;
        string varMiStr = "false";

        int sonuc1 = Convert.ToInt32(sayiStr);
        bool sonuc2 = Convert.ToBoolean(varMiStr);
        Console.WriteLine(sonuc1+2);
        Console.WriteLine(sonuc2);
        */

        // conversion methods parse

        /*
        string metin = "122";

        int sonuc1 = int.Parse(metin);
        Console.WriteLine(sonuc1+3);
        bool sonuc2 = bool.Parse("true");
        bool sonuc3 = bool.Parse("false");
        Console.WriteLine(sonuc3);

        decimal sayi = 12.3m; //decimal
        decimal sonuc4 = decimal.Parse("12,3");// icerideki sayiya cevir

        Console.WriteLine(sonuc4+3);//125
        */

        // conversion methods string
        /*
        int sayi = 10;
        decimal para = 1000.45m; //decimal
        double sayiDouble = 100.4d;
        float sayiFloat = 4.5f;
        bool varMi = true;

        Console.WriteLine(sayi+5);//15
        string strSayi = sayi.ToString();//"10"
        Console.WriteLine(strSayi+5);//"105"
        Console.WriteLine(sayiDouble.ToString()+5);//100.45
        Console.WriteLine(sayiFloat.ToString()+10);//4.510
        */

        //Implicit ve explicit donusumler

        /*
        int sayi = 4;
        Console.WriteLine(sayi+5);//9: implicit olarak string yazdirilir

        string strSayi = "10";
        Console.WriteLine(strSayi+5);//"105": 5.toString explicit olarak string yazdirilir

        Console.WriteLine(strSayi+ sayi.ToString()); // 104 explicit
        */

        //Boxing
        /*
        byte yas = 25;
        int sayi = yas;// boxing - kutulama

        object obj; // object obj = null butun veri tiplerini kapsar
        
        obj = 10;
        Console.WriteLine(obj);//10
        // Console.WriteLine(obj+5); console writeline obj veritipini tanimadigi icin donusum yapamaz
        Console.WriteLine(obj.ToString()+5);//"105"
        Console.WriteLine(Convert.ToInt32(obj)+5);// 15
        */

        //Unboxing

        /*
        object obj1 = 5; // boxing
        object obj2 = true; // boxing

        int sonuc1 = (int)obj1; //unboxing - casting
        bool sonuc2 = (bool)obj2;// unboxing - casting

        Console.WriteLine(sonuc1+5);// 10
        Console.WriteLine(sonuc2);// true
        */

        // karar yapilari if-else
        /*
        int sayi = 4,sayi2=10;


        if (sayi == 4)
        {
            Console.WriteLine("4");//4
        }
        if(sayi > sayi2){
            Console.WriteLine(sayi + "buyuktur"+ sayi2);// bu bloga girmez
        }
        else if (sayi2 > sayi){
            Console.WriteLine(sayi2 + "buyuktur"+ sayi);// 10 buyuktur 4
        }
        else{
            Console.WriteLine("bb");//bb yaz
        }
        */

        //karar yapilari nested if
        /*
        int sayi1 = 10, sayi2=20;
        
        if (sayi1 != sayi2){
            if (sayi1 > sayi2){
                Console.WriteLine(sayi1 + "buyuktur"+ sayi2);// 10 buyuktur 20
            }
            else if (sayi2 > sayi1){
                Console.WriteLine(sayi2 + "buyuktur"+ sayi1);// 20 buyuktur 10 *
            } 
        }
        else{
            Console.WriteLine(sayi1+"esittir"+sayi2);
        }
        */
        
        //mantiksal operatorler && || ! != < > <= >=
        /*
        int sayi1 = 10, sayi2=20;
        if (sayi1 < sayi2 && sayi1 == 10){
            Console.WriteLine("dogru");
        }
        if (sayi1 > 1 || sayi2 >20){
            Console.WriteLine("evet");
        }
        if (sayi1 != 10 || sayi2 == 20){
            Console.WriteLine("dogrudur usta");
        }
        */
        
        /*ornek uygulama

        ogrenci sinava girdiyse
        aa : 100-90
        ba : 89-80
        cb : 79-70
        dd : 69-50
        ff : 49-0
        */
        /*
        bool sinavGr = true;
        int not = 68;

        if (sinavGr == true) {
            if(not==0 && not<= 49){
                Console.WriteLine("FF");
            }
            else if(not>=50 && not<=69){
                Console.WriteLine("DD");
            }
            else if(not>=70 && not<=79){
                Console.WriteLine("CB");
            }
            else if(not>=80 && not<=89){
                Console.WriteLine("BA");
            }
            else if(not>=90 && not<=100){
                Console.WriteLine("AA");
            }
            else{
                Console.WriteLine("hata");
            }
        }
        else{
            Console.WriteLine("Ogrenci sinava girmemistir");
        }
        */

        //ternary operator
        /*
        int sayi1 = 10;
        int sayi2 = 10;

        string sonuc = (sayi1 > sayi2) ? "buyuktur" : (sayi1 == sayi2) ? "esittir" : "kucuktur"; // eger sayi1 sayi2 den buyuk ise sonuc degeri ilk string degerini alir. aksi halde ikincisini alir.
        Console.WriteLine(sayi1+sonuc+sayi2);//10 esittir 10
        */
        

        //switch case
        /*
        int sayi=10;

        switch (sayi) { 
            case 5:
            Console.WriteLine(5);
            break;

            case 6:
            Console.WriteLine(6);
            break;

            case 10:
            Console.WriteLine(10);
            break;

            default:
            Console.WriteLine(100);
            break;
        }
            */

            //try-catch finally
            /*
            string? strSayi = String.Empty;
            string? strBolen = String.Empty;
            
            Console.WriteLine("Lutfen sayi giriniz:");
            strSayi = Console.ReadLine();
            
            Console.WriteLine("Bolen sayisi giriniz:");
            strBolen = Console.ReadLine();

            int sayi = Convert.ToInt32(strSayi);
            int bolen = Convert.ToInt32(strBolen);
           
            
            decimal sonuc = sayi / bolen;
            Console.WriteLine("bolum = " + sonuc);
            */
            /*
            Console.WriteLine("sayi giriniz:");
            string? strSayi = Console.ReadLine();
            Console.WriteLine("bolen sayisi giriniz:");
            string? strBolen = Console.ReadLine();

            int sayi = int.Parse(strSayi);
            int bolen = int.Parse(strBolen);

            try{
                decimal sonuc = sayi / bolen;
                Console.WriteLine("Bolum = " + sonuc);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                Console.WriteLine("bir hata olustu.");
            }
            */
        
            //throw keyword
            /*
            Console.WriteLine("sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine("bolen sayisi giriniz:");
            int bolen = int.Parse(Console.ReadLine());

            try{
                if (bolen == 0){
                throw new DivideByZeroException("bolen sayi 0 olamaz");
            }
                else{
                decimal sonuc = sayi / bolen;
                Console.WriteLine("bolum = " + sonuc);
                }
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                Console.WriteLine("bir hata olustu.");
            }
            */

            //for dongusu
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);// 0-9
            }
            */
            //while dongusu

            /*
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i); // 0-9
                i++;
            }
            */

            //do-while dongusu
            /*
            int i = 0;

            do
            {
                Console.WriteLine(i); // 0-9
                i++;
            } while (i < 10);
            */

            //break continue keyword
            /*
            for(var i=0;i<10;i++){
                Console.WriteLine(i);
                if (i == 5){
                    break; // i=5 oldugunda program break ile donguden cikar
                }
            }
            */
            /*
            for(var i=0;i<10;i++){
                if (i == 2){
                    continue; // i=2 oldugunda program continue ile dongunun basina doner.
                }
                if (i == 5){
                    break; // i=5 oldugunda program break ile donguden cikar
                }
                Console.WriteLine(i);// 0,1,3,4
            }
            */

            //diziler
            /*
            string[] dizi = new string[5]; // 5 elemanli dizi olusturuldu
            dizi[0] = "a";
            dizi[1] = "b";
            dizi[2] = "c";

            Console.WriteLine(dizi[0]);//a

            for(var i=0;i<dizi.Length;i++){
                Console.WriteLine(dizi[i]);//a,b,c
            }
            */
            /*
            string[] meyveler = {"elma","armut","muz","karpuz"};

            for(int i=0;i<meyveler.Length;i++){
                Console.WriteLine(meyveler[i]);//elma,armut,muz,karpuz
            }
            */

            // foreach dongusu
            /*
            string[] meyveler = {"elma","armut","muz","karpuz"};

            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);//elma,armut,muz,karpuz
            }
            */

            //dizilerde metodlar (clone,copy,sort,reverse,indexof,resize)
            /*
            //clone
            string[] meyveler = {"elma","armut","muz","karpuz"};

            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);//elma,armut,muz,karpuz
            }
            diziYaz(meyveler);//muz,karpuz,elma,armut,kiraz // foreach yerine metod kullandik

            Console.WriteLine("*********************************************");
            Console.WriteLine("clone");
            string[] meyveler2 = (string[])meyveler.Clone();
            foreach (var meyve in meyveler2)
            {
                Console.WriteLine(meyve);//elma,armut,muz,karpuz
            }
            diziYaz(meyveler);//muz,karpuz,elma,armut,kiraz // foreach yerine metod kullandik

            //copy
            Console.WriteLine("*********************************************");
            Console.WriteLine("copy");
            string[] meyveler3 = new string[meyveler.Length];
            meyveler.CopyTo(meyveler3,0);//kopyalamaya kacinci indexten baslayacaginiz belirtirsiniz.
            foreach (var meyve in meyveler3)
            {
                Console.WriteLine(meyve);//elma,armut,muz,karpuz
            }
            diziYaz(meyveler);//muz,karpuz,elma,armut,kiraz // foreach yerine metod kullandik

            //sort
            Console.WriteLine("*********************************************");
            Console.WriteLine("sort");
            Array.Sort(meyveler);//alfabetik siralama yaptik
            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);//armut,elma,karpuz,muz
            }
            diziYaz(meyveler);//muz,karpuz,elma,armut,kiraz // foreach yerine metod kullandik
            
            //reverse
            Console.WriteLine("*********************************************");
            Console.WriteLine("reverse");
            Array.Reverse(meyveler);//diziyi ters cevirdik
            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);//muz,karpuz,elma,armut
            }
            diziYaz(meyveler);//muz,karpuz,elma,armut,kiraz // foreach yerine metod kullandik

            //resize
            Console.WriteLine("*********************************************");
            Console.WriteLine("resize");
            Array.Resize(ref meyveler,meyveler.Length+1);//resize ile dizi boyutunu arttirdik
            meyveler[meyveler.Length-1] = "kiraz";//dizinin sonuncu elemanina kiraz atadik
            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);//muz,karpuz,elma,armut,kiraz
            }

            diziYaz(meyveler);//muz,karpuz,elma,armut,kiraz // foreach yerine metod kullandik

            //indexof
            Console.WriteLine("*********************************************");
            Console.WriteLine("indexof");
            Console.WriteLine(Array.IndexOf(meyveler,"elma"));//2 bir dizide bir degeri aramak icin kullanilir, index degeri doner. eger bulamazsa -1 degeri doner.
            */

            /* *************************************** IKINCI KISIM *************************************** */
            //deger dondurmeyen metod
            MerhabaYaz();//Merhaba

            //deger donduren metod
            Console.WriteLine(Topla());//10
            
            //2 deger alan ve deger donduren metod
            int sonuc = Topla(5,6);
            Console.WriteLine(sonuc);//11
            
            //3 deger alan ve deger dondurmeyen metod
            VoidTopla(5,6,7);//18

            //varsayilan ve opsiyonel parametreler metodun ustune gelindigine varsayilan degerler gozukur
            Topla2(10,5);//20

            //params
            Console.WriteLine(Topla3(1,2,3,4,5,6,7,8,9,10));//55

            //metod overloading
            Metod1();//metod1'in ustune gelindiginde birden fazla versiyonunun oldugu gorulur

            //recursive metod
            //faktoiyel hesaplama
            /*
            Console.WriteLine("*********************************************");
            Console.WriteLine("FAKTORIYEL HESAPLAMA");
            Console.Write("sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int result = Faktoriyel(sayi);
            Console.WriteLine(sayi+"! = "+result);// 5 girildiginde 120 degeri doner
            */
            /* ********************************************************************************************** */

            /* *************************************** STRING METHODLARI *************************************** *//*
            
            //Trim,ToLower,ToUpper,SubString,Reverse,IndexOf,Remove,Contains,Replace,Split
            Console.WriteLine("*********************************************");
            Console.WriteLine("str");
            string str = " Deneme yapiyorum ses geliyor mu beyler. ";
            Console.WriteLine(str);//" Deneme yapiyorum ses geliyor mu beyler. "

            //trim
            Console.WriteLine("*********************************************");
            Console.WriteLine("trim");
            str = str.Trim();//str stringinin basindaki ve sonundaki bosluklari siler|"Deneme yapiyorum ses geliyor mu beyler."
            Console.WriteLine(str);
            Console.WriteLine("trim isleminden sonra str stringinin basindaki ve sonundaki bosluklar silindi ve artik bosluksuz gorunuyor");
            //trim isleminden sonra str stringinin basindaki ve sonundaki bosluklar silinmis oldu

            //toLower
            Console.WriteLine("*********************************************");
            Console.WriteLine("toLower");
            Console.WriteLine("'"+str.ToLower()+"'");//str stringinin tum karakterlerini kucuk harfe cevirir|"deneme yapiyorum ses geliyor mu beyler."

            //toUpper
            Console.WriteLine("*********************************************");
            Console.WriteLine("toUpper");
            Console.WriteLine("'"+str.ToUpper()+"'");//str stringinin tum karakterlerini buyuk harfe cevirir|"DENEME YAPIYORUM SES GELIYOR MU BEYLER.

            //SubString
            Console.WriteLine("*********************************************");
            Console.WriteLine("SubString");
            string newString = str.Substring(0,5);//str stringinin 0. indexinden baslayarak 5 karakter alir|"Denem"
            Console.WriteLine("'"+newString+"'");//" Denem "

            //Reverse
            Console.WriteLine("*********************************************");
            Console.WriteLine("Reverse");
            char[] chars=str.ToCharArray();//str stringinin karakterlerini ters cevirir
            Array.Reverse(chars);
            string reversed = new string(chars);
            Console.WriteLine("'"+reversed+"'");//".relyeb um royileg ses muroyipay enemeD"

            //IndexOf
            Console.WriteLine("*********************************************");
            Console.WriteLine("IndexOf "+"'beyler': "+str.IndexOf("beyler")); //str stringinin icerisinde "beyler" stringinin basladigi indexi doner|32
            Console.WriteLine("IndexOf "+"'e'(after index 10): "+str.IndexOf('e',10));//str stringinin icerisinde "e" karakterinin 10. indexinden sonraki ilk indexi doner|18
            
            //Remove
            Console.WriteLine("*********************************************");
            Console.WriteLine("Remove");
            Console.WriteLine("'"+str.Remove(14)+"'");//str stringinin 14. indexinden sonraki tum karakterleri siler| "Deneme yapiyor" 

            //Contains
            Console.WriteLine("*********************************************");
            Console.WriteLine("Is "+"'"+str+"'"+"contains 'ses'? :"+str.Contains("ses"));//str stringinin icerisinde "ses" kelimesinin olup olmadigini kontrol eder|bool sonuc doner|true

            //Replace
            Console.WriteLine("*********************************************");
            Console.WriteLine("Replace 'beyler' with 'agalar'" +"\n"+"'"+str+"'");
            Console.WriteLine(str.Replace("beyler","agalar"));//str stringinin icerisindeki "beyler" stringini "agalar" stringi ile degistirir|"Deneme yapiyorum ses geliyor mu agalar."

            //Split
            Console.WriteLine("*********************************************");
            Console.WriteLine("Split");
            string[] strArray = str.Split(' ');
            Console.WriteLine(string.Join('|',strArray));//str stringini bosluk karakterine gore ayirir ve string arrayine atar| "Deneme|yapiyorum|ses|geliyor|mu|beyler."
            Console.WriteLine("*********************************************");
            */
            /* ********************************************************************************************** */
            
            /* *************************************** MATH METODLARI *************************************** *//*
            
            //PI,Floor,Ceiling,Round,Max,Min,Pow,Sqrt
            Console.WriteLine("*********************************************");
            Console.WriteLine("degiskenler");
            double val = 9.46;
            double val2= 3.11;
            Console.WriteLine("val= "+val);
            Console.WriteLine("val2= "+val2);

            //pi
            Console.WriteLine("000000000000000000000000000000000000");
            Console.WriteLine("pi= "+Math.PI);//3.14159265358979

            //floor
            Console.WriteLine("000000000000000000000000000000000000");
            Console.WriteLine("Floor of "+val+" = "+ Math.Floor(val));//sayiyi asagi dogru yuvarlar|9

            //ceiling
            Console.WriteLine("000000000000000000000000000000000000");
            Console.WriteLine("Ceiling of "+val+" = "+ Math.Ceiling(val));//sayiyi yukari dogru yuvarlar|10| 6, 4 u 5e yuvarlar. 5 de 9 u 10 a yuvarlar
            Console.WriteLine("Ceiling of "+val2+" = "+ Math.Ceiling(val2));//sayiyi yukari dogru yuvarlar|4| 3.11 deki 1 diger 1 i etkilemez. diger 1 de 3 u etkliemez. ceiling 3 sayisini direk 4 e yuvarlar

            //round
            Console.WriteLine("000000000000000000000000000000000000");
            Console.WriteLine("Round of "+val+" = "+ Math.Round(val,1));//virgulden sonraki 1 basamagi yuvarlar|9.5

            //max
            Console.WriteLine("000000000000000000000000000000000000");
            Console.WriteLine("Max of "+val+" and "+val2+" = "+ Math.Max(val,val2));//iki sayidan buyuk olanini doner|9.46

            //min
            Console.WriteLine("000000000000000000000000000000000000");
            Console.WriteLine("Min of "+val+" and "+val2+" = "+ Math.Min(val,val2));//iki sayidan kucuk olanini doner|3.11

            //pow
            Console.WriteLine("000000000000000000000000000000000000");
            Console.WriteLine("Pow of "+val+" and "+val2+" = "+ Math.Pow(val,val2));//val degerinin val2 degerine gore ussunu alir| 9.46^3.11

            //sqrt
            Console.WriteLine("000000000000000000000000000000000000");
            Console.WriteLine("Sqrt of "+9832+" = "+ Math.Sqrt(9832));//9832 sayisinin karekokunu alir|99,15644204992432
            */
            /* ********************************************************************************************** */

            /* *************************************** DATETIME METODLARI *************************************** */
            /*
            // Now, AddDays, AddHours,AddMonths, AddYears, ToShortDateString, ToLongDateString, ToShortTimeString, ToLongTimeString
            //now
            Console.WriteLine("*********************************************");
            Console.WriteLine("Now: "+DateTime.Now);//simdiki zamani verir

            //AddDays
            Console.WriteLine("*********************************************");
            Console.WriteLine("AddDays: "+DateTime.Now.AddDays(2));//simdiki zamana 2 gun ekler

            //AddHours
            Console.WriteLine("*********************************************");
            Console.WriteLine("AddHours: "+DateTime.Now.AddHours(3));//simdiki zamana 3 saat ekler

            //AddMonths
            Console.WriteLine("*********************************************");
            Console.WriteLine("AddMonths: "+DateTime.Now.AddMonths(5));//simdiki zamana 5 ay ekler

            //AddYears
            Console.WriteLine("*********************************************");
            Console.WriteLine("AddYears: "+DateTime.Now.AddYears(1));//simdiki zamana 1 yil ekler

            //ToShortDateString
            Console.WriteLine("*********************************************");
            Console.WriteLine("ToShortDateString: "+DateTime.Now.ToShortDateString());//simdiki zamani kisa tarih formatinda verir| 2.10.2023

            //ToLongDateString
            Console.WriteLine("*********************************************");
            Console.WriteLine("ToLongDateString: "+DateTime.Now.ToLongDateString());//simdiki zamani uzun tarih formatinda verir| 2 Ekim 2023 Pazartesi

            //ToShortTimeString
            Console.WriteLine("*********************************************");
            Console.WriteLine("ToShortTimeString: "+DateTime.Now.ToShortTimeString());//simdiki zamani kisa saat formatinda verir|22:19

            //ToLongTimeString
            Console.WriteLine("*********************************************");
            Console.WriteLine("ToLongTimeString: "+DateTime.Now.ToLongTimeString());//simdiki zamani uzun saat formatinda verir|22:19:23

            //Now Day, Month, Year, Hour, Minute, Second
            Console.WriteLine("*********************************************");
            Console.WriteLine("Now Day: "+DateTime.Now.Day);//simdiki zamandaki gunu verir|2
            Console.WriteLine("Now Month: "+DateTime.Now.Month);//simdiki zamandaki ayi verir|10
            Console.WriteLine("Now Year: "+DateTime.Now.Year);//simdiki zamandaki yili verir|2023
            Console.WriteLine("Now Hour: "+DateTime.Now.Hour);//simdiki zamandaki saati verir|22
            Console.WriteLine("Now Minute: "+DateTime.Now.Minute);//simdiki zamandaki dakikayi verir|19
            Console.WriteLine("Now Second: "+DateTime.Now.Second);//simdiki zamandaki saniyeyi verir|23
            Console.WriteLine("*********************************************");

            DateTime tarih = new DateTime(2000,6,24,19,00,00);//tarih degiskeni olusturuldu
            Console.WriteLine("Dogum Tarihi: "+tarih.ToString());//24.06.2000 19:00:00
            Console.WriteLine("*********************************************");
            */
            /* ********************************************************************************************** */
    }       
    /* *************************************** IKINCI KISIM *************************************** */
    //METODLAR      
    static void DiziYaz(string[] dizi){
        foreach (string item in dizi)
        {
            Console.WriteLine(item);
        }
    }

    //deger dondurmeyen metod

    static void MerhabaYaz(){
        Console.WriteLine("Merhaba");//Merhaba
    }
    //deger donduren metod
    static int Topla(){
        return 5+5;//10
    }
    static int Topla(int sayi1,int sayi2){ //2 deger alan ve deger donduren metod
        return sayi1+sayi2;
    }
    static void VoidTopla(int sayi1,int sayi2,int sayi3){ //3 deger alan ve deger dondurmeyen metod
        Console.WriteLine(sayi1+sayi2+sayi3);
    }

    //varsayilan ve opsiyonel parametreler
    static int Topla2(int sayi1,int sayi2,int sayi3=5){ //sayi3 degeri girilmezse 5 degerini alir|opsiyonel olmayan parametreler her zaman son parametreler olmalidir
        return sayi1+sayi2+sayi3;
    }
    
    //params keyword
    static int Topla3(params int[] sayilar){ //params keywordu ile diziye istedigimiz kadar deger gonderebiliriz| params keywordu her zaman son parametre olmalidir(int x, params int[] y)
        int toplam=0;
        foreach (var sayi in sayilar)
        {
            toplam+=sayi;
        }
        return toplam;
    }

    //recursive metod
    static int Faktoriyel(int sayi){ // faktoriyel hesaplama
        if (sayi == 0 || sayi == 1){
            return 1;
        }
        return sayi * Faktoriyel(sayi-1);
    }

    //metod imzasi
    static void Metod1(){

    }
    static void Metod1(int sayi){ // metod parametre aldigindan hata vermez

    }
    static void Metod1(string metin){ //metod parametresi farkli veri tipinda oldugundan hata vermez

    }
    static void Metod1(int sayi,string metin){ //metod birden fazla parametre aldigindan hata vermez

    }

}