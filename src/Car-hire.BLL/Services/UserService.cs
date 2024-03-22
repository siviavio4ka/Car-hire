using AutoMapper;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.DTOs.UserDTO;
using Car_hire.DAL.Entities.Exceptions.NotFoundException;
using Car_hire.DAL.Entities.Models;

namespace Car_hire.BLL.Services;

internal sealed class UserService : IUserService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public UserService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _repository = repositoryManager;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges)
    {
        var customers = await _repository.User.GetAllUsersAsync(trackChanges);
        var customersDto = _mapper.Map<IEnumerable<UserDto>>(customers);
        return customersDto;
    }

    public async Task<UserDto> GetUserAsync(int userId, bool trackChanges)
    {
        var customer = await _repository.User.GetUserAsync(userId, trackChanges)
            ?? throw new UserNotFoundException(userId);
        
        var customerDto = _mapper.Map<UserDto>(customer);
        return customerDto;
    }

    public async Task<IEnumerable<UserDto>> GetUsersByOrderDateAsync(DateTime orderDate, bool trackChanges)
    {
        var customers = await _repository.User.GetUsersByOrderDateAsync(orderDate, trackChanges);
        var customersDto = _mapper.Map<IEnumerable<UserDto>>(customers);
        return customersDto;
    }

    public async Task CreateUserAsync(UserForCreationDto? customer)
    {
        var customerEntity = _mapper.Map<User>(customer);
        _repository.User.CreateUser(customerEntity);
        await _repository.SaveAsync();
    }

    public async Task UpdateUserAsync(int userId, UserForUpdateDto? customer, bool trackChanges)
    {
        var customerEntity = await _repository.User.GetUserAsync(userId, trackChanges)
            ?? throw new UserNotFoundException(userId);
        
        _mapper.Map(customer, customerEntity);
        await _repository.SaveAsync();
    }

    public async Task DeleteUserAsync(int userId, bool trackChanges)
    {
        var customer = await _repository.User.GetUserAsync(userId, trackChanges)
            ?? throw new UserNotFoundException(userId);

        _repository.User.DeleteUser(customer);
        await _repository.SaveAsync();
    }
}