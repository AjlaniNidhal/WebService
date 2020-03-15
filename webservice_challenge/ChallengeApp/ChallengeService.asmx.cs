using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Web.Script.Services;

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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       
        [WebMethod]
        public int Fibonacci(int n)
        {
            try
            {
                log.Info(string.Format("Request :{0}", n.ToString()));
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
                log.Info(string.Format("Response :{0}", n.ToString()));
                return result;
            }
            catch (Exception e)
            {
                log.Error(e.Message);
                return -1;
            }

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat =ResponseFormat.Json)]
        public string XmlToJson(string xml)
        {
            try
            {
                log.Info(string.Format("Request :{0}", xml));

                string jsonResult = string.Empty;

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);

                jsonResult = JsonConvert.SerializeXmlNode(doc);

                log.Info(string.Format("Response :{0}", jsonResult));
                return jsonResult;

            }
            catch (Exception e)
            {
                log.Error(e.Message);
                return "Bad Xml format";
            }
        }
   }
}
