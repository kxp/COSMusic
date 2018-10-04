using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using microsofttranslator.api;

/// <summary>
/// Summary description for MyTranslator
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class MyTranslator : System.Web.Services.WebService
{

    public MyTranslator()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string Translate(string sentence, string srcLang, string dstLang)
    {
      
            String transText = String.Empty;
            try
            { // Call Web Service Operation
                var service = new SoapService();
                // TODO initialize WS operation arguments here
                string appId = "F4E6E0444F32B660BED9908E9744594B53D2E864";
                string text = sentence;
                string from = srcLang;
                string to = dstLang;
                string contentType = "text/html";
                string category = "general";
                string reservedFlags = "";

                // TODO process  result here
                transText = service.Translate(appId, text, from, to, contentType, category, reservedFlags);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        return transText;

    }

}
