using AutoMapper;
using sumStore.Application.DTOs.Brand;
using sumStore.Application.DTOs.Category;
using sumStore.Application.DTOs.Product;
using sumStore.Application.DTOs.Review;
using sumStore.Application.DTOs.User;
using sumStore.Domain.Entities;

namespace sumStore.Application.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CreateBrand, Brand>();
            CreateMap<CreateCategory, Category>();
            CreateMap<CreateProduct, Product>();
            CreateMap<CreateReview, Review>();
            //CreateMap<CreateUser, User>();

            CreateMap<Brand, GetBrand>();
            CreateMap<Category, GetCategory>();
            CreateMap<Product, GetProduct>();
            CreateMap<Review, GetReview>();
            //CreateMap<User, GetUser>();
        }
    }
}
