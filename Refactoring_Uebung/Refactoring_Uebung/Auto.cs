using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Uebung
{
    internal class Auto
    {
        private string marke;
        private string model;
        private double tankFuellungInLitern;
        private double kilometerstand;
        private int ps;
        private string nameBesitzer;
        private string nachnameBesitzer;
        private string nameVerkaeufer;
        private string nachnameVerkaeufer;


        public string Marke
        {
            get { return marke; }
        }
        public string Model
        {
            get { return model; }
        }
        public double TankFuellungInLitern
        {
            get { return tankFuellungInLitern; }
        }
        public double Kilometerstand
        {
            get { return kilometerstand; }
        }
        public int PS
        {
            get { return ps; }
        } 
        public string NameBesitzer
        {
            get { return nameBesitzer; }
        }
        public string NachnameBesitzer
        {
            get { return nachnameBesitzer; }
        }
        public string NameVerkaufer
        {
            get { return nameVerkaeufer; }
        }
        public string NachnameVerkaufer
        {
            get { return nachnameVerkaeufer; }
        }

        public Auto(string marke)
        {
            this.marke = marke;
        }

        public Auto(string marke, string model)
        {
            this.marke = marke;
            this.model = model;
        }
        public Auto(string marke, string model, double tankFuellungInLitern)
        {
            this.marke = marke;
            this.model = model;
            this.tankFuellungInLitern = tankFuellungInLitern;
        }
        public Auto(string marke, string model, double tankFuellungInLitern, int ps)
        {
            this.marke = marke;
            this.model = model;
            this.tankFuellungInLitern = tankFuellungInLitern;
            this.ps = ps;
        }
        public Auto(string marke, string model, double tankFuellungInLitern, int ps, string nameBesitzer, string nachnameBesitzer)
        {
            this.marke = marke;
            this.model = model;
            this.tankFuellungInLitern = tankFuellungInLitern;
            this.ps = ps;
            this.nameBesitzer = nameBesitzer;
            this.nachnameBesitzer = nachnameBesitzer;
        }

        public Auto(string marke, string model, double tankFuellungInLitern, int ps, string nameBesitzer, string nachnameBesitzer, string nameVerkaeufer, string nachnameVerkaeufer)
        {
            this.marke = marke;
            this.model = model;
            this.tankFuellungInLitern = tankFuellungInLitern;
            this.ps = ps;
            this.nameBesitzer = nameBesitzer;
            this.nachnameBesitzer = nachnameBesitzer;
            this.nameVerkaeufer = nameVerkaeufer;
            this.nachnameVerkaeufer = nachnameVerkaeufer;
        }

      
    }
}
