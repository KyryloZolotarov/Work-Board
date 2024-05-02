﻿using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Extensions.Options;
using Web.Server.Data.Requests;
using Web.Server.Repositories.Interfaces;

namespace Web.Server.Repositories
{
    public class ListRepository : IListRepository
    {
        private readonly IHttpClientService _httpClient;
        private readonly IOptions<AppSettings> _settings;

        public ListRepository(IHttpClientService httpClient, IOptions<AppSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings;
        }        

        public async Task AddListAsync(AddListRequest list)
        {
            await _httpClient.SendAsync<AddListRequest>(
                $"{_settings.Value.ListCardUrl}/lists/",
            HttpMethod.Post, list);
        }

        public async Task DeleteListAsync(int id)
        {
            await _httpClient.SendAsync(
                $"{_settings.Value.ListCardUrl}/lists/{id}",
            HttpMethod.Delete);
        }

        public async Task<UserListDto> GetListsAsync(string userId)
        {
            return await _httpClient.SendAsync<UserListDto, string>(
                $"{_settings.Value.ListCardUrl}/lists/",
            HttpMethod.Get, userId);
        }

        public async Task PatchListAsync(int id, JsonPatchDocument<UpdateListRequest> list)
        {
            await _httpClient.SendAsync(
                $"{_settings.Value.ListCardUrl}/lists/{id}",
            HttpMethod.Patch, list);
        }
    }
}