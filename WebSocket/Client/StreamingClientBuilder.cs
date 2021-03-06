﻿using System;
using System.Net.Http;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

namespace GatecoinServiceInterface.WebSocket.Client
{
    public sealed class StreamingClientBuilder : IStreamingClientBuilder
    {
        private readonly string _url;
        private HttpMessageHandler _httpMessageHandler;
        private ILoggerFactory _loggerFactory;

        public StreamingClientBuilder(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("Url cannot be null", nameof(url));
            }

            _url = url;
        }

        public IStreamingClient<TDto> BuildClient<TDto>()
        {
            return new StreamingClient<TDto>(
                    _url,
                    _httpMessageHandler,
                    _loggerFactory);
        }

        [PublicAPI]
        public StreamingClientBuilder WithHttpMessageHandler(HttpMessageHandler httpMessageHandler)
        {
            _httpMessageHandler = httpMessageHandler;
            return this;
        }

        [PublicAPI]
        public StreamingClientBuilder WithLoggerFactory(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            return this;
        }
    }
}