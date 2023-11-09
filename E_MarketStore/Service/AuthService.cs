﻿using E_MarketStore.Models;
using E_MarketStore.Service.IService;
using E_MarketStore.Utility;

namespace E_MarketStore.Service
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseService;
        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequest)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.POST,
                Data = loginRequest,
                Url = Enums.AuthAPIBase + "/api/auth/login"
            });
        }

        public async Task<ResponseDto?> RegisterAsync(RegisterRequestDto registerRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.POST,
                Data = registerRequestDto,
                Url = Enums.AuthAPIBase + "/api/auth/register"
            });
        }

        public async Task<ResponseDto?> AssignRoleAsync(RegisterRequestDto registerRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.POST,
                Data = registerRequestDto,
                Url = Enums.AuthAPIBase + "/api/auth/assignRole"
            });
        }

    }
}