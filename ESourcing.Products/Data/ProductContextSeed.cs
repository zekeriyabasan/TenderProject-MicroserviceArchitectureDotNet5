using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data
{
    public class ProductContextSeed
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
            return new List<Product>()
            {

                new Product()
                {
                    Name="IPhone X",
                    Summary="This phone is summary is the company' biggest IPHONE random asdfasfasdsdfafasfsdfasg",
                    Description="Lorem ipsum dolor sit amet, consectetur random asfasfa sfdsfsd fsd,s dfasfsdfsdgsd,fsdgsdgfasfsdfasad.",
                    ImageFile ="product-1.png",
                    Price=950.00M,
                    Category="Smart Phone"
                },
                new Product()
                {
                    Name="Samsung 10",
                    Summary="This phone is summary is the company' biggest SAMSUNG random asdfasfasdsdfafasfsdfasg",
                    Description="Lorem ipsum dolor sit amet, consectetur random asfasfa sfdsfsd fsd,s dfasfsdfsdgsd,fsdgsdgfasfsdfasad.",
                    ImageFile ="product-2.png",
                    Price=840.00M,
                    Category="Smart Phone"
                },
                new Product()
                {
                    Name="Huawei Plus",
                    Summary="This phone is summary is the company' biggest HUAWEİ random asdfasfasdsdfafasfsdfasg",
                    Description="Lorem ipsum dolor sit amet, consectetur random asfasfa sfdsfsd fsd,s dfasfsdfsdgsd,fsdgsdgfasfsdfasad.",
                    ImageFile ="product-3.png",
                    Price=650.00M,
                    Category="White Appliances"
                },
                new Product()
                {
                    Name="Xiaomi Mi 9",
                    Summary="This phone is summary is the company' biggest  Xiaomi random asdfasfasdsdfafasfsdfasg",
                    Description="Lorem ipsum dolor sit amet, consectetur random asfasfa sfdsfsd fsd,s dfasfsdfsdgsd,fsdgsdgfasfsdfasad.",
                    ImageFile ="product-4.png",
                    Price=470.00M,
                    Category="White Appliances"
                },
                new Product()
                {
                    Name="LG G7 ThinQ",
                    Summary="This phone is summary is the company' biggest LG  random asdfasfasdsdfafasfsdfasg",
                    Description="Lorem ipsum dolor sit amet, consectetur random asfasfa sfdsfsd fsd,s dfasfsdfsdgsd,fsdgsdgfasfsdfasad.",
                    ImageFile ="product-4.png",
                    Price=240.00M,
                    Category="Home Kitchen"
                },
                new Product()
                {
                    Name="HTC U11+ Plus",
                    Summary="This phone is summary is the company' biggest HTC random asdfasfasdsdfafasfsdfasg",
                    Description="Lorem ipsum dolor sit amet, consectetur random asfasfa sfdsfsd fsd,s dfasfsdfsdgsd,fsdgsdgfasfsdfasad.",
                    ImageFile ="product-4.png",
                    Price=380.00M,
                    Category="Smart Phone"
                }

            };
        }
    }
}
