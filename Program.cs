using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using tpmodul8;

public class Program
{
    public static void Main(string[] args)
    {
        // Memanggil Class CovidConfig
        // Berfungsi untuk integrasi json, dan runtime configuration
        CovidConfig config = new CovidConfig();
        Config Konfig = new Config();

        // Menerima inputan 1 dalam satuan suhu celcius
        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + Konfig.configuration.SatuanSuhu);
        double inputSuhu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman?");
        int inputHari = Convert.ToInt32(Console.ReadLine());

        // Pengkondisian pesan yang ingin ditampilkan
        if (Konfig.configuration.SatuanSuhu == "celcius")
        {
            if ((inputSuhu >= 36.5 || inputSuhu <= 37.5) && inputHari < Konfig.configuration.BatasHariDemam)
            {
                Console.WriteLine(Konfig.configuration.PesanDiterima);
            }
            else
            {
                Console.WriteLine(Konfig.configuration.PesanDitolak);
            }
        }
        else if (Konfig.configuration.SatuanSuhu == "fahrenheit")
        {
            if ((inputSuhu >= 97.7 || inputSuhu <= 99.5) && inputHari < Konfig.configuration.BatasHariDemam)
            {
                Console.WriteLine(Konfig.configuration.PesanDiterima);
            }
            else
            {
                Console.WriteLine(Konfig.configuration.PesanDitolak);

            }
        }

        Konfig.UbahSatuan();
        Console.WriteLine();

        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + Konfig.configuration.SatuanSuhu);
        inputSuhu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman?");
        inputHari = Convert.ToInt32(Console.ReadLine());

        // Pengkondisian pesan yang ingin ditampilkan
        if (Konfig.configuration.SatuanSuhu == "celcius")
        {
            if ((inputSuhu >= 36.5 || inputSuhu <= 37.5) && inputHari < Konfig.configuration.BatasHariDemam)
            {
                Console.WriteLine(Konfig.configuration.PesanDiterima);
            }
            else
            {
                Console.WriteLine(Konfig.configuration.PesanDitolak);
            }
        }
        else if (Konfig.configuration.SatuanSuhu == "fahrenheit")
        {
            if ((inputSuhu >= 97.7 || inputSuhu <= 99.5) && inputHari < Konfig.configuration.BatasHariDemam)
            {
                Console.WriteLine(Konfig.configuration.PesanDiterima);
            }
            else
            {
                Console.WriteLine(Konfig.configuration.PesanDitolak);

            }
        }
    }
}

   