using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_6.DAL
{
    public interface IEntity
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }
    }
}
