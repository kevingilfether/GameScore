using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameScore.Models
{
    public class Score
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        //Added later to MVC -- will break wbsite upon launch 
        //because "Team" is not in model?
        public string Team { get; set; }
    }
}