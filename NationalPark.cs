using System;
using System.Collections.Generic;

namespace NationalPark_Project
{
    class NationalPark
    {
        private string nationalParkName;
        List<string> provinceNames;
        private int announcementYear;
        private int surfaceArea;

        private static List<NationalPark>[] parkLists = { new List<NationalPark>(), new List<NationalPark>() };

        public static List<NationalPark> getList1() { return parkLists[0]; }
        public static List<NationalPark> getList2() { return parkLists[1]; }

        public int getSurfaceArea() { return this.surfaceArea; }

        public NationalPark(string nationalParkName, int announcementYear, int surfaceArea)
        {
            this.nationalParkName = nationalParkName;
            this.provinceNames = new List<string>();
            this.announcementYear = announcementYear;
            this.surfaceArea = surfaceArea;

            if (getSurfaceArea() < 15000) parkLists[0].Add(this);
            else parkLists[1].Add(this);
        }

        public void addProvince(string provinceName)
        {
            provinceNames.Add(provinceName);
        }

        private string getProvinceNames()
        {
            string provinceNamesStr = "";

            foreach (string provinceName in this.provinceNames)
                provinceNamesStr += provinceName + " ";

            return provinceNamesStr;
        }

        override public string ToString()
        {
            string output = "";
            output += "\nNational Park's Name: " + this.nationalParkName + "\nNational Park's province names: " + getProvinceNames() +
                "\nNational Park's announcement year: " + this.announcementYear + "\nNational Park's surface area: " + getSurfaceArea() + " hectares\n";

            return output;
        }

        public static void printNationalParkLists()
        {
            int count = 0, totalSmallHectares = 0, totalBigHectares = 0, totalHectares;

            Console.WriteLine("\nNational Parks smaller than 15000 hectares\n******************************************\n");

            foreach (NationalPark park in parkLists[0])
            {
                Console.WriteLine("National Park " + ++count + "\n----------------\n" + park);
                totalSmallHectares += park.getSurfaceArea();
            }

            Console.WriteLine("\nNational Parks bigger than 15000 hectares\n*****************************************\n");

            count = 0;
            foreach (NationalPark park in parkLists[1])
            {
                Console.WriteLine("National Park " + ++count + "\n----------------\n" + park);
                totalBigHectares += park.getSurfaceArea();
            }

            totalHectares = totalSmallHectares + totalBigHectares;

            Console.WriteLine("\nSmall national park's total surface area is " + totalSmallHectares + " hectares.\n");
            Console.WriteLine("Big national park's total surface area is " + totalBigHectares + " hectares.\n");
            Console.WriteLine("All national park's total surface area is " + totalHectares + " hectares.\n");
        }

