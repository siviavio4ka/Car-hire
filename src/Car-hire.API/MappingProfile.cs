using AutoMapper;
using Car_hire.DAL.Entities.DTOs.CarDTO;
using Car_hire.DAL.Entities.DTOs.CustomerDTO;
using Car_hire.DAL.Entities.DTOs.EmployeeDTO;
using Car_hire.DAL.Entities.DTOs.OrderDTO;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.API;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Car, CarDto>();
        CreateMap<CarForCreationDto, Car>();
        CreateMap<CarForUpdateDto, Car>();

        CreateMap<Customer, CustomerDto>();
        CreateMap<CustomerForCreationDto, Customer>();
        CreateMap<CustomerForUpdateDto, Customer>();

        CreateMap<Employee, EmployeeDto>();
        CreateMap<EmployeeForCreationDto, Employee>();
        CreateMap<EmployeeForUpdateDto, Employee>();

        CreateMap<Order, OrderDto>();
        CreateMap<OrderForCreationDto, Order>();
        CreateMap<OrderForUpdateDto, Order>();
    }
}