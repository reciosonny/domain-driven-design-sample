using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleWebApp.Domain.Core {
    public class TblPermits {

        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Desc { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string Contractor { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }


    }
}