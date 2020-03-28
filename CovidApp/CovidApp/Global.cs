using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{
    class Global
    {
        public String confirmed;
        public String deaths;
        public String recovered;

        public Global(String confirmed, String deaths, String recovered)
        {
            this.confirmed = confirmed;
            this.deaths = deaths;
            this.recovered = recovered;
        }


    }
}
