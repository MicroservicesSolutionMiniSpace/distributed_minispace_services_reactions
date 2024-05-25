﻿using System;
using System.Threading.Tasks;
using Convey.HTTP;
using MiniSpace.Services.Posts.Application.Dto;
using MiniSpace.Services.Posts.Application.Services.Clients;

namespace MiniSpace.Services.Events.Infrastructure.Services.Clients
{
    public class StudentsServiceClient : IStudentsServiceClient
    {
        private readonly IHttpClient _httpClient;
        private readonly string _url;
        
        public StudentsServiceClient(IHttpClient httpClient, HttpClientOptions options)
        {
            _httpClient = httpClient;
            _url = options.Services["students"];
        }
        
        public Task<StudentEventsDto> GetAsync(Guid id)
            => _httpClient.GetAsync<StudentEventsDto>($"{_url}/students/{id}/events");

    }
}