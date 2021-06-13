using ESourcing.Sourcing.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Sourcing.Data
{
    public class SourcingContextSeed
    {
        public static void SeedData(IMongoCollection<Auction> auctionCollection)
        {
            bool exist = auctionCollection.Find(p => true).Any();
            if (!exist)
            {
                auctionCollection.InsertManyAsync(GetPreconfiguredAuctions());

            }

        }
        private static IEnumerable<Auction> GetPreconfiguredAuctions()
        {

            return new List<Auction>()
                    {
                        new Auction()
                        {
                            Name="Auction 1",
                            Description="Auction desc 1",
                            CreatedAt = DateTime.Now,
                            StartedAt = DateTime.Now,
                            FinishedAt=DateTime.Now.AddDays(10),
                            ProductId="1234534323345432147890ar",
                            IncludedSellers = new List<string>()
                            {
                                "seller1@test.com",
                                "seller2@test.com",
                                "seller3@test.com"
                            },
                            Quantity=5,
                            Status=(int)Status.Active


                        },
                        new Auction()
                        {
                            Name="Auction 2",
                            Description="Auction desc 2",
                            CreatedAt = DateTime.Now,
                            StartedAt = DateTime.Now,
                            FinishedAt=DateTime.Now.AddDays(10),
                            ProductId="1234534323345432147890ar",
                            IncludedSellers = new List<string>()
                            {
                                "seller1@test.com",
                                "seller2@test.com",
                                "seller3@test.com"
                            },
                            Quantity=5,
                            Status=(int)Status.Active


                        },
                        new Auction()
                        {
                            Name="Auction 3",
                            Description="Auction desc 3",
                            CreatedAt = DateTime.Now,
                            StartedAt = DateTime.Now,
                            FinishedAt=DateTime.Now.AddDays(10),
                            ProductId="1234534323345432147890ar",
                            IncludedSellers = new List<string>()
                            {
                                "seller1@test.com",
                                "seller2@test.com",
                                "seller3@test.com"
                            },
                            Quantity=5,
                            Status=(int)Status.Active


                        }
                    };
        }
    }
}
