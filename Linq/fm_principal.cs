using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linq
{
    delegate void RequeteLinq();
    public partial class fm_principal : Form
    {
        private gesperEntities bd;
        private List<RequeteLinq> lesRequetes;
        public fm_principal()
        {
            InitializeComponent();
            bd = new gesperEntities();
            lesRequetes = new List<RequeteLinq>();
            listerRequetes();
        }

        // Bugs: 20;21;26V2;29V2;38
        private void listerRequetes()
        {
            cb_requete.Items.Add("requete0: nom des employés");
            lesRequetes.Add(requete0);
            cb_requete.Items.Add("requete1: nom et prénom des employés");
            lesRequetes.Add(requete1);
            cb_requete.Items.Add("requete2: service des employés");
            lesRequetes.Add(requete2);
            cb_requete.Items.Add("requete3: Employés des services");
            lesRequetes.Add(requete3);
            cb_requete.Items.Add("requete4: nom et services des employés avec un type anonyme");
            lesRequetes.Add(requete4);
            cb_requete.Items.Add("requete5: les hommes");
            lesRequetes.Add(requete5);
            cb_requete.Items.Add("requete6: les hommes qui gagnent plus de 3000€");
            lesRequetes.Add(requete6);
            cb_requete.Items.Add("requete7: Employés du service commercial");
            lesRequetes.Add(requete7);
            cb_requete.Items.Add("requete8: Employés cadres");
            lesRequetes.Add(requete8);
            cb_requete.Items.Add("requete9: Employés dont le nom contient 'du'");
            lesRequetes.Add(requete9);
            cb_requete.Items.Add("requete10: Employés travaillant dans un atelier");
            lesRequetes.Add(requete10);
            //cb_requete.Items.Add("requete11: services productifs");
            //lesRequetes.Add(requete11);
            cb_requete.Items.Add("requete12: employés musculins triés par nom");
            lesRequetes.Add(requete12);
            cb_requete.Items.Add("requete13: employés triés par longueur de prénom");
            lesRequetes.Add(requete13);
            cb_requete.Items.Add("requete14: employés triés par sexe et prénom");
            lesRequetes.Add(requete14);
            cb_requete.Items.Add("requete15: employés d'employés");
            lesRequetes.Add(requete15);
            cb_requete.Items.Add("requete16: nombre de cadres");
            lesRequetes.Add(requete16);
            cb_requete.Items.Add("requete17: salaire maximum,plus petit nom et salaire moyen");
            lesRequetes.Add(requete17);
            cb_requete.Items.Add("requete18: masse salariale des cadres");
            lesRequetes.Add(requete18);
            cb_requete.Items.Add("requete19: effectif par diplome");
            lesRequetes.Add(requete19);
            cb_requete.Items.Add("requete20: jointure employé-service");
            lesRequetes.Add(requete20);
            cb_requete.Items.Add("requete21: jointure employé-service avec sélection");
            lesRequetes.Add(requete21);
            cb_requete.Items.Add("requete22: jointure employés-diplome");
            lesRequetes.Add(requete22);
            cb_requete.Items.Add("requete23: jointure employé-diplome avec sélection");
            lesRequetes.Add(requete23);
            cb_requete.Items.Add("requete24: effectif des services");
            lesRequetes.Add(requete24);
            cb_requete.Items.Add("requete25: salaire moyen des services");
            lesRequetes.Add(requete25);
            cb_requete.Items.Add("requete26: salaire moyen par service et statut");
            lesRequetes.Add(requete26);
            /*cb_requete.Items.Add("requete26 V2");
            lesRequetes.Add(requete26V2);*/
            cb_requete.Items.Add("requete27: salaire maximum des employés masculins par service employant plus d'un homme");
            lesRequetes.Add(requete27);
            cb_requete.Items.Add("requete28: employés gagnant plus que l'employé numéro 1");
            lesRequetes.Add(requete28);
            cb_requete.Items.Add("requete29: employés gagnant plus que l'employé numéro 1 v2");
            lesRequetes.Add(requete29);
            cb_requete.Items.Add("requete29 V2");
            lesRequetes.Add(requete29V2);
            cb_requete.Items.Add("requete30: employés gagant plus que la moyenne des salaires du service numéro 1");
            lesRequetes.Add(requete30);
            cb_requete.Items.Add("requete31: employés gagant plus que la moyenne des salaires du service numéro 1 v2");
            lesRequetes.Add(requete31);
            cb_requete.Items.Add("requete32: employés gagant plus que la moyenne des salaires de leur service");
            lesRequetes.Add(requete32);
            cb_requete.Items.Add("requete33: services employants des salariés non diplomés");
            lesRequetes.Add(requete33);
            cb_requete.Items.Add("requete34: services et employés,affichage des diplomes pour les cadres d'uns ervice administratif");
            lesRequetes.Add(requete34);
            cb_requete.Items.Add("requete35: effectid des services,version group join");
            lesRequetes.Add(requete35);
            //cb_requete.Items.Add("requete36: employés masculins d'un service productif");
            //lesRequetes.Add(requete36);
            cb_requete.Items.Add("requete37: employés gagnt plus que l'employé 1,enchainement de requêtes");
            lesRequetes.Add(requete37);
            /*cb_requete.Items.Add("requete38: employés de sexe féminin ou travaillant dans un atelier");
            lesRequetes.Add(requete38);*/
        }

        private void requete0()
        {
            //tb_resultat.AppendText("requête 0: nom des employés");
            var req = from emp in bd.employes
                      select emp.emp_nom;
            foreach (string s in req)
            {
                tb_resultat.AppendText(s);
                tb_resultat.AppendText(Environment.NewLine); 
            }
        }

        private void requete1()
        {
            //tb_resultat.AppendText("requête 1: nom et prénom des employés");
            var req = from emp in bd.employes
                      select emp;

            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " "+ e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete2()
        {
            var req = from emp in bd.employes
                      select emp.service;

            foreach (service s in req.Distinct())
            {
                tb_resultat.AppendText(s.ser_designation);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        private void requete3()
        {
            var req = from emp in bd.employes.Include("service")
                      select emp;

            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " "+e.service.ser_designation);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete4()
        {
            var req = from emp in bd.employes
                      select new { LeNom = emp.emp_nom,LaDesignation = emp.service.ser_designation };

            foreach (var res in req)
            {
                tb_resultat.AppendText(res.LeNom + " " + res.LaDesignation);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete5()
        {
            var req = from emp in bd.employes
                      where emp.emp_sexe == "M"
                      select emp;

            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete6()
        {
            var req = from emp in bd.employes
                      where (emp.emp_sexe) == "M" && (emp.emp_salaire > 3000)
                      select emp;

            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom + " " + e.emp_salaire.ToString() + "€");
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete7()
        {
            var req = from emp in bd.employes
                      where emp.service.ser_designation == "Commercial"
                      select emp;

            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete8()
        {
            var req = from emp in bd.employes
                      where emp.emp_cadre.Value
                      select emp;

            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete9()
        {
            var req = from emp in bd.employes
                      where emp.emp_nom.Contains("du")
                      select emp;

            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete10()
        {
            var req = from emp in bd.employes
                      where emp.service.ser_designation.StartsWith("Atelier")
                      select emp;

            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        /*  private void requete11()
        {

            var req =
             
                
                select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        */

        private void requete12()
        {

            var req =
                from emp in bd.employes
                where emp.emp_sexe == "M"
                orderby emp.emp_nom ascending
                select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_sexe + " " + e.emp_nom + " " + e.emp_nom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }


        private void requete13()
        {

            var req =
                from emp in bd.employes
                orderby emp.emp_prenom.Length ascending

                select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_nom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete14()
        {

            var req =
                from emp in bd.employes
                orderby emp.emp_sexe ascending, emp.emp_prenom descending

                select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_sexe + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }


        private void requete15()
        {
            int nb = bd.employes.Count();
            tb_resultat.AppendText("nombre d'employés : " + nb.ToString());
            tb_resultat.AppendText(Environment.NewLine);
        }

        private void requete16()
        {
            int nb = bd.employes.Count(emp => emp.emp_cadre == true);
            tb_resultat.AppendText("nombre de cadre : " + nb.ToString());
            tb_resultat.AppendText(Environment.NewLine);
        }

        private void requete17()
        {
            decimal maxSalaire = (decimal)bd.employes.Max(emp => emp.emp_salaire);

            tb_resultat.AppendText("salaire maximum  : " + maxSalaire.ToString());
            tb_resultat.AppendText(Environment.NewLine);
            string minNom = bd.employes.Min(emp => emp.emp_nom);
            tb_resultat.AppendText("plus Petit nom  : " + minNom);
            tb_resultat.AppendText(Environment.NewLine);
            decimal avgSalaire = (decimal)bd.employes.Average(emp => emp.emp_salaire);
            tb_resultat.AppendText("salaire moyen : " + avgSalaire.ToString());
            tb_resultat.AppendText(Environment.NewLine);
        }
        public void requete18()
        {

            decimal maxSalaire = (decimal)(bd.employes.Where(emp => emp.emp_cadre == true).Sum(emp => emp.emp_salaire));
            tb_resultat.AppendText("masse salariale des cadres : " + maxSalaire.ToString());
            tb_resultat.AppendText(Environment.NewLine);
        }


        public void requete19()
        {
            var req =
                from dip in bd.diplomes
                select new { LeDiplome = dip, Effectif = dip.employes.Count };
            foreach (var res in req)
            {
                tb_resultat.AppendText(res.LeDiplome.dip_libelle + " : " + res.Effectif.ToString());
            }
        }
        private void requete20()
        {
            var req =
                from emp in bd.employes
                from sce in bd.services
                where emp.service == sce || emp.service == null
                select new { LeEmploye = emp, LeService = emp.service };
            foreach (var res in req.Distinct())
            {
                if (res.LeService != null)
                {

                    tb_resultat.AppendText(res.LeEmploye.emp_nom + " " + res.LeService.ser_designation);
                }
                else
                {
                    tb_resultat.AppendText(res.LeEmploye.emp_nom + "non affecté");
                }
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        private void requete21()
        {
            var req =
                from emp in bd.employes
                from sce in bd.services
                where sce == emp.service
                select new { LeService = sce, LeEmploye = emp };
            foreach (var res in req)
            {
                tb_resultat.AppendText(res.LeEmploye.emp_nom + " " + res.LeService.ser_designation);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        public void requete22()
        {
            var req =
                 from emp in bd.employes
                 from dip in emp.diplomes
                 orderby emp.emp_nom ascending
                 select new { leEmploye = emp, LeDiplome = dip };
            foreach (var res in req)
            {
                tb_resultat.AppendText(res.leEmploye.emp_nom + " " + res.LeDiplome.dip_libelle);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }



        public void requete23()
        {
            var req =
                from dip in bd.diplomes
                where dip.dip_libelle == "Bts"//cdt sur le diplome
                from emp in dip.employes
                where emp.emp_nom.StartsWith("du") // cdt sur l'employé
                select new { leEmploye = emp, leDiplome = dip };
            foreach (var res in req)
            {
                tb_resultat.AppendText(res.leEmploye.emp_nom + " " + res.leDiplome.dip_libelle);
                tb_resultat.AppendText(Environment.NewLine);

            }

        }

        public void requete24()
        {
            var req =
                from emp in bd.employes
                group emp by emp.service into groupeService
                select new { DesServices = groupeService.Key.ser_designation, nb = groupeService.Count() };
            foreach (var res in req)
            {

                tb_resultat.AppendText(res.DesServices + " : " + res.nb.ToString() + " employés");
                tb_resultat.AppendText(Environment.NewLine);
            }
        }
        public void requete25()
        {
            var req =
                from emp in bd.employes
                group emp by emp.service into groupeService
                select new
                {
                    DesService = groupeService.Key.ser_designation,
                    SalaireMoyen = groupeService.Average(emp2 => emp2.emp_salaire)
                };
            foreach (var res in req)
            {

                tb_resultat.AppendText(res.DesService + " : " + res.SalaireMoyen.ToString());
                tb_resultat.AppendText(Environment.NewLine);

            }
        }

        public void requete26()
        {

            var req =
                from emp in bd.employes
                group emp by new { LeService = emp.service, LeStatut = emp.emp_cadre } into groupe
                select new
                {
                    DesService = groupe.Key.LeService.ser_designation,
                    Statut = groupe.Key.LeStatut,
                    SalaireMoyen = groupe.Average(emp2 => emp2.emp_salaire)
                };
            foreach (var res in req)
            {

                tb_resultat.AppendText(res.DesService + "  , " + res.Statut.ToString() + " : " + res.SalaireMoyen.ToString());
                tb_resultat.AppendText(Environment.NewLine);
            }

        }
        /*public void requete26V2()
        {
            var req =
                from emp in bd.employes
                group emp by emp.service into groupeService
                select new
                {
                    DesServices = groupeService.Key.ser_designation,
                    GroupeStatut =
                    from emp2 in groupeService.Key.employes
                    group emp2 by emp2.emp_cadre into groupeCadre
                    select new
                    {
                        Statut = groupeCadre.Key,
                        SalaireMoyen = groupeCadre.Average(emp3 => emp3.emp_salaire)
                    }
                };
            foreach (var res in req)
            {
                tb_resultat.AppendText(res.DesServices + " : " + Environment.NewLine);
                foreach (var resStatut in res.GroupeStatut)
                {
                    tb_resultat.AppendText(resStatut.Statut.ToString() + " : " + resStatut.SalaireMoyen.ToString());
                    tb_resultat.AppendText(Environment.NewLine);
                }
                tb_resultat.AppendText(Environment.NewLine);
            }
        }*/

        public void requete27()
        {


            var req =
                from emp in bd.employes
                where emp.emp_sexe == "M"
                group emp by emp.service into groupeService
                where groupeService.Count() >= 2
                select new
                {

                    DesService = groupeService.Key.ser_designation,
                    SalaireMaximum = groupeService.Max(emp2 => emp2.emp_salaire)
                };
            foreach (var res in req)
            {
                tb_resultat.AppendText(res.DesService + " :" + res.SalaireMaximum.ToString());
                tb_resultat.AppendText(Environment.NewLine);
            }
        }


        public void requete28()
        {
            var req =
                from emp in bd.employes
                where emp.emp_salaire > (from empRef in bd.employes where empRef.emp_id == 1 select empRef.emp_salaire).FirstOrDefault()
                select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom + " " + e.emp_salaire.ToString());
                tb_resultat.AppendText(Environment.NewLine);
            }
        }



        public void requete29()
        {

            var req =
                from emp in bd.employes
                where emp.emp_salaire > bd.employes.FirstOrDefault(emp2 => emp2.emp_id == 1).emp_salaire
                select emp;
            foreach (var res in req)
            {
                tb_resultat.AppendText(res.emp_nom + " " + res.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }

        }

        private void requete29V2()
        {
            var req =
                from empRef in bd.employes
                where empRef.emp_id == 1
                from emp in bd.employes
                where emp.emp_salaire > empRef.emp_salaire
                select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        public void requete30()
        {
            var req =
                from emp in bd.employes
                where emp.emp_salaire > (from ser in bd.services
                                         where ser.ser_id == 1
                                         select ser.employes.Average(emp2 => emp2.emp_salaire)).FirstOrDefault()
                select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        public void requete31()
        {
            var req = from sce in bd.services
                      where sce.ser_id == 1
                      from emp in bd.employes
                      where emp.emp_salaire > sce.employes.Average(emp2 => emp2.emp_salaire)
                      select emp;
            foreach (employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        public void requete32()
        {
            var req = from emp in bd.employes
                      where emp.emp_salaire > emp.service.employes.Average(emp2 => emp2.emp_salaire)
                      select emp;
            foreach(employe e in req)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }

        }

        public void requete33()
        {
            var req = from emp in bd.employes
                      where emp.diplomes.Count == 0
                      select emp.service;
            foreach (service s in req)
            {
                tb_resultat.AppendText(s.ser_designation);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        public void requete34()
        {
            var req = from sce in bd.services.Include("employes")
                      select sce;
            foreach (service s in req.ToList())
            {
                tb_resultat.AppendText(s.ser_designation);
                tb_resultat.AppendText(Environment.NewLine);

                if (!s.employes.IsLoaded)
                {
                    s.employes.Load();
                }
                foreach (employe e in s.employes)
                {
                    tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                    tb_resultat.AppendText(Environment.NewLine);
                }
            }
        }

        public void requete35()
        {
            var req = from sce in bd.services
            join emp in bd.employes on sce equals emp.service into LesSalaries
            select new { LeService = sce, LesAffectes = LesSalaries };

            foreach (var res in req)
            {
                tb_resultat.AppendText(res.LeService.ser_designation + ":" + res.LesAffectes.Count() + " employés");
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        /*public void requete36()
        {
            var req1 = from emp in bd.employes
                       join sce in bd.services.OfType<SceProductif>() on emp.service
                       equals sce
                       select emp;
            var req2 = from emp in req1
                       where emp.emp_sexe == "M"
                       select emp;
            foreach(employe e in req2)
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }*/

        public void requete37()
        {
            var req1 = from emp in bd.employes
                       where emp.emp_id == 1
                       select emp.emp_salaire;
            var req2 = from emp2 in bd.employes
                       where emp2.emp_salaire > req1.FirstOrDefault()
                       select emp2;
            foreach (employe e in req2)
            {
                tb_resultat.AppendText(e.emp_nom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }

        /*public void requete38()
        {
            var req1 = from emp in bd.employes
                       where emp.emp_sexe == "F"
                       select emp;
            var req2 = from emp in bd.employes
                       join sce in bd.services on emp.service equals sce
                       where sce.ser_designation.StartsWith("Atelier")
                       select emp;
            foreach (employe e in req1.Union(req2))
            {
                tb_resultat.AppendText(e.emp_nom + " " + e.emp_prenom);
                tb_resultat.AppendText(Environment.NewLine);
            }
        }*/


        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cb_requete.SelectedIndex != -1)
            {
                tb_resultat.Clear();
                lesRequetes[cb_requete.SelectedIndex]();
            }
        }
    }
}
