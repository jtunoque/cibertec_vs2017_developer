using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Entities.Queries
{
    [DataContract]
    public class AlbunesVendidosQuery
    {
        [DataMember]
        public string PlaylistName { get; set; }
        [DataMember]
        public string TrackName { get; set; }
        [DataMember]
        public string AlbumName { get; set; }
        [DataMember]
        public string ArtistName { get; set; }
        [DataMember]
        public int TotalQuantity { get; set; }
    }
}