        public static void createParks()
        {
            NationalPark NationalPark1 = new NationalPark("Abant Gölü Millî Parkı", 2022, 1262);
            NationalPark1.addProvince("Bolu");

            NationalPark NationalPark2 = new NationalPark("Ağrı Dağı Millî Parkı", 2004, 88015);
            NationalPark2.addProvince("Ağrı");
            NationalPark2.addProvince("Iğdır");

            NationalPark NationalPark3 = new NationalPark("Aladağlar Millî Parkı", 1995, 55064);
            NationalPark3.addProvince("Adana");
            NationalPark3.addProvince("Kayseri");
            NationalPark3.addProvince("Niğde");

            NationalPark NationalPark4 = new NationalPark("Altınbeşik Mağarası Millî Parkı", 1994, 1147);
            NationalPark4.addProvince("Antalya");

            NationalPark NationalPark5 = new NationalPark("Altındere Vadisi Millî Parkı", 1987, 4468);
            NationalPark5.addProvince("Trabzon");

            NationalPark NationalPark6 = new NationalPark("Başkomutan Tarihî Millî Parkı", 1981, 34834);
            NationalPark6.addProvince("Afyon");
            NationalPark6.addProvince("Kütahya");
            NationalPark6.addProvince("Uşak");

            NationalPark NationalPark7 = new NationalPark("Beydağları Sahil Millî Parkı", 1972, 31166);
            NationalPark7.addProvince("Antalya");

            NationalPark NationalPark8 = new NationalPark("Beyşehir Gölü Millî Parkı", 1993, 86855);
            NationalPark8.addProvince("Konya");

            NationalPark NationalPark9 = new NationalPark("Boğazköy-Alacahöyük Millî Parkı", 1988, 2600);
            NationalPark9.addProvince("Çorum");

            NationalPark NationalPark10 = new NationalPark("Botan Vadisi Millî Parkı", 2019, 11384);
            NationalPark10.addProvince("Siirt");

            NationalPark NationalPark11 = new NationalPark("Derebucak Çamlık Mağaraları Millî Parkı", 2022, 1147);
            NationalPark11.addProvince("Konya");

            NationalPark NationalPark12 = new NationalPark("Dilek Yarımadası-Büyük Menderes Deltası Millî Parkı", 1966, 27598);
            NationalPark12.addProvince("Aydın");

            NationalPark NationalPark13 = new NationalPark("Gala Gölü Millî Parkı", 2005, 6087);
            NationalPark13.addProvince("Edirne");

            NationalPark NationalPark14 = new NationalPark("Güllük Dağı Millî Parkı", 1970, 6700);
            NationalPark14.addProvince("Antalya");

            NationalPark NationalPark15 = new NationalPark("Hakkâri Cilo ve Sat Dağları Millî Parkı", 2020, 27500);
            NationalPark15.addProvince("Hakkari");

            NationalPark NationalPark16 = new NationalPark("Hatila Vadisi Millî Parkı", 1994, 16944);
            NationalPark16.addProvince("Artvin");

            NationalPark NationalPark17 = new NationalPark("Honaz Dağı Millî Parkı", 1995, 9429);
            NationalPark17.addProvince("Denizli");

            NationalPark NationalPark18 = new NationalPark("Ilgaz Dağı Millî Parkı", 1976, 1118);
            NationalPark18.addProvince("Çankırı");
            NationalPark18.addProvince("Kastamonu");

            NationalPark NationalPark19 = new NationalPark("İğneada Longoz Ormanları Millî Parkı", 2007, 3155);
            NationalPark19.addProvince("Kırklareli");

            NationalPark NationalPark20 = new NationalPark("İstiklâl Yolu Tarihî Millî Parkı", 2018, 235);
            NationalPark20.addProvince("Ankara");
            NationalPark20.addProvince("Çankırı");
            NationalPark20.addProvince("Kastamonu");

            NationalPark NationalPark21 = new NationalPark("Kaçkar Dağları Millî Parkı", 1994, 52970);
            NationalPark21.addProvince("Artvin");
            NationalPark21.addProvince("Erzurum");
            NationalPark21.addProvince("Rize");

            NationalPark NationalPark22 = new NationalPark("Karagöl-Sahara Millî Parkı", 1994, 3251);
            NationalPark22.addProvince("Artvin");

            NationalPark NationalPark23 = new NationalPark("Karatepe-Aslantaş Millî Parkı", 1958, 4143);
            NationalPark23.addProvince("Osmaniye");

            NationalPark NationalPark24 = new NationalPark("Kazdağı Millî Parkı", 1994, 20935);
            NationalPark24.addProvince("Balıkesir");

            NationalPark NationalPark25 = new NationalPark("Kızıldağ Millî Parkı", 1969, 55106);
            NationalPark25.addProvince("Isparta");

            NationalPark NationalPark26 = new NationalPark("Kop Dağı Müdafaası Tarihî Millî Parkı", 2016, 6335);
            NationalPark26.addProvince("Bayburt");
            NationalPark26.addProvince("Erzurum");

            NationalPark NationalPark27 = new NationalPark("Kovada Gölü Millî Parkı", 1970, 6551);
            NationalPark27.addProvince("Isparta");

            NationalPark NationalPark28 = new NationalPark("Köprülü Kanyon Millî Parkı", 1973, 35719);
            NationalPark28.addProvince("Antalya");

            NationalPark NationalPark29 = new NationalPark("Kuşcenneti Millî Parkı", 1959, 17058);
            NationalPark29.addProvince("Balıkesir");

            NationalPark NationalPark30 = new NationalPark("Küre Dağları Millî Parkı", 2000, 37753);
            NationalPark30.addProvince("Bartın");
            NationalPark30.addProvince("Kastamonu");

            NationalPark NationalPark31 = new NationalPark("Malazgirt Meydan Muharebesi Tarihî Millî Parkı", 2018, 238);
            NationalPark31.addProvince("Muş");

            NationalPark NationalPark32 = new NationalPark("Marmaris Millî Parkı", 1996, 29206);
            NationalPark32.addProvince("Muğla");

            NationalPark NationalPark33 = new NationalPark("Munzur Vadisi Millî Parkı", 1971, 42674);
            NationalPark33.addProvince("Tunceli");

            NationalPark NationalPark34 = new NationalPark("Nemrut Dağı Millî Parkı", 1988, 13827);
            NationalPark34.addProvince("Adıyaman");
            NationalPark34.addProvince("Malatya");

            NationalPark NationalPark35 = new NationalPark("Nene Hatun Tarihî Millî Parkı", 2009, 387);
            NationalPark35.addProvince("Erzurum");

            NationalPark NationalPark36 = new NationalPark("Sakarya Meydan Muharebesi Tarihî Millî Parkı", 2015, 13850);
            NationalPark36.addProvince("Ankara");

            NationalPark NationalPark37 = new NationalPark("Saklıkent Millî Parkı", 1996, 1643);
            NationalPark37.addProvince("Antalya");
            NationalPark37.addProvince("Muğla");

            NationalPark NationalPark38 = new NationalPark("Sarıçalı Dağı Millî Parkı", 2021, 1024);
            NationalPark38.addProvince("Ankara");

            NationalPark NationalPark39 = new NationalPark("Sarıkamış-Allahuekber Dağları Millî Parkı", 2004, 22520);
            NationalPark39.addProvince("Erzurum");
            NationalPark39.addProvince("Kars");

            NationalPark NationalPark40 = new NationalPark("Soğuksu Millî Parkı", 1959, 1186);
            NationalPark40.addProvince("Ankara");

            NationalPark NationalPark41 = new NationalPark("Spil Dağı Millî Parkı", 1968, 6801);
            NationalPark41.addProvince("İzmir");
            NationalPark41.addProvince("Manisa");

            NationalPark NationalPark42 = new NationalPark("Sultansazlığı Millî Parkı", 2006, 24358);
            NationalPark42.addProvince("Kayseri");

            NationalPark NationalPark43 = new NationalPark("Tek Tek Dağları Millî Parkı", 2007, 19335);
            NationalPark43.addProvince("Şanlıurfa");

            NationalPark NationalPark44 = new NationalPark("Troya Tarihî Millî Parkı", 1996, 13517);
            NationalPark44.addProvince("Çanakkale");

            NationalPark NationalPark45 = new NationalPark("Uludağ Millî Parkı", 1961, 13024);
            NationalPark45.addProvince("Bursa");

            NationalPark NationalPark46 = new NationalPark("Yedigöller Millî Parkı", 1965, 1623);
            NationalPark46.addProvince("Bolu");

            NationalPark NationalPark47 = new NationalPark("Yozgat Çamlığı Millî Parkı", 1958, 517);
            NationalPark47.addProvince("Yozgat");

            NationalPark NationalPark48 = new NationalPark("Yumurtalık Lagünü Millî Parkı", 2008, 16980);
            NationalPark48.addProvince("Adana");
        }
    }
}
