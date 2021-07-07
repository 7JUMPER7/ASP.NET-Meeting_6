using Meeting_6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_6.Models
{
    public class News : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}