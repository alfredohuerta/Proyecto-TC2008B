// TC2008B Modelación de Sistemas Multiagentes con gráficas computacionales
// C# client to interact with Python server via POST
// Sergio Ruiz-Loza, Ph.D. March 2021

using System.IO;
using System.Net;
using UnityEngine;

namespace Models
{
    public class WebClient : MonoBehaviour
    {
        public static Car GetTraffic()
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://localhost:5000/data");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string json = reader.ReadToEnd();

            return JsonUtility.FromJson<Car>(json);
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}