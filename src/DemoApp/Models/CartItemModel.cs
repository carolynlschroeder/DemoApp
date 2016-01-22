using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class CartItemModel
    {
        [Display(Name = "Album ID")]
        public Guid AlbumId { get; set; }
        public int Quantity { get; set; }
    }
}
