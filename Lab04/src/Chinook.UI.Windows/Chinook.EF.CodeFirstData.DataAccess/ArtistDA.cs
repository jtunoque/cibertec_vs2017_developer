using Chinook.EF.CodeFirstData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.EF.CodeFirstData.DataAccess
{
    public class ArtistDA
    {
        private ChinookModel _context;

        public ArtistDA()
        {
            _context = new ChinookModel();
        }
       
        /// <summary>
        /// Obtiene la cantidad de registros
        /// </summary>
        /// <returns>Retorna un número entero</returns>
        public int Count()
        {
            //Utilizando Linq para obtener la 
            //cantidad de registros
            return _context.Artist.Count();
        }

        /// <summary>
        /// Permite obtener los datos de un artista
        /// </summary>
        /// <param name="id">Parámetro de tipo entero que representa el código del artista</param>
        /// <returns>Retorna toda la información del artista</returns>
        public Artist GetArtistById(int id)
        {
            return _context.Artist.Find(id);
        }

        /// <summary>
        /// Obtiene el listado de artistas filtrado por nombre
        /// </summary>
        /// <param name="filtroByName">Filtro por nombre</param>
        /// <returns>Retorna lista de artistas</returns>
        public IEnumerable<Artist> GetArtists(string filtroByName)
        {
            return _context.Artist
                .Where(item=>item.Name.Contains(filtroByName)).ToList();
        }

        public int InsertArtist(Artist artist)
        {
            _context.Artist.Add(artist);
            _context.SaveChanges();

            return artist.ArtistId;
        }

        public bool UpdateArtist(Artist artist)
        {
            _context.Artist.Attach(artist);
            _context.Entry(artist).State 
                    = System.Data.Entity.EntityState.Modified;
           
            return _context.SaveChanges()>0;
        }

        public bool DeleteArtist(Artist artist)
        {
            _context.Artist.Attach(artist);
            _context.Artist.Remove(artist);

            return _context.SaveChanges() > 0;
        }

    }
}
