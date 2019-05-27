using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcpractice1.Models
{
    public class NewUser
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public NewUser()
        {

        }

    }
}