﻿using TwitterWebAPI.Models;

namespace TwitterWebAPI.Data
{
    public interface IAuthRepository
    {
        Task<Response<int>> RegisterAsync(User user, string password);
        Task<Response<string>> LoginAsync(string loginId, string password);
        Task<bool> IsUserExists(string username);
        
    }
}
