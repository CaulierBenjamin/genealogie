using System;

namespace genealogie
{
    public class Union
    {
        private Humain mere;
        private Humain pere;
        private DateTime debut;
        private DateTime fin;

        public Union(Humain prmMere, Humain prmPere)
        {
            this.mere = prmMere;
            this.pere = prmPere;

        }
        public Union(Humain prmMere, Humain prmPere, DateTime prmDebut)
        {
            this.mere = prmMere;
            this.pere = prmPere;
            this.debut = prmDebut;
            
        }

        public Union(Humain prmMere, Humain prmPere, DateTime prmDebut, DateTime prmFin)
        {
            this.mere = prmMere;
            this.pere = prmPere;
            this.debut = prmDebut;
            this.fin = prmFin;
        }

        public void Divorce(DateTime dateFin)
        {
            this.fin = dateFin;
            
        }

        public void UnionEnfants(Humain prmEnfants)
        {
            this.mere.DefinirEnfants(prmEnfants);
            this.pere.DefinirEnfants(prmEnfants);
        }
    }
}