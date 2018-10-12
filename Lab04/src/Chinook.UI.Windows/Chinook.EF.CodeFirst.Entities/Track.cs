

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.EF.CodeFirst.Entities
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<PlaylistTrack> PlaylistTrack { get; set; }


    }
}
