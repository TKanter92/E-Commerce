﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        public string Body { get; set; }

        public int Rating { get; set; }

        [ForeignKey("Product")]

        public int ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey("User")]

        public string UserId { get; set; }

        public Customer User { get; set; }




    }
}
