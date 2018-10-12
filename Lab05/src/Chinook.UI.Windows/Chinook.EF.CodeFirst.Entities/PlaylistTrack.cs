﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.EF.CodeFirst.Entities
{
    public class PlaylistTrack
    {
        [Key]
        [Column(Order = 0)]
        public int PlaylistId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int TrackId { get; set; }

        public virtual Playlist Playlist { get; set; }

        public virtual Track Track { get; set; }


    }
}
