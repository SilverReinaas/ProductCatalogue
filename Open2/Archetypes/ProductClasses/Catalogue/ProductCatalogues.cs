using Open.Aids;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductCatalogues : BaseClasses.Archetypes<ProductCatalogue>
    {
        public static ProductCatalogues Instance { get; } = new ProductCatalogues();

        public static ProductCatalogues GenerateRandomInstance()
        {
            var result = new ProductCatalogues();;
            for (int i = 0; i < GetRandom.Int16(1,5); i++)
            {
                result.Add(ProductCatalogue.Random());
            }
            return result;
        }
    }
}
