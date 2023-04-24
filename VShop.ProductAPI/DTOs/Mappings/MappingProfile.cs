using AutoMapper;

namespace VShop.ProductAPI.DTOs.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryDTO, CategoryDTO>().ReverseMap();     
            CreateMap<ProductDTO, ProductDTO>().ReverseMap();
        }
    }
}
