using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace RequestPortalDemo.Models
{
    public class RequestFormVM
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Manager { get; set; }
        public string Other { get; set; }
        public List<SelectListItem> TypeList {
            get {
                return new List<SelectListItem>(){
                    new SelectListItem{Text="A",Value="A"},
                    new SelectListItem{Text="B",Value="B"},
                    new SelectListItem{Text="C",Value="C"}
                    };
                } 
        }
        public string Type { get; set; }
        public bool IsContractor { get; set; }
        public List<SelectListItem> ContractList { get; set; }
        public string ContractCompany { get; set; }

    }
}