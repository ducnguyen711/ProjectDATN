﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WatchStore.Web.Areas.Admin.Models.Role
{
    public class CreateRoleModel
    {
        [Display(Name = "Tên của role")]
        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(256, MinimumLength = 3, ErrorMessage = "{0} phải dài {2} đến {1} ký tự")]
        public string Name { get; set; }
    }
}
