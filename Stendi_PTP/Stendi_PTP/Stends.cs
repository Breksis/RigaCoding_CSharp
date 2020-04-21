using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stendi_PTP
{
    public class Stends
    {
        private String name;
        private String pilseta;
        private String iela;
        private String indeks;
        private String ePasts;
        private int telefons;

        public Stends(String name, String pilseta, String iela, String indeks, String ePasts, int telefons)
        {
            this.name = name;
            this.pilseta = pilseta;
            this.iela = iela;
            this.indeks = indeks;
            this.ePasts = ePasts;
            this.telefons = telefons;
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }
        public String GetPilseta()
        {
            return pilseta;
        }

        public void SetPilseta(String pilseta)
        {
            this.pilseta = pilseta;
        }

        public String GetIela()
        {
            return iela;
        }

        public void SetIela(String iela)
        {
            this.iela = iela;
        }

        public String GetIndeks()
        {
            return indeks;
        }

        public void SetIndeks(String indeks)
        {
            this.indeks = indeks;
        }

        public String GetEpasts()
        {
            return ePasts;
        }

        public void SetEpasts(String ePasts)
        {
            this.ePasts = ePasts;
        }

        public int GetTelefons()
        {
            return telefons;
        }

        public void SetTelefons(int telefons)
        {
            this.telefons = telefons;
        }
    }
}
