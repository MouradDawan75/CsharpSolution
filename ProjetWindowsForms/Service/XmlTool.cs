using ProjetWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetWindowsForms.Service
{
    public class XmlTool
    {

        public static void ExportXml(string chemin, List<Ligne> lst)
        {
            XmlSerializer xml = new XmlSerializer(lst.GetType());
            Stream flux = new FileStream(chemin, FileMode.Create);
            xml.Serialize(flux, lst);
            flux.Close();
        }

        public static List<Ligne> ImportXml(string chemin)
        {
            List<Ligne> lst = new List<Ligne>();

            XmlSerializer xml = new XmlSerializer(lst.GetType());
            Stream flux = new FileStream(chemin, FileMode.Open);
            lst = (List<Ligne>)xml.Deserialize(flux);
            flux.Close() ;

            return lst;
        }
    }
}
