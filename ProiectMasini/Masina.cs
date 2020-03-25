using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMasini
{
    class Masina
    {
        public static int idM;
        private int idMasina;
        private string nume_vanzator;
        private string nume_cumparator;
        private string firma, model;
        private int an_fabricatie;
        private string culoare;
        private string optiuni;
        private string data_tranzactie;
        private double pret;

        public static int idMasinaProp { get; set; }
        public string numeVanzator { get; set; }
        public string numeCumparator { get; set; }
        public string firmaProp { get; set; }
        public string modelProp { get; set; }
        public int anFabricatie { get; set; }
        public string culoareProp{get; set;}
        public string optiuniProp { get; set; }
        public string dataTranzactie { get; set; }
        public double pretProp { get; set; }


        public Masina()
        {
            this.nume_vanzator = string.Empty;
            this.nume_cumparator = string.Empty;
            this.firma = string.Empty;
            this.model = string.Empty;
            this.an_fabricatie = 0;
            this.culoare = string.Empty;
            this.optiuni = string.Empty;
            this.data_tranzactie = string.Empty;
            this.pret = 0;

            idM++;
            setIdMasina(idM);

        }
        public Masina(string nv,string nc,string firma,string model,int anf,string culoare,string optiuni,string dt,double pret)
        {
            numeVanzator = nv;
            numeCumparator = nc;
            firmaProp = firma;
            modelProp = model;
            anFabricatie = anf;
            culoareProp = culoare;
            this.optiuni = optiuni;
            dataTranzactie = dt;
            pretProp = pret;

            idM++;
            setIdMasina(idM);
        }

        public Masina(string nume1)
        {
            string[] buff = nume1.Split(",");
            numeVanzator = buff[0];
            numeCumparator = buff[1];
            firmaProp = buff[2];
            modelProp = buff[3];
            anFabricatie = Convert.ToInt32(buff[4]);
            culoareProp = buff[5];
            dataTranzactie = buff[6];
            pretProp = Convert.ToDouble(buff[7]);

            idM++;
            setIdMasina(idM);
        }

        //public string toString()
        //{
        //    return idMasinaProp+" Nume vanzator: " + nume_vanzator + ", nume cumparator: " + nume_cumparator + ", firma: " + firma + ", model: " + model +
        //        ", an fabricatie: " + an_fabricatie + ", culoare: " + culoare + ", optiuni: " + optiuni + ", data tranzactie: " + data_tranzactie + ", pret: " + pret;
        //}

        public string toString()
        {
            return idMasina + ". " + firmaProp + " " + modelProp + ", "+culoareProp+", an: " + anFabricatie + ", Vanzator: " + numeVanzator +
                ", cumparator: " + numeCumparator + ", pret: " + pretProp + " euro" ;
        }

        public int getIdMasina()
        {
            return this.idMasina;
        }

        public void setIdMasina(int id)
        {
            this.idMasina = id;
        }

    }
}
