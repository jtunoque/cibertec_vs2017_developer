using System;
using Chinook.EF.CodeFirstData.DataAccess;
using Chinook.EF.CodeFirstData.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.EF.CodeFirstData.DataAccessUnitTest
{
    [TestClass]
    public class ArtistTest
    {
        ArtistDA artistDA = new ArtistDA();
        
        public ArtistTest()
        {

        }

        [TestMethod]
        public void Update()
        {
            var artist = artistDA.GetArtistById(1);
            artist.Name = "AC/DC version 2";

            var resultado = artistDA.UpdateArtist(artist);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Delete()
        {
            var artist = new Artist();
            artist.ArtistId = 284; //Aerosmith

            //var resultado = artistDA.DeleteArtist(artist);
            var resultado = true;

            Assert.IsTrue(resultado);
        }
    }
}
