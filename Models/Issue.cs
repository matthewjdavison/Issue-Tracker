﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.MVC.Models
{
    public class Issue
    {
        [Required]
        public int ProjectId { get; set; } //Id of the project this belongs too
        [Required]        
        public int IssueId { get; set; }
        
        [Required]        
        public Guid UserId { get; set; } //ID of issue author
        [Required]
        public string Title { get; set; }
        [Required]
        public string Comment { get; set; }

        
        [Required]
        public string AuthorUserName { get; set; }
        
        [Required]
        public DateTime PostDate { get; set; }
        [Required]
        public bool IsOpen { get; set; }
    }
}
