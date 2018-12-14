using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StarWars3A
{
    public partial class DetallePelicula : Form
    {
        private int epi;

        public DetallePelicula(int episodio)
        {
            epi = episodio;

            InitializeComponent();
        }
        

        private void ANewHope_Load(object sender, EventArgs e)
        {
            

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://swapi.co/api/films/" + epi + "/"));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Console.WriteLine(WebResp.StatusCode);
            Console.WriteLine(WebResp.Server);

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
                
            }

            Pelicula items = JsonConvert.DeserializeObject<Pelicula>(jsonString);
           
            lblTitulo.Text += items.title;
            lblFechaEmision.Text += items.release_date;
            lblDirector.Text += items.director;
            lblIdEpisodio.Text += items.episode_id;
            lblResumen.Text += items.opening_crawl;
            //lblPersonajes.Text += items.characters[0];

            for (int i = 0; i < items.characters.Count; i++)
            {
                String url = items.characters[i];
                HttpWebRequest WebReq1 = (HttpWebRequest)WebRequest.Create(string.Format(url));

                WebReq1.Method = "GET";

                HttpWebResponse WebResp1 = (HttpWebResponse)WebReq1.GetResponse();


                string jsonStringPersonaje;
                using (Stream stream = WebResp1.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    jsonStringPersonaje = reader.ReadToEnd();

                }
                
                Personaje p = JsonConvert.DeserializeObject<Personaje>(jsonStringPersonaje);
                lblPersonajes.Text += p.name + "\n";

            }

        }





}



}




