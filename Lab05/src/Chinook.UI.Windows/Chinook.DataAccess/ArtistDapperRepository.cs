using Chinook.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Chinook.DataAccess
{
    public class ArtistDapperRepository:DataBase
    {
        public List<Artist> GetArtists(
            string nombre
            )
        {
            var artists = new List<Artist>();

            /*1. Creando un objeto connection*/
            using (var connection = this.CreateConnection())
            {
                /* 2. - Creando un objeto Command*/
                var query = "SELECT Name, ArtistId FROM Artist WHERE Name LIKE @FiltroByName ";

                artists = connection
                            .Query<Artist>(query, new { FiltroByName = nombre }).ToList();                
            }

            return artists;
        }


        public List<Artist> GetArtistsWithSP(
           string nombre
           )
        {
            var artists = new List<Artist>();

            /*1. Creando un objeto connection*/
            using (var connection = CreateConnection())
            {
                /* 2. - Creando un objeto Command*/
                var query = "usp_GetArtists";

                artists = connection
                    .Query<Artist>(query
                            , new { FiltroByName = nombre},
                            commandType
                                : CommandType.StoredProcedure).ToList();     
                
            }

            return artists;
        }

        public int InsertArtist(Artist artist)
        {
            int result = 0;


            using (var connection = this.CreateConnection())
            {
                result = connection.Query<int>("usp_InsertArtist",
                                new {Name = artist.Name },
                                commandType:CommandType.StoredProcedure
                                ).SingleOrDefault();

            }


            return result;
        }

        public bool DeleteArtist(int id)
        {
            bool result = false;


            using (var connection = this.CreateConnection())
            {
                //El metodos execute ejecuta el comando en la
                //DB y me devuelve la cantidad de registros
                //que fueron afectado en la ejecución
                //de ese comando
                result = connection.Execute("usp_DeleteArtist",
                                new { Id = id },
                                commandType: CommandType.StoredProcedure
                                )>0;
            }

            return result;
        }

        //Insertar artista dentro de un bloque de transacción
        public int InsertArtistTX(Artist artist)
        {
            int result = 0;


            using (var connection = this.CreateConnection())
            {
                connection.Open();

                var tx = connection.BeginTransaction();

                try
                {
                    result = connection.Query<int>("usp_InsertArtist",
                                    new { Name = artist.Name },
                                    commandType: CommandType.StoredProcedure,
                                    transaction: tx
                                    ).SingleOrDefault();

                    tx.Commit();
                }
                catch(Exception ex)
                {
                    tx.Rollback();
                }

            }


            return result;
        }
    }
}
