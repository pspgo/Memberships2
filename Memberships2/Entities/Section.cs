using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships2.Entities
{
    [Table("Section")]
    public class Section
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //if its databasegenerated its PK and its already req
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
    }
}