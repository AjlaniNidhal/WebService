using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace ChallengeApp
{
    /// <summary>
    /// Description résumée de ChallengeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class ChallengeService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Fibonacci(int n)
        {
            try
            {
                int firstnumber = 0, secondnumber = 1, result = 0;

                if (n < 1 || n > 100)
                {
                    return -1;
                }

                if (n == 1)
                {
                    return 1;
                }

                for (int i = 2; i <= n; i++)
                {
                    result = firstnumber + secondnumber;
                    firstnumber = secondnumber;
                    secondnumber = result;
                }

                return result;
            }
            catch (Exception)
            {

                return -1;
            }

        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            string jsonResult = string.Empty;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            jsonResult = JsonConvert.SerializeXmlNode(doc);

            return jsonResult;
        }
   }
}
