using System;
using System.Collections.Generic;
using System.Text;

namespace SynCoolFeedback
{
    public class Tutor
    {
        public string username { get; set; }
        public double mediaVoti { get; set; }

        public Tutor()
        {

        }

        public Tutor(string username, double mediaVoti)
        {
            this.username = username;
            this.mediaVoti = mediaVoti;
        }
    }
}
