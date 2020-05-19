using System;
using System.Collections.Generic;
using System.Linq;

namespace genealogie
{
    public class Humain
    {
        private string nom;
        private string prennom;
        private string sexe;
        private DateTime dateNaissance;
        private DateTime dateDeces;
        private Humain lePere;
        private Humain laMere;
        List<Humain>LesEnfants = new List<Humain>();

        public Humain(string prmNom, string prmPrenom, string prmSexe)
        {
            this.nom = prmNom;
            this.prennom = prmPrenom;
            this.sexe = prmSexe;
            
        }
        public Humain(string prmNom, string prmPrenom, string prmSexe,DateTime prmDateNaissance)
        {
            this.nom = prmNom;
            this.prennom = prmPrenom;
            this.sexe = prmSexe;
            this.dateNaissance = prmDateNaissance;
        }
        public Humain(string prmNom, string prmPrenom, string prmSexe , DateTime prmDateNaissance , DateTime prmDateDeces)
        {
            this.nom = prmNom;
            this.prennom = prmPrenom;
            this.sexe = prmSexe;
            this.dateNaissance = prmDateNaissance;
            this.dateDeces = prmDateDeces;
        }

        

        public string AfficherInfo()
        {
            return (this.nom + " "+this.prennom + " "+ dateNaissance+"\n");
        }

        public string AfficherParents()
        {
            if (laMere != null && lePere != null)
            {
                return ("-------------------------------------------------------------\n Détail des parents de : " +
                        AfficherInfo() + "\n Père : " +
                        this.lePere.AfficherInfo() + "\n Mère : " + this.laMere.AfficherInfo());
            }
            return ("-------------------------------------------------------------\n Détail des parents de : " +
                    AfficherInfo() + "\n Père : Non renseigné\n Mère : Non renseigné");
        }

        public bool EstHomme()
        {
            bool p = this.sexe == "H";
            return p;
        }

        public void DefinirEnfants(Humain pEnfants)
        {
            LesEnfants.Add(pEnfants);
        }

        public string AfficherEnfants()
        {
            string reponse = "";
            bool isEmpty = !LesEnfants.Any();
            if (!isEmpty)
            {
                foreach (Humain enfant in LesEnfants)
                {
                    reponse = reponse + enfant.AfficherInfo();
                }
            }
            else
            {
                reponse = "Il n'a pas d'enfants";
            }

            return reponse;
        }
        public string AfficherAncetre()
        {
            string reponse = "";
            if (this.lePere != null && this.laMere != null)
            {
                if (this.lePere != null)
                {
                    reponse = reponse + this.lePere.AfficherInfo();
                }
                if (this.laMere != null)
                {
                    reponse = reponse + this.laMere.AfficherInfo();
                }

                return reponse;
            }
            return "Nous n'avons pas trouvé d'ancêtres ";
        }
        public bool DefinirPere(Humain pPere)
        {
            bool p = false;
            if (pPere.EstHomme())
            {
                this.lePere = pPere;
                p = true;
            }
            return p;
        }
        
        public bool DefinirMere(Humain pMere)
        {
            bool p = false;
            if (pMere.EstHomme() == false)
            {
                this.laMere = pMere;
                p = true;
            }
            return p;
        }

        public void SetDateDeces(DateTime pDateDeces)
        {
            this.dateDeces = pDateDeces;
        }

        public void SetDateNaissance(DateTime pDateNaissance)
        {
            this.dateNaissance = pDateNaissance;
        }

        public string Genealogie()
        {
            string reponse = "";
            if (this.lePere != null)
                if (this.laMere != null)
                    reponse = this.lePere.Genealogie() + this.laMere.Genealogie();
                else
                    reponse = this.lePere.Genealogie();
            else
            if (this.laMere != null)
                reponse = this.laMere.Genealogie();
            

            return reponse + this.AfficherParents();
        }
    }
}