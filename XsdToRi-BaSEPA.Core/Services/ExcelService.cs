using Npoi.Mapper;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XsdToRi_BaSEPA.Core.Models;

namespace XsdToRi_BaSEPA.Core.Services
{
    public class ExcelService
    {
        public List<CustomExcelModel> Execute(string localPath, int sheetIndex)
        {
            IWorkbook workbook;
            using (FileStream file = new FileStream(localPath, FileMode.Open, FileAccess.Read))
            {
                workbook = WorkbookFactory.Create(file);
            }

            var importer = new Mapper(workbook);
            var items = importer.Take<CustomExcelModel>(sheetIndex);
            List<CustomExcelModel> response = new();
            items.ForEach(x =>
            {
                response.Add
                (
                new CustomExcelModel()
                     {
                        Adresse1 = x.Value.Adresse1,
                        CodeVendeur = x.Value.CodeVendeur,
                        NAcheteur = x.Value.NAcheteur,
                        NFacture = x.Value.NFacture,
                        Date = x.Value.Date,
                        Echeance = x.Value.Echeance,
                        Solde = x.Value.Solde,
                        Moyen = x.Value.Moyen,
                        Enseigne = x.Value.Enseigne,
                        Codepostal = x.Value.Codepostal,
                        Ville = x.Value.Ville,
                        Banque = x.Value.Banque,
                        CodeBanque = x.Value.CodeBanque,
                        CodeGuichet = x.Value.CodeGuichet,
                        NCompte = x.Value.NCompte,
                        CleRIB = x.Value.CleRIB,
                        NTVA = x.Value.NTVA
                     }
                );
            }
            );
            return response;
        }
    }
}
