using Microsoft.EntityFrameworkCore;
using TwitterWebAPI.Data;
using TwitterWebAPI.Dtos;
using TwitterWebAPI.Models;

namespace TwitterWebAPI.Service
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;

        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Response<List<GetUserDto>>> GetAllUsersAsync()
        {
            var response = new Response<List<GetUserDto>>();
            var user = await _appDbContext.Users.ToListAsync();
            // response.Result = user.Select(c => _mapper.Map<GetUserDto>(c)).ToList();
            return response;
        }

        //public async Task<Response<GetUserDto>> GetUserByNameAsync(string name)
        //{
        //    var response = new Response<List<GetUserDto>>();
        //    var user = await _appDbContext.Users.FirstOrDefaultAsync(u=>u.LoginId.ToLower() == name.ToLower());
        //    // response.Result = user.Select(c => _mapper.Map<GetUserDto>(c)).ToList();
        //    return response; 
        //}

        public User GetUserIdByName(string UserName)
        {
            return _appDbContext.Users.FirstOrDefault(user => user.LoginId == UserName);
        }
    }
}
