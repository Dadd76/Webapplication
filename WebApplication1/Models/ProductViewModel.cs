using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.ViewModels
{
    public class ProductViewModel
    {

        [Display(Name = "Category Rule")]
        public int SelectedUserRoleId { get; set; }
        public IEnumerable<SelectListItem> CategoryRoles { get; set; }
    }
}