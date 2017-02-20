using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductCategory : INamed , ITimeLimited
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Period Valid { get; set; }
    }
}
