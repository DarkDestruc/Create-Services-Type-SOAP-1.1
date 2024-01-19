using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAP_1._1.Models
{
    [DataContract]
    public class Fruit
    {
            [DataMember]
            public string NameFruit { get; set; }


            [DataMember]
            public string ColorFruit { get; set; }
             public object Name { get; internal set; }
    }
}