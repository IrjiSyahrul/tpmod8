using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using tpmodul8;

namespace tpmodul8
{
     public class CovidConfig
    {
        public string SatuanSuhu { get; set; }
        public int BatasHariDemam { get; set; }
        public string PesanDitolak { get; set; }
        public string PesanDiterima { get; set; }

        public CovidConfig() { }

        public CovidConfig(string SatuanSuhu,int BatasHariDemam,string PesanDitolak,string PesanDiterima) 
        {
            this.SatuanSuhu = SatuanSuhu;
            this.BatasHariDemam = BatasHariDemam;
            this.PesanDitolak = PesanDitolak;
            this.PesanDiterima = PesanDiterima;
        }
     }

      public class Config
        {
            public CovidConfig configuration;


        public const string filePath = "D:\\Kuyliah\\Semester 4\\KPL TP\\Covid_config.json";

        public Config()
        {
            try
            {
                ReadJSON();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

    public void SetDefault()
    {
        configuration = new CovidConfig ("celcius", 14, "Anda tidak diperbolehkan masuk ke dalam gedung ini",
            "Anda diperbolehkan masuk ke dalam gedung ini");
    }

    public static void ReadJSON()
    {
        String configJsonData = File.ReadAllText(filePath);
        CovidConfig data = JsonSerializer.Deserialize<CovidConfig>(configJsonData);
        
    }

        public void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(configuration, options);
            File.WriteAllText(filePath, jsonString);
        }

        // Method ubah satuan 
        public void UbahSatuan()
        {
            if (configuration.SatuanSuhu == null)
            {
                configuration.SatuanSuhu = "celcius";
            }
            else if (configuration.SatuanSuhu == "celcius")
            {
                configuration.SatuanSuhu = "fahrenheit";
            }
            else if (configuration.SatuanSuhu == "fahrenheit")
            {
                configuration.SatuanSuhu = "celcius";
            }
        }
    }
}

