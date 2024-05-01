﻿using Card.Host.Models.Dtos;
using Card.Host.Models.Requests;
using Microsoft.AspNetCore.JsonPatch;

namespace Card.Host.Services.Interfaces
{
    public interface ICardService
    {
        Task<List<CardDto>> GetCardsAsync(int listId);
        Task<CardDto> GetCardAsync(int id);
        Task AddCardAsync(CardRequest card);
        Task DeleteCardAsync(int id);
        Task PatchCardAsync(int id, JsonPatchDocument<CardRequest> card);
    }
}
