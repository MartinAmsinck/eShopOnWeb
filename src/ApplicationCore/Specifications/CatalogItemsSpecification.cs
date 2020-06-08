using Effektiv.ApplicationCore.Entities;
using System;
using System.Linq;

namespace Effektiv.ApplicationCore.Specifications
{
    public class CatalogItemsSpecification : BaseSpecification<CatalogItem>
    {
        public CatalogItemsSpecification(params int[] ids) : base(c => ids.Contains(c.Id))
        {

        }
    }
}
