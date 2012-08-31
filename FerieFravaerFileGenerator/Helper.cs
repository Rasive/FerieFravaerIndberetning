using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FerieFravaerFileGenerator.Properties;

namespace FerieFravaerFileGenerator
{
    static class Helper
    {
        private static FerieFravaerDBClassesDataContext db = new FerieFravaerDBClassesDataContext();

        internal static void GenerateFravaerIndberetningFiles()
        {
            string startIdentifikationstransaktion = GetStartIdentifikationstransaktion("706", DateTime.Now.DayOfYear.ToString());
            Console.WriteLine(startIdentifikationstransaktion);

            List<Fravaer> listfravaer = GetFraversoplysninger();

            for (int i = 0; i < listfravaer.Count; i++)
            {
                Fravaer f = listfravaer[i];

                string brugernummer = "0706";
                string personnummer = "1234567890";
                string tidsstempling = DateTime.Now.ToString("yyyymmddhhmmssssssss");
                string afloenningsform = "7";
                bool loen = true;

                Console.WriteLine(GetTransaktion(brugernummer, personnummer, f.FoersteFravaersdag, f.SidsteFravaersdag, tidsstempling, afloenningsform, loen));
            }

            string slutIdentifikationstransaktion = GetSlutIdentifikationstransaktion("SLUTD", listfravaer.Count.ToString("0000"));
            Console.WriteLine(slutIdentifikationstransaktion);

            SkrivTransaktionerTilFil(startIdentifikationstransaktion, listfravaer, slutIdentifikationstransaktion);
            
        }

        private static void SkrivTransaktionerTilFil(string startIdentifikationstransaktion, List<Fravaer> listfravaer, string slutIdentifikationstransaktion)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(Settings.Default.KMDFilePath + @"\" + Settings.Default.KMDFileName))
            {
                writer.WriteLine(startIdentifikationstransaktion);
                for (int i = 0; i < listfravaer.Count; i++)
                {
                    Fravaer f = listfravaer[i];

                    string brugernummer = "0706";
                    string personnummer = "1234567890";
                    string tidsstempling = DateTime.Now.ToString("yyyymmddhhmmssssssss");
                    string afloenningsform = "7";
                    bool loen = true;

                    writer.WriteLine(GetTransaktion(brugernummer, personnummer, f.FoersteFravaersdag, f.SidsteFravaersdag, tidsstempling, afloenningsform, loen));
                }
                writer.WriteLine(slutIdentifikationstransaktion);

                writer.Close();
            }
        }

        private static List<Fravaer> GetFraversoplysninger()
        {
            List<Fravaer> listfravaer = (from fravaer in db.Fravaers where fravaer.Godkendt == true select fravaer).ToList();

            return listfravaer;
        }

        private static string GetTransaktion(string brugernummer, string personnummer, DateTime? foersteFravaersdag, DateTime? sidsteFravaersdag, string tidsstempling, string afloenningsform, bool ferieLoen, string dataleverandoerident = "XXXX", string transaktionstype = "DH6")
        {
            string foerstefravaersdag = foersteFravaersdag != null ? ((DateTime)foersteFravaersdag).ToString("yyyymmdd") : "00000000";
            string sidstefravaersdag = sidsteFravaersdag != null ? ((DateTime)sidsteFravaersdag).ToString("yyyymmdd") : "00000000";
            string ekstraciffer = "0";
            string raskmeldingskode = foerstefravaersdag == "00000000" && sidstefravaersdag != "00000000" ? " " : "R";
            string aarsagskode = "SY";
            string antalfravaerstimer = raskmeldingskode == "R" ? CalcFravaerstimer() : "000000";
            string antalarbejdsdage = raskmeldingskode == "R" ? CalcArbejdsdage() : "00000";
            string ansaettelsesmaade = " ";
            string forventetdatoforfoedsel = "00000000";
            string faktiskedatoforfoedsel = "00000000";
            string tfkodetilloentrans = "0000";
            string antalenhedertilloentrans = "00000000+";
            string enhedspristilloentrans = "00000000+";
            string historikmarkering = " ";
            string sletdennefravaersperiode = " ";
            string sletheleloenmodtageren = " ";

            return dataleverandoerident + transaktionstype + tidsstempling + brugernummer + afloenningsform + personnummer + ekstraciffer + raskmeldingskode + foerstefravaersdag + DateTime.Now.ToString("yyyymmdd") + sidstefravaersdag + aarsagskode + antalfravaerstimer + antalarbejdsdage + ansaettelsesmaade + forventetdatoforfoedsel + faktiskedatoforfoedsel + tfkodetilloentrans + antalenhedertilloentrans + enhedspristilloentrans + historikmarkering + sletdennefravaersperiode + sletheleloenmodtageren;
        }

        private static string CalcArbejdsdage()
        {
            return "00000";
        }

        private static string CalcFravaerstimer()
        {
            return "000000";
        }

        private static string GetStartIdentifikationstransaktion(string brugernummer, string registreringsDagnummer, string transaktionskode = "Z300", string disponibel = " ", string medietype = "6", string brugerensVolumenummer = "      ", string kodeForBlandedeTranser = "0", string terminalAfsenderIdentifikation = "000", string opgavenummer = "D", string logiskDatasaetnummer = "25")
        {
            return transaktionskode + disponibel + brugernummer + medietype + brugerensVolumenummer + registreringsDagnummer + kodeForBlandedeTranser + terminalAfsenderIdentifikation + opgavenummer + logiskDatasaetnummer;
        }

        private static string GetSlutIdentifikationstransaktion(string slutidentifikation = "SLUTD", string antalRecords = "1")
        {
            return slutidentifikation + antalRecords;
        }
    }
}
