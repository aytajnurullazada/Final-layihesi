﻿using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
   public class BasketRepository: IBasketRepository
    {
        private readonly CafenodDbContext _context;

        public BasketRepository(CafenodDbContext context)
        {
            _context = context;
        }

        public Basket CreateBasket(Basket basket)
        {
            basket.AddedDate = DateTime.Now;
            basket.ModifiedDate = DateTime.Now;

            _context.Baskets.Add(basket);
            _context.SaveChanges();
            return basket;

        }

        public IEnumerable<Basket> GetBasketByToken(string token)
        {
            return _context.Baskets.Include("Product")
                                   .Where(b => b.Token == token)
                                   .ToList();
        }

        
    }
}