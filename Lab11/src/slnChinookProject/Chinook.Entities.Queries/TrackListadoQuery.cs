using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Entities.Queries
{
    public class TrackListadoQuery
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public int MediaTypeId { get; set; }
        public string MediaTypeName { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int bytes { get; set; }
        public double UnitPrice { get; set; }
    }
}
