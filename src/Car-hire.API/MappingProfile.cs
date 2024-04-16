using AutoMapper;
using Car_hire.DAL.Entities.DTOs.CarDTO;
using Car_hire.DAL.Entities.DTOs.OrderDTO;
using Car_hire.DAL.Entities.DTOs.RoleDTO;
using Car_hire.DAL.Entities.DTOs.UserDTO.Auth;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.API;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Car, CarDto>();
        CreateMap<CarForCreationDto, Car>();
        CreateMap<CarForUpdateDto, Car>();

        CreateMap<User, UserDto>();
        CreateMap<UserForUpdateDto, User>();
        CreateMap<UserForRegistrationDto, User>();
        CreateMap<User, UserWithTokenDto>();

        CreateMap<Order, OrderDto>();
        CreateMap<OrderForCreationDto, Order>();
        CreateMap<OrderForUpdateDto, Order>();

        CreateMap<Role, RoleDto>();
        CreateMap<RoleForCreationDto, Role>();
        CreateMap<RoleForUpdateDto, Role>();
    }
}