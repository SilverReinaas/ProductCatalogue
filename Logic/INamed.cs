using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface INamed
    {
        string Id { get; set; }
        string Name { get; set; }
    }
}
