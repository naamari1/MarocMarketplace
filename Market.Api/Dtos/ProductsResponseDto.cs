﻿namespace Market.Api.Dtos
{
    public class ProductsResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryNaggmdeg { get; set; }
    }
}
