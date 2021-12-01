using NUnit.Framework;
using System.Collections.Generic;
using XsdToRi_BaSEPA.Core.Models;
using XsdToRi_BaSEPA.Core.Services;

namespace XsdToRi_BaSEPA.Core.Tests
{
    public class ExcelServiceTests
    {
        ExcelService excelService;

        [SetUp]
        public void Setup()
        {
            excelService = new();
        }

        [Test]
        public void ShouldReadExcelFileFromPathAndMappToCustomExcelModel()
        {
            //Given
            string path = @"C:\Users\serge\OneDrive\Escritorio\FwdRIBAITALIA\Simulation.xlsx";
            //When
            var collection = excelService.Execute(path,0);
            //Then
            Assert.IsInstanceOf<IEnumerable<CustomExcelModel>>(collection);
        }
    }
}