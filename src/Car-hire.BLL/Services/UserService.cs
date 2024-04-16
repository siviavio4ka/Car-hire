using AutoMapper;
using Car_hire.BLL.Contracts;
using Car_hire.DAL.Contracts;
using Car_hire.DAL.Entities.DTOs.UserDTO.Auth;
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
        var users = await _repository.User.GetAllUsersAsync(trackChanges);
        var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
        return usersDto;
    }

    public async Task<UserDto> GetUserAsync(int userId, bool trackChanges)
    {
        var user = await _repository.User.GetUserAsync(userId, trackChanges)
            ?? throw new UserNotFoundException(userId);
        
        var userDto = _mapper.Map<UserDto>(user);
        return userDto;
    }

    public async Task<IEnumerable<UserDto>> GetUsersByOrderDateAsync(DateTime orderDate, bool trackChanges)
    {
        var users = await _repository.User.GetUsersByOrderDateAsync(orderDate, trackChanges);
        var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
        return usersDto;
    }

    public async Task UpdateUserAsync(int userId, UserForUpdateDto? user, bool trackChanges)
    {
        var userEntity = await _repository.User.GetUserAsync(userId, trackChanges)
            ?? throw new UserNotFoundException(userId);
        
        _mapper.Map(user, userEntity);
        await _repository.SaveAsync();
    }

    public async Task DeleteUserAsync(int userId, bool trackChanges)
    {
        var user = await _repository.User.GetUserAsync(userId, trackChanges)
            ?? throw new UserNotFoundException(userId);

        _repository.User.DeleteUser(user);
        await _repository.SaveAsync();
    }
}