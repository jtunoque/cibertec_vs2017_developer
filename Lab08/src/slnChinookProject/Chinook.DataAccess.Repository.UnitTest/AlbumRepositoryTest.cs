
using System;
using System.Data.Entity;
using Chinook.DataAccess.Repository.Interfaces;
using Chinook.Entities.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Chinook.DataAccess.Repository.UnitTest
{
    [TestClass]
    public class AlbumRepositoryTest
    {
        private readonly DbContext dbContext;
        private readonly IUnitOfWork unitOfWork;

        public AlbumRepositoryTest()
        {
            dbContext = new ChinookDBModel();
            unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void GetCount()
        {
            var listado = unitOfWork
                .AlbumRepository.GetAlbunesVendidos();

            unitOfWork.Dispose();

            Assert.IsTrue(listado.Count()>0,"OK");

        }

       
    }
}
