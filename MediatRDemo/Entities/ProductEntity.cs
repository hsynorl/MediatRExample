﻿namespace MediatRDemo.Models
{
    public class ProductEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
      
        public int Quntity { get; set; }

        public decimal Value { get; set; }
    }
}