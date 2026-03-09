using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    //KONULAR
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(2000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

       public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }


    }
}
