using System;
using System.ComponentModel.DataAnnotations;

namespace TechBlog.Models
{
    public class Post
    {
        public virtual int Id
        { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public virtual string Title
        { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 1)]
        public virtual string Text
        { get; set; }

        public virtual bool IsPublished
        { get; set; }

        public virtual DateTime PostedOn
        { get; set; }

        public virtual DateTime? Modified
        { get; set; }
    }
}