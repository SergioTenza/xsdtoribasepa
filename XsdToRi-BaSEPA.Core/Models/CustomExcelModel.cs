using Npoi.Mapper.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XsdToRi_BaSEPA.Core.Models
{
    public class CustomExcelModel
    {

        /*
         * Code Vendeur	
         * N° Acheteur	
         * N° Facture	
         * Date	
         * Echéance	 
         * Solde	
         * Moyen	
         * Enseigne	
         * Code postal	
         * Ville	
         * Banque	
         * Code Banque	
         * Code Guichet	
         * N Compte	
         * Cle RIB	
         * Adresse 1	
         * N° TVA
         */
        [Column("Code Vendeur")]
        public int CodeVendeur { get; set; }

        [Column("N° Acheteur")]
        public string NAcheteur { get; set; }

        [Column("N° Facture")]
        public int NFacture { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Echéance")]
        public DateTime Echeance { get; set; }

        [Column("Solde")]
        public decimal Solde { get; set; }

        [Column("Moyen")]
        public string Moyen { get; set; }

        [Column("Enseigne")]
        public string Enseigne { get; set; }

        [Column("Code postal")]
        public int Codepostal { get; set; }

        [Column("Ville")]
        public string Ville { get; set; }

        [Column("Banque")]
        public string Banque { get; set; }

        [Column("Code Banque")]
        public int CodeBanque { get; set; }

        [Column("Code Guichet")]
        public int CodeGuichet { get; set; }

        [Column("N Compte")]
        public string NCompte { get; set; }

        [Column("Cle RIB")]
        public string CleRIB { get; set; }

        [Column("Adresse 1")]
        public string Adresse1 { get; set; }

        [Column("N° TVA")]
        public int NTVA { get; set; }
    }
}
