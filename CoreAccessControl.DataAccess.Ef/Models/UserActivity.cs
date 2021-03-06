﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreAccessControl.DataAccess.Ef.Models
{
    public partial class UserActivity
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        [Required]
        [StringLength(250)]
        public string ActivityText { get; set; }
        public long LocationId { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime ActivityTime { get; set; }

        [ForeignKey(nameof(LocationId))]
        [InverseProperty("UserActivity")]
        public virtual Location Location { get; set; }
    }
}