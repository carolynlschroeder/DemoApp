using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class AlbumModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Artist { get; set; }
        public int Quantity { get; set; }
    }
}
