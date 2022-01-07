using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ESourcing.Products.Data
{
    public static class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection) 
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProducts());
            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name="HTC",
                    Summary="Lorem ipsum1",
                    Description="Lorem ipsum1 Description",
                    ImageFile="htc.png",
                    Price=380.0M,
                    Category="Smart Phone"
                },
                new Product
                {
                    Name="Nokia",
                    Summary="Lorem ipsum2",
                    Description="Lorem ipsum2 Description",
                    ImageFile="nokia.png",
                    Price=100.0M,
                    Category="Smart Phone"
                },
                new Product
                {
                    Name="Appl",
                    Summary="Lorem ipsum3",
                    Description="Lorem ipsum3 Description",
                    ImageFile="apple.png",
                    Price=500.0M,
                    Category="Smart Phone"
                },
            };
        }
    }
}
