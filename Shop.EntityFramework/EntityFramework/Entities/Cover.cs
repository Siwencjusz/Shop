﻿using System.ComponentModel.DataAnnotations;
using Shop.EntityFramework.Entities.Base;

namespace Shop.EntityFramework.Entities
{
    public class Cover: BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
