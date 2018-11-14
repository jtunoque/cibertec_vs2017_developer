using Chinook.DataAccess.Repository.Interfaces;
using Chinook.Entities.Base;
using Chinook.Entities.Queries;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class TrackRepository :
        GenericRepository<Track>,ITrackRepository
    {
        public TrackRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<TrackListadoQuery> GetSearchTrack(string trackName)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@trackName";
            if(String.IsNullOrWhiteSpace(trackName))
            {
                param1.Value = DBNull.Value;
            }
            else
            {
                param1.Value = trackName;
            }


            return this.context.Database.SqlQuery<TrackListadoQuery>
                ("usp_GetTracks @trackName", param1).ToList();
        }
    }
}
