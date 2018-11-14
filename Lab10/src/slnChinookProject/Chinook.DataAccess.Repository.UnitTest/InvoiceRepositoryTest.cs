
using System;
using System.Data.Entity;
using Chinook.DataAccess.Repository.Interfaces;
using Chinook.Entities.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Chinook.DataAccess.Repository.UnitTest
{
    [TestClass]
    public class InvoiceRepositoryTest
    {
        private readonly DbContext dbContext;
        private readonly IUnitOfWork unitOfWork;

        public InvoiceRepositoryTest()
        {
            dbContext = new ChinookDBModel();
            unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void Add()
        {
            var invoice = new Invoice();
            invoice.CustomerId = 1;
            invoice.InvoiceDate = DateTime.Now;
            invoice.BillingAddress = "Remigio Silva 510";
            invoice.BillingCity = "Jesús María";
            invoice.BillingState = "Lima";
            invoice.BillingCountry = "Perú";
            invoice.BillingPostalCode = "Lima 32";
            //Agregando items
            invoice.InvoiceLine = new List<InvoiceLine>();
            //Item 1
            invoice.InvoiceLine.Add(
                new InvoiceLine()
                {                    
                    TrackId= 1,
                    Quantity = 2,
                    UnitPrice = 10                    
                }
                );

            //Item 2
            invoice.InvoiceLine.Add(
                new InvoiceLine()
                {
                    TrackId = 2,
                    Quantity = 3,
                    UnitPrice = 50
                }
                );

            //Sumando los totales
            invoice.Total =  invoice
                        .InvoiceLine.Sum(item=>item.UnitPrice*item.Quantity);


            unitOfWork
                .InvoiceRepository.Add(invoice);

            unitOfWork.Complete();
            unitOfWork.Dispose();

            Assert.IsTrue(invoice.InvoiceId>0,"OK");

        }

       
    }
}
