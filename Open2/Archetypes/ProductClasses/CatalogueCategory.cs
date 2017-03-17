using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class CatalogueCategory : UniqueEntity
    {
        private string name;

        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

    }
}
