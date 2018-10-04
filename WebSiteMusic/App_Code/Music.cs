using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Music
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Music : System.Web.Services.WebService
{

    public Music()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public MusicPair getMusicByNumber(int n)
    {
        if (SimuleRepository.repository.ContainsKey(n))
            return SimuleRepository.repository[n];
        else throw new Exception("Musica inexistente");
    }

    /* 1-Add an empty web page, after that add an 2- ASMX web service visual c#*/


    public static class SimuleRepository
    {
        public static Dictionary<int, MusicPair> repository = new Dictionary<int, MusicPair>()
        {
            {1, new MusicPair {autor="Pink Floyd", song="Time"} },
            {2, new MusicPair {autor="Pink Floyd", song="Comfortably numb"} },
            {3, new MusicPair {autor="Genesis", song="Dancing with the Moonlit Knight" } },
            {4, new MusicPair {autor="Nina Simone", song="Don't Let Me Be Misunderstood" } },
            {5, new MusicPair {autor="Led Zeppelin", song="Stairway to Heaven"      } },
            {6, new MusicPair {autor="Sade", song="By Your Side"} },
            {7, new MusicPair {autor="James", song="Getting Away With it" } },
            {8, new MusicPair {autor="Amy Winehouse", song="Back to Black" } }
        };
    }
    public class MusicPair
    {
        public string autor;
        public string song;
    }











}
