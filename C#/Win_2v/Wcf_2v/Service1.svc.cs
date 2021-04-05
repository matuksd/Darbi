using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf_2v
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {   // it kā datubāze - it kā ar ierobežotu pieeju
        private class SportRec
        {
            public string SpName;
            public double Run100, Len, Leks;
            public SportRec(string spName, double run100, double len, double leks)
            { SpName = spName; Run100 = run100; Len = len; Leks = leks; }
        }
        private class Sport
        {
            static public List<SportRec> DList;
            static Sport()
            {
                DList = new List<SportRec>();
                DList.Add(new SportRec("Liepa", 11.5, 7.30, 1.78));
                DList.Add(new SportRec("Ozols", 11.9, 7.40, 1.81));
                DList.Add(new SportRec("Lācis", 11.7, 7.50, 1.79));
                DList.Add(new SportRec("Līcis", 11.2, 7.60, 1.83));
                DList.Add(new SportRec("Bērziņš", 11.8, 7.70, 1.84));
            }
        }
        // publiskās metodes darbam ar "datubāzi"
        public string FindByName(string S)
        {
            string X = " - ";
            foreach (SportRec d in Sport.DList)
                if (S == d.SpName)
                    X = "Name: " + d.SpName + " - Run 100m:" + d.Run100.ToString("F2") +
                    " - Length: " + d.Len.ToString("F2");
            return X;
        }
        public string[] Vardi()
        {
            int sk = 0;
            
            foreach (SportRec d in Sport.DList)
            {
                sk++;
            }
            string[] vardi = new string[sk];
            int i = 0;
            foreach (SportRec d in Sport.DList)
            {
                vardi[i] = d.SpName;
                i ++;

            }
            return vardi;
        }
        public int Vardusk()
        {
            int sk = 0;

            foreach (SportRec d in Sport.DList)
            {
                sk++;
            }
            return sk;
        }
        public string SortedbyName()
        {
            //Sort izmantojot Linq
            List<SportRec> SorList = Sport.DList.OrderBy(a => a.SpName[0]).ToList();

            string sor = "";  
            foreach (SportRec d in SorList)
            {
                sor += "\n" + d.SpName + "          " + d.Run100.ToString("F2") + "           " + d.Len.ToString("F2") + "             " + d.Leks.ToString("F2");
            }
            return sor;
        }
        public string SortedbyRun100m()
        {
            List<SportRec> SorList = Sport.DList.OrderBy(a => a.Run100).ToList();
            string sor = "";
            foreach (SportRec d in SorList)
            {
                sor +="\n" + d.SpName + "          " + d.Run100.ToString("F2") + "           " + d.Len.ToString("F2") + "             " + d.Leks.ToString("F2");
            }
            return sor;

        }
        public string SortedbyHeight()
        {
            List<SportRec> SorList = Sport.DList.OrderBy(a => a.Len).ToList();
            SorList.Reverse();
            string sor = "";
            foreach (SportRec d in SorList)
            {
                sor += "\n" + d.SpName + "          " + d.Run100.ToString("F2") + "           " + d.Len.ToString("F2") + "             " + d.Leks.ToString("F2");
            }
            return sor;
        }
        public string SortedbyLeksana()
        {
            List<SportRec> SorList = Sport.DList.OrderBy(a => a.Leks).ToList();
            SorList.Reverse();
            string sor = "";
            foreach (SportRec d in SorList)
            {
                sor += "\n" + d.SpName + "          " + d.Run100.ToString("F2") + "           " + d.Len.ToString("F2") + "             " + d.Leks.ToString("F2");
            }
            return sor;

        }
        public string SortedbyNameBR()
        {
            //Sort izmantojot Linq
            List<SportRec> SorList = Sport.DList.OrderBy(a => a.SpName[0]).ToList();

            string sor = "";
            foreach (SportRec d in SorList)
            {
                sor += "<br>" + d.SpName + "          " + d.Run100.ToString("F2") + "           " + d.Len.ToString("F2") + "             " + d.Leks.ToString("F2");
            }
            return sor;
        }
        public string SortedbyRun100mBR()
        {
            List<SportRec> SorList = Sport.DList.OrderBy(a => a.Run100).ToList();
            string sor = "";
            foreach (SportRec d in SorList)
            {
                sor += "<br>" + d.SpName + "          " + d.Run100.ToString("F2") + "           " + d.Len.ToString("F2") + "             " + d.Leks.ToString("F2");
            }
            return sor;

        }
        public string SortedbyHeightBR()
        {
            List<SportRec> SorList = Sport.DList.OrderBy(a => a.Len).ToList();
            SorList.Reverse();
            string sor = "";
            foreach (SportRec d in SorList)
            {
                sor += "<br>" + d.SpName + "          " + d.Run100.ToString("F2") + "           " + d.Len.ToString("F2") + "             " + d.Leks.ToString("F2");
            }
            return sor;
        }
        public string SortedbyLeksanaBR()
        {
            List<SportRec> SorList = Sport.DList.OrderBy(a => a.Leks).ToList();
            SorList.Reverse();
            string sor = "";
            foreach (SportRec d in SorList)
            {
                sor += "<br>" + d.SpName + "          " + d.Run100.ToString("F2") + "           " + d.Len.ToString("F2") + "             " + d.Leks.ToString("F2");
            }
            return sor;

        }
    } // Service1

}
