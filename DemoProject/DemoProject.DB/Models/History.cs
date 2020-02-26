using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject.DB.Models
{
    class History
    {
        public History()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public decimal Amoung { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public DateTime date { get; set; }
    }
}
