using System;
using Chinook.EF.CodeFirstData.DataAccess;
using Chinook.EF.CodeFirstData.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.EF.CodeFirstData.DataAccessUnitTest
{
    [TestClass]
    public class CustomerTest
    {
        CustomerDA customerDA = new CustomerDA();

        [TestMethod]
        public void UpdateContacto()
        {
            var customer = new Customer();
            customer.CustomerId = 1;
            customer.Phone = "012635126";
            customer.Email = "javertuga@gmail.com";
            var resultado = customerDA
                    .UpdateContactos(customer);

            Assert.IsFalse(resultado
                ,"Actualizó correctamente");
        }

        [TestMethod]
        public void UpdateContacto2()
        {
            var customer = new Customer();
            customer.CustomerId = 1;
            customer.Phone = "012635126";
            customer.Email = "javertuga@gmail.com";
            var resultado = customerDA
                    .UpdateContactos2(customer);

            Assert.IsTrue(resultado
                , "Actualizó correctamente");
        }
    }
}
