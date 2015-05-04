using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequestPortalDemo.Domain
{
    public class Requestor
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Manager { get; set; }
        public string Other { get; set; }
    }
}