using System;
using System.Collections.Generic;
using System.Text;

namespace SportClubDbManager.Data.Views
{
    public class OpponentSameSport
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
