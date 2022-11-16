using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Librarynew.Models
{
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(PublisherMetaData))]
    public partial class Publisher
    {
        public class PublisherMetaData
        {
            [DisplayName("Publisher Name")]

            public string name { get; set; }

            [DisplayName("Address")]

            public string address { get; set; }

            [DisplayName("Phone")]

            public string phone { get; set; }
        }
    }
}