using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{ //YAZARLAR
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurname { get; set; }

        [StringLength(400)]
        public string Writerİmage { get; set; }

        [StringLength(200)]
        public string WriterEmail { get; set; }

        [StringLength(30)]
        public string WriterPassword { get; set; }
        // public DateTime WriterDate { get; set; }
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Content { get; set; }
    }
}
