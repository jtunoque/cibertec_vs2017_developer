using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.EF.CodeFirst.Entities
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
