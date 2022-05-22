using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MySqlConnector;
using SynCoolFeedback;
using System.Xml;

namespace SynCoolFeedback
{
    public partial class MainPage : TabbedPage
    {
        

        List<Tutor> listaTutor = new List<Tutor>();
        List<Studenti> listaStudenti = new List<Studenti>();


        private void getDatiTutor()
        {

            String URL = "http://barclayspremierleague.altervista.org/webService/index.php?method=get&action=getAverageMark&tutorORnot=1";
            XmlTextReader reader = new XmlTextReader(URL);

            Tutor tutor = new Tutor();
            

            while (reader.Read())
            {
                
                // Do some work here on the data.
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Username")
                {
                    tutor.username = reader.ReadElementContentAsString();
                    //Console.WriteLine(tutor.username);  
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Media")
                {
                    tutor.mediaVoti = Convert.ToDouble(reader.ReadElementContentAsString());
                }


            }

            listaTutor.Add(tutor);
            listaTutor.OrderByDescending(t => t.mediaVoti);
 

            //Use HTTPWebRequest
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.AutomaticDecompression = DecompressionMethods.GZip;

            ////Get Response
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            ////Call GetResponseStream() to return Stream
            //Stream responseStream = response.GetResponseStream();

            ////Convert from XML to C# model:
            //XmlSerializer serializer = new XmlSerializer(typeof(ExrateList));
            //ExrateList exrateList = (ExrateList)serializer.Deserialize(responseStream);

        }

        private void getDatiStudenti()
        {
            String URL = "http://barclayspremierleague.altervista.org/webService/index.php?method=get&action=getAverageMark&tutorORnot=2";
            XmlTextReader reader = new XmlTextReader(URL);

            Studenti studente = new Studenti();

            while (reader.Read())
            {

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Username")
                {
                    studente.username = reader.ReadElementContentAsString();
                    //Console.WriteLine(tutor.username);  
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Media")
                {
                    studente.mediaVoti = Convert.ToDouble(reader.ReadElementContentAsString());
                }

            }

            listaStudenti.Add(studente);
            listaStudenti.OrderByDescending(s => s.mediaVoti);
        }

        public MainPage()
        {
            InitializeComponent();

            getDatiTutor();
            getDatiStudenti();

            listaClassifica.ItemsSource = listaStudenti;

            bottoneTutor.IsEnabled = true;
            bottoneStudenti.IsEnabled = false;


        }

        private void bottoneTutor_Clicked(object sender, EventArgs e)
        {
            listaClassifica.ItemsSource = listaTutor;


            bottoneStudenti.IsEnabled = true;
            bottoneTutor.IsEnabled = false;
        }

        private void bottoneStudenti_Clicked(object sender, EventArgs e)
        {
            listaClassifica.ItemsSource = listaStudenti;

            bottoneTutor.IsEnabled = true;
            bottoneStudenti.IsEnabled = false;

        }

        async private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profilo());
        }



    }
}
