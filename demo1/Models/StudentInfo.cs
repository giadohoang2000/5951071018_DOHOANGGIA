using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace demo1.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Lop")]
        public string Lop { get; set; }
        [DataMember(Name = "NamSinh")]
        public string NamSinh { get; set; }
    }
}