using System;
using System.Collections.Generic;
using System.Text;

namespace SynCoolFeedback
{
    public class Studenti
    {

        public string username { get; set; }
        public double mediaVoti { get; set; }

        public Studenti()
        {
            
        }

        public Studenti(string username, double mediaVoti)
        {
            this.username = username;
            this.mediaVoti = mediaVoti;
        }
    }
}
