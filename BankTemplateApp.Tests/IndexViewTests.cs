using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using ASP;
using BankTemplateApp.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorGenerator.Testing;

namespace BankTemplateApp.Tests
{
    /// <summary>
    /// Summary description for IndexViewTests
    /// </summary>
    [TestClass]
    public class IndexViewTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var view = new _Views_Home_Index_cshtml();

            var records = ClientRecords.CreateRecords(
                new List<ClientRecord>
                {
                    ClientRecord.CreateNewRecord("record 1", "address 1"),
                    ClientRecord.CreateNewRecord("record 2", "address 2"),
                    ClientRecord.CreateNewRecord("record 3", "address 3")
                });

            view.ViewData.Model = records;
            
           var html = view.RenderAsHtml(records);

            var recordsContainer = html.GetElementbyId("records-container");

            Assert.AreEqual("record 1",
                recordsContainer.SelectSingleNode("//div[@class='record']/h1/text()").InnerText.Trim());

            Assert.AreEqual("address 1",
                recordsContainer.SelectSingleNode("//div[@class='record']/address/text()").InnerText.Trim());



        }
    }
}
