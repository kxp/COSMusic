using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using com.chartlyrics.api;

/// <summary>
/// Summary description for Lyrics
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Lyrics : System.Web.Services.WebService
{

    public Lyrics()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string getLyrics(string music, string song)
    {
        string lyrRes = "without   lyrics";

        apiv1 prx = new apiv1();
        GetLyricResult res = prx.SearchLyricDirect(music, song);
        if (res != null)
        {
            lyrRes = res.Lyric;
        }
        return lyrRes;
    }

}
