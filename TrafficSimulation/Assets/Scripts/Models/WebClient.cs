// TC2008B Modelación de Sistemas Multiagentes con gráficas computacionales
// C# client to interact with Python server via POST
// Sergio Ruiz-Loza, Ph.D. March 2021

using System.IO;
using System.Net;
using UnityEngine;

public class WebClient : MonoBehaviour
{
    public static HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://localhost:5000/data");
    public static HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    
    public static Data GetTraffic()
    {
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Data>(json);
    }
}
