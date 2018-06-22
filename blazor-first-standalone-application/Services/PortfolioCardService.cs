using System;
using System.Collections.Generic;
using System.Diagnostics;
using blazorfirststandaloneapplication.shared.Models;
using Bogus;
using Microsoft.AspNetCore.Blazor;

namespace blazorfirststandaloneapplication.Services
{
    public class PortfolioCardService : IPortfolioCardService
    {
        public PortfolioCardService()
        {
            var userFaker = new Faker<User>()
                .CustomInstantiator(f =>
                    new User(
                        f.Internet.Password(),
                        f.Internet.UserName(),
                        f.Name.LastName(),
                        f.Name.FirstName()
                    ))
                .RuleFor(o=>o.UserId,f=>f.IndexFaker);

            var imageFaker = new Faker<Image>()
                .RuleFor(o => o.ImageId, f => f.IndexFaker)
                .RuleFor(o => o.ImageUri, f => new Uri($"https://loremflickr.com/{f.Random.Number(260, 368)}/{f.Random.Number(160, 260)}/dog"))
                ;
            
            var users = userFaker.Generate(10);
            var images = imageFaker.Generate(10);

            var portfolioCardFaker = new Faker<PortfolioCard>()
                .RuleFor(o => o.Image, f => f.PickRandom(images))
                .RuleFor(o => o.Author, f => f.PickRandom(users))
                .RuleFor(o => o.AuthorId, (f, o) => o.Author.UserId)
                .RuleFor(o => o.Description, f => f.Lorem.Paragraph(10))
                .RuleFor(o => o.Title, f => f.Lorem.Sentence(f.Random.Number(3, 7)))
                .RuleFor(o => o.PortfolioCardId, f => f.IndexFaker)
                .RuleFor(o => o.Type, f => f.PickRandom<PortfolioCardType>())
                .RuleFor(o => o.ContentAlignment, f => f.PickRandom<PortfolioCardAlignment>())
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent(14))
                ;

            //Debug.WriteLine(JsonUtil.Serialize(users));

            _portfolioCards = portfolioCardFaker.Generate(12);
        }

        private readonly List<PortfolioCard> _portfolioCards;

        public List<PortfolioCard> GetPortfolioCards()
        {
            return _portfolioCards;
        }

        public PortfolioCard GetPortfolioCard(long portfolioCardId)
        {
            return _portfolioCards.Find(p => p.PortfolioCardId == portfolioCardId);
        }
    }
}
