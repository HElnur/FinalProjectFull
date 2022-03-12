﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.ViewModels
{
    public class MemberUpdateViewModel
    {
        [Required]
        [StringLength(maximumLength:20)]
        public string FullName { get; set; }
        [Required]
        [StringLength(maximumLength:20)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength:100)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [StringLength(maximumLength:25,MinimumLength =8)]
        public string Password { get; set; }
        [DataType(DataType.Password),Compare(nameof(Password))]
        [StringLength(maximumLength:25,MinimumLength =8)]
        public string RepeatPassword { get; set; }
        [DataType(DataType.Password)]
        [StringLength(maximumLength:25,MinimumLength =8)]
        public string CurrentPassword { get; set; }

    }
}
